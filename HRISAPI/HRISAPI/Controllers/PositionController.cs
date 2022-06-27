using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRISAPI.Controllers
{

    public class PositionController : BaseController<PositionModel>
    {
        private readonly IPositionRepository _positionRepository;

        public PositionController(IPositionRepository positionRepository) : base(positionRepository)
        {
            _positionRepository = positionRepository;
        }
    }
}
