using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace csharpExam.Models {
    public class Activity {
        [Key]
        public int ActivityId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters")]
        public string Title { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Must be at least 10 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage="This is a required field")]
        [FutureDate]
        [Display(Name = "Date")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage="This is a required field")]
        [Display(Name = "Length")]
        public int Length { get; set; }

        [Required(ErrorMessage="This is a required field")]
        public string Time { get; set; }

        public int CoordinatorId { get; set; }
        public List<Participant> Participants { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public class FutureDate : ValidationAttribute {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
                if (((DateTime) value) <= DateTime.Now)
                    return new ValidationResult("You must set a date in the future.");
                return ValidationResult.Success;
            }
        }

    }
}