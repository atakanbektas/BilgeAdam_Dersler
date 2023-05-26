namespace ETicaretApp.Domain.Entities.General
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public Guid? UId { get; set; } = Guid.NewGuid();
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
    }
}
