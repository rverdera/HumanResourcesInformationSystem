namespace HRISAPI.Infrastracture;

public class FakeDbContext
{
    public FakeDbContext()
    {
        UserModels = new List<UserModel>();
        PersonModels = new List<PersonModel>();
    }

    public List<UserModel> UserModels { get; set; }
    public List<PersonModel> PersonModels { get; set; }

    public List<T> GetTable<T>()
    {
        return GetType()
            .GetProperties()
            .FirstOrDefault(p => p.GetValue(this, null) is List<T>)?
            .GetValue(this, null) as List<T>;
    }
}
