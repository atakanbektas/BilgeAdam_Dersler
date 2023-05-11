using System;
using System.Collections.Generic;

namespace MvcExam_Educational_Site_Atakan.Models
{
    public partial class Exam
    {
        public int Id { get; set; }
        public int? CourseId { get; set; }
        public string? ExamName { get; set; }
        public string? Description { get; set; }
        public DateTime? ExamDate { get; set; }
        public TimeSpan? Duration { get; set; }
        public int? Point { get; set; }

        public virtual Course? Course { get; set; }
    }
}
