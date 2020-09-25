using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.UseCases.AddPerson;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        //add rest of CRUD Interactors here and other endpoints for that operations
        private readonly AddPersonInteractor addPersonInteractor;

        public PersonsController(AddPersonInteractor addPersonInteractor)
        {
            this.addPersonInteractor = addPersonInteractor;
        }

        [HttpPost]
        public ActionResult PostPerson(AddPersonRequest addPersonRequest)
        {
            var addPersonResponse = this.addPersonInteractor.Handle(addPersonRequest);
            if (addPersonResponse.PersonId != 0)
                return Ok(addPersonResponse);
            else
                return BadRequest();
        }
    }
}
