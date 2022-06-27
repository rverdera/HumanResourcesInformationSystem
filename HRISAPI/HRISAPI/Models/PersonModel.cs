namespace HRISAPI.Models;

public class PersonModel : IBaseModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
