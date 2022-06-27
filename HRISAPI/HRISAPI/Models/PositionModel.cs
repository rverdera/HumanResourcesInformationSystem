
namespace HRISAPI.Models;

public class PositionModel : IBaseModel
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required(AllowEmptyStrings = true)]
    public string Description { get; set; }
}

