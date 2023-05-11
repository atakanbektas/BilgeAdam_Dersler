namespace MvcExam_Educational_Site_Atakan.Models
{
    public partial class Video
    {
        public int Id { get; set; }
        public string? VideoPath { get; set; }
        public int? CourseId { get; set; }
        public virtual Course? Course { get; set; }
    }
}
