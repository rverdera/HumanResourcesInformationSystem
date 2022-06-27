namespace HRISAPI.Contracts;

public interface IBaseRepository<T>
{
    IEnumerable<T> GetAll();
    T GetOne(int id);
    void Add(T _model);
    void Update(T _model);
    void Delete(int id);
}


