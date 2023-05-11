using System;
using System.Collections.Generic;

namespace MvcExam_Educational_Site_Atakan.Models
{
    public partial class Course
    {
        public Course()
        {
            CoursesCertificates = new HashSet<CoursesCertificate>();
            Exams = new HashSet<Exam>();
            StudentsCourses = new HashSet<StudentsCourse>();
            Videos = new HashSet<Video>();
        }

        public int Id { get; set; }
        public int? TeacherId { get; set; }
        public int? CategoryId { get; set; }
        public string? CourseName { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public TimeSpan? Duration { get; set; }
        public double? Rating { get; set; }
        public string? PicturePath { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Teacher? Teacher { get; set; }
        public virtual ICollection<CoursesCertificate> CoursesCertificates { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<StudentsCourse> StudentsCourses { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}
