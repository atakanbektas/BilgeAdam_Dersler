using System;
using System.Collections.Generic;

namespace MvcExam_Educational_Site_Atakan.Models
{
    public partial class CoursesCertificate
    {
        public int CourseId { get; set; }
        public int CertificateId { get; set; }
        public DateTime? IssueDate { get; set; }

        public virtual Certificate Certificate { get; set; } = null!;
        public virtual Course Course { get; set; } = null!;
    }
}
