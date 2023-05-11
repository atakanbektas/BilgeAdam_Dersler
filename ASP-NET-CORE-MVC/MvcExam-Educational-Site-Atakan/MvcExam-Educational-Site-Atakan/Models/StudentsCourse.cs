using System;
using System.Collections.Generic;

namespace MvcExam_Educational_Site_Atakan.Models
{
    public partial class StudentsCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public string? Status { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
