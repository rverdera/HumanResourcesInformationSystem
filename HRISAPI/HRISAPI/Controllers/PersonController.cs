namespace HRISAPI.Controllers;

public class PersonController : BaseController<PersonModel>
{
    private readonly IPersonRepository _personRepository;

    public PersonController(IPersonRepository personRepository) : base(personRepository)
    {
        _personRepository = personRepository;
    }

    [HttpGet("ByAge/{age}")]
    public IActionResult GetByAge(int age)
    {
        return Ok(_personRepository.GetByAge(age));
    }
}
