using MvcExam_Educational_Site_Atakan.Abstraction;

namespace MvcExam_Educational_Site_Atakan.Models
{
    public partial class Teacher : BasePeople, ICrud<Teacher>
    {
        public Teacher()
        {
            Courses = new HashSet<Course>();
        }
        public int Id { get; set; }
        public string? EducationInfo { get; set; }
        public string? WorkingInfo { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public void Create(Teacher model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Teacher Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Teacher model)
        {
            throw new NotImplementedException();
        }
    }
}
