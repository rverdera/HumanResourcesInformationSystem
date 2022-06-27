namespace HRISAPI.Models;

public class PersonModel : IBaseModel
{
    public int Id { get; set; }
    [Required(ErrorMessage ="Required ang pangalan")]
    public string Name { get; set; }
    [Required,Range(18,100)]
    public int Age { get; set; }

   
}
