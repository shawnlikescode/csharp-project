using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace csharpExam.Models {
    public class HomeModels {
        public List<Activity> AllActivities { get; set; }
        public User User { get; set; }
        public List<User> AllUsers { get; set; }
        public List<Activity> JoinedActivities { get; set; }
    }
}