namespace MvcExam_Educational_Site_Atakan.Abstraction
{
    public interface ICrud<Tmodel> where Tmodel : BasePeople
    {
        public void Create(Tmodel model);
        public Tmodel Read(int id);
        public void Update(Tmodel model);
        public void Delete(int id);
    }
}
