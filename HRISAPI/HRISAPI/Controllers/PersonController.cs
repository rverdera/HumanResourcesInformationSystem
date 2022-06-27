﻿namespace HRISAPI.Controllers;

public class PersonController : BaseController<PersonModel>
{
    public PersonController(IBaseRepository<PersonModel> baseRepository) : base(baseRepository)
    {
    }
}
