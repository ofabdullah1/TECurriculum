using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetInfoClient.Models;
using PetInfoServer.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetInfoServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private IPetDAO petDAO;

        public PetController(IPetDAO petDAO)
        {
            this.petDAO = petDAO;
        }


        [HttpGet]
        public ActionResult<List<Pet>> getPets()
        {
            return Ok(petDAO.GetPets());
        }

        //DELETE /pet/3

        [HttpDelete("{petId}")]
        public ActionResult deletePet(int petId)
        {

            bool result = petDAO.DeletePet(petId);
            if (result)
            {
                return Ok();
            }
                else
            {
                return NotFound();
            }


        }

    }
}
