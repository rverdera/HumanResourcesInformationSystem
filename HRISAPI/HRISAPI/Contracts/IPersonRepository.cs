namespace HRISAPI.Contracts;

public interface IPersonRepository : IBaseRepository<PersonModel>
{
    IEnumerable<PersonModel> GetByAge(int age);
}
