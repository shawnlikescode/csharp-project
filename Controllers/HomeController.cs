using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csharpExam.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace csharpExam.Controllers {
    public class HomeController : Controller {

        private MyContext _context;
        public HomeController(MyContext context) {
            _context = context;
        }

        // INDEX PAGE
        [HttpGet("")]
        public IActionResult Index() {
            return View();
        }
        // LOGOUT ROUTE
        [HttpGet("Logout")]
        public IActionResult Logout() {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        // REGISTER ROUTE
        [HttpPost("Register")]
        public IActionResult Register(User newUser) {
            if (ModelState.IsValid) {
                if (_context.Users.Any(e => e.Email == newUser.Email)) {
                    ModelState.AddModelError("Email", "Email is already in use! Try logging in.");
                    return View("Index");
                } else {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    _context.Add(newUser);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("logged_in", newUser.UserId);
                    return RedirectToAction("Home");
                }
            } else {
                return View("Index");
            }
        }

        // LOGIN ROUTE
        [HttpPost("Login")]
        public IActionResult Login(LUser login) {
            if (ModelState.IsValid) {
                User userInDb = _context.Users.FirstOrDefault(u => u.Email == login.LEmail);
                if (userInDb == null) {
                    ModelState.AddModelError("Email", "Invalid email or password.");
                    return View("Index");
                } else {
                    var hasher = new PasswordHasher<LUser>();
                    var result = hasher.VerifyHashedPassword(login, userInDb.Password, login.LPassword);
                    if (result == 0) {
                        ModelState.AddModelError("Email", "Invalid email or password.");
                        return View("Index");
                    }
                    HttpContext.Session.SetInt32("logged_in", userInDb.UserId);
                    return Redirect("Home");
                }
            } else {
                return View("Index");
            }
        }

        // SUCCESS ROUTE
        [HttpGet("Success")]
        public IActionResult Success() {
            int? loggedIn = HttpContext.Session.GetInt32("logged_in");
            if (loggedIn != null) {
                ViewBag.User = _context.Users.FirstOrDefault(a => a.UserId == (int) loggedIn);
                return View("");
            } else {
                return RedirectToAction("Index");
            }
        }

        [HttpGet("Home")]
        public IActionResult Home() {
            int? loggedIn = HttpContext.Session.GetInt32("logged_in");
            if (loggedIn != null) {

                User thisUser = _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("logged_in"));
                ViewBag.ThisUser = thisUser;

                List<Activity> AllActivities = _context.Activities
                    .Include(w => w.Participants)
                    .ThenInclude(a => a.User)
                    .OrderBy(d => d.Date)
                    .ToList();

                foreach (Activity a in AllActivities.ToList()) {
                    if (a.Date < DateTime.Now) {
                        AllActivities.Remove(a);
                    }
                }
                ViewBag.AllActivities = AllActivities;

                List<User> userCoordinator = _context.Users.ToList();
                ViewBag.userCoordinator = userCoordinator;

                return View("Home");

            }
            return RedirectToAction("Index");
        }

        // ADD NEW PAGE
        [HttpGet("New")]
        public IActionResult New() {
            if (HttpContext.Session.GetInt32("logged_in") == null) {
                return RedirectToAction("Index");
            }
            return View("New");
        }

        // CREATE NEW ROUTE
        [HttpPost("Create")]
        public IActionResult Create(Activity activity) {
            if (ModelState.IsValid) {
                activity.CoordinatorId = (int) HttpContext.Session.GetInt32("logged_in");
                _context.Add(activity);
                _context.SaveChanges();
                Activity newActivity = _context.Activities.OrderByDescending(w => w.CreatedAt).FirstOrDefault();
                return Redirect($"/activity/{newActivity.ActivityId}");
            }
            return View("New", activity);
        }

        //Delete - GET
        [HttpGet("delete/{Id}")]
        public IActionResult Delete(int Id) {
            Activity toDelete = _context.Activities.SingleOrDefault(a => a.ActivityId == Id);
            _context.Activities.Remove(toDelete);
            _context.SaveChanges();
            return RedirectToAction("Home");
        }

        // VIEW ONE
        [HttpGet("activity/{Id}")]
        public IActionResult ViewOne(int Id) {
            if (HttpContext.Session.GetInt32("logged_in") == null) {
                return RedirectToAction("Index");
            }
            User thisUser = _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("logged_in"));
            ViewBag.ThisUser = thisUser;

            Activity thisActivity = _context.Activities.FirstOrDefault(a => a.ActivityId == Id);
            ViewBag.thisActivity = thisActivity;

            User coordinator = _context.Users.FirstOrDefault(u => u.UserId == thisActivity.CoordinatorId);
            ViewBag.coordinator = coordinator;

            if (HttpContext.Session.GetInt32("logged_in") == null) {
                return RedirectToAction("Index");
            }

            Activity Participant = _context.Activities
                .Include(a => a.Participants)
                .ThenInclude(u => u.User)
                .FirstOrDefault(b => b.ActivityId == Id);

            ViewBag.AllParticipants = Participant;

            return View("Activity");
        }

        [HttpGet("join/{Id}")]
        public IActionResult Join(int Id) {
            Participant participation = new Participant();
            participation.UserId = (int) HttpContext.Session.GetInt32("logged_in");
            participation.ActivityId = Id;
            _context.Participants.Add(participation);
            Console.WriteLine(_context.Participants.Add(participation));
            _context.SaveChanges();
            return RedirectToAction("Home");
        }

        [HttpGet("leave/{Id}")]
        public IActionResult Leave(int Id) {
            Participant user = _context.Participants.FirstOrDefault(a => a.ParticipantId == Id);
            _context.Participants.Remove(user);
            _context.SaveChanges();
            return RedirectToAction("Home");
        }

    }
}