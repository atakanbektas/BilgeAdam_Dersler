namespace MustafaAtakanGokcehan_Crud.Models
{
    public class Branch
    {
        public Branch()
        {
            Students = new();
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; }
        public List<Student> Students { get; set; }
    }
}
