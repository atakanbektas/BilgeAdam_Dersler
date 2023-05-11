using MvcExam_Educational_Site_Atakan.Abstraction;

namespace MvcExam_Educational_Site_Atakan.Models
{
    public partial class Student : BasePeople, ICrud<Student>
    {
        public Student()
        {
            StudentsCourses = new HashSet<StudentsCourse>();
        }

        public int Id { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<StudentsCourse> StudentsCourses { get; set; }

        public void Create(Student model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Student model)
        {
            throw new NotImplementedException();
        }
    }
}
