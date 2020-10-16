using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
namespace csharpExam.Models {
    public class Participant {
        [Key]
        public int ParticipantId { get; set; }
        public int UserId { get; set; }
        public int ActivityId { get; set; }
        public User User { get; set; }
        public Activity Task { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}