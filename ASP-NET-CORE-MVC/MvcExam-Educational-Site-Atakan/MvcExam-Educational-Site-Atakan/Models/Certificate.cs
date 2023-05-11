using System;
using System.Collections.Generic;

namespace MvcExam_Educational_Site_Atakan.Models
{
    public partial class Certificate
    {
        public Certificate()
        {
            CoursesCertificates = new HashSet<CoursesCertificate>();
        }

        public int Id { get; set; }
        public string? PicturePath { get; set; }

        public virtual ICollection<CoursesCertificate> CoursesCertificates { get; set; }
    }
}
