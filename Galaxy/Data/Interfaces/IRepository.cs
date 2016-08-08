namespace Data.Interfaces
{
    public interface IRepository<T>
    {
        void Create(T model);
        T Read(int id);
        void Update(T model);
        void Delete(int id);
    }
}