namespace HRISAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BaseController<T> : ControllerBase
{
    private readonly IBaseRepository<T> _baseRepository;
    public BaseController(IBaseRepository<T> baseRepository)
    {
        _baseRepository = baseRepository;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_baseRepository.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult GetOne(int id)
    {
        var user = _baseRepository.GetOne(id);
        if (user == null)
            return NotFound();
        return Ok(user);
    }

    [HttpPost]
    public IActionResult Create([FromBody]T model)
    {
        _baseRepository.Add(model);
        return Ok();
    }

    [HttpPut]
    public IActionResult Update([FromBody] T model)
    {
        _baseRepository.Update(model);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _baseRepository.Delete(id);
        return Ok();
    }
}
