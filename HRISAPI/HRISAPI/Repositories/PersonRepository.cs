namespace HRISAPI.Repositories;

public class PersonRepository : BaseRepository<PersonModel>, IPersonRepository
{
    public PersonRepository() : base() { }

    public IEnumerable<PersonModel> GetByAge(int age)
    {
        return _table.Where(x => x.Age == age);
    }
}
