namespace MustafaAtakanGokcehan_Crud.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }

        public Branch? Branch { get; set; }
        public int BranchId { get; set; }
    }
}
