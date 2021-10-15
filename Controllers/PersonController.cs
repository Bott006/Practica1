using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practica1.Repositories;


namespace Practica1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        #region"GetAll"
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        }
        #endregion

        #region"GetCampos"
        [HttpGet]
        [Route("GetCampos")]
        public IActionResult GetCampos()
        {
            var repository = new PersonRepository();
            var persons = repository.GetCampos();
            return Ok(persons);
        }
        #endregion

        #region"GetByGenero"
        [HttpGet]
        [Route("GetByGenero")]
        public IActionResult GetByGenero(char genero)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGenero(genero);
            return Ok(persons);
        }
        #endregion

        #region"GetByRangoEdad"
        [HttpGet]
        [Route("GetByRangoEdad")]
        public IActionResult GetByRangoEdad(int minAge, int maxAge)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByRangoEdad(minAge, maxAge);
            return Ok(persons);
        }
        #endregion

        #region"GetDistintosTrabajos"
        [HttpGet]
        [Route("GetDistintosTrabajos")]
        public IActionResult GetDistintosTrabajos()
        {
            var repository = new PersonRepository();
            var persons = repository.GetDistintosTrabajos();
            return Ok(persons);
        }
        #endregion

        #region"GetContieneAr"
        [HttpGet]
        [Route("GetContieneAr")]
        public IActionResult GetContieneAr(string word)
        {
            var repository = new PersonRepository();
            var persons = repository.GetContieneAr(word);
            return Ok(persons);
        }
        #endregion

        #region"GetByEdades"
        [HttpGet]
        [Route("GetByEdades")]
        public IActionResult GetByEdades(int edad1, int edad2, int edad3)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByEdades(edad1, edad2, edad3);
            return Ok(persons);
        }
        #endregion

        #region"GetOrderedCuarentones"
        [HttpGet]
        [Route("GetOrderedCuarentones")]
        public IActionResult GetOrderedCuarentones(int edad)
        {
            var repository = new PersonRepository();
            var persons = repository.GetOrderedCuarentones(edad);
            return Ok(persons);
        }
        #endregion

        #region"GetPersonsOrderedDescending"
        [HttpGet]
        [Route("GetPersonsOrderedDescending")]
        public IActionResult GetPersonsOrderedDescending(char genero, int edadMin, int edadMax)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrderedDescending(genero, edadMin, edadMax);
            return Ok(persons);
        }
        #endregion

        #region"CountPersonas"
        [HttpGet]
        [Route("CountPersonas")]
        public IActionResult CountPersonas(char genero)
        {
            var repository = new PersonRepository();
            var persons = repository.CountPersonas(genero);
            return Ok(persons);
        }
        #endregion

        #region"PersonaExistente"
        [HttpGet]
        [Route("PersonaExistente")]
        public IActionResult PersonaExistente(string apellido)
        {
            var repository = new PersonRepository();
            var persons = repository.PersonaExistente(apellido);
            return Ok(persons);
        }
        #endregion

        #region"GetPersonaYEdad"
        [HttpGet]
        [Route("GetPersonaYEdad")]
        public IActionResult GetPersonaYEdad(string trabajo, int edad)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonaYEdad(trabajo, edad);
            return Ok(persons);
        }
        #endregion

        #region"Take3Personas"
        [HttpGet]
        [Route("Take3Personas")]
        public IActionResult Take3Personas(string trabajo, int take)
        {
            var repository = new PersonRepository();
            var persons = repository.Take3Personas(trabajo, take);
            return Ok(persons);
        }
        #endregion

        #region"SkipTake3Personas"
        [HttpGet]
        [Route("SkipTake3Personas")]
        public IActionResult SkipTake3Personas(string trabajo, int skip, int take)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipTake3Personas(trabajo, skip, take);
            return Ok(persons);
        }
        #endregion

        #region"SkipTakeNext3Personas"
        [HttpGet]
        [Route("SkipTakeNext3Personas")]
        public IActionResult SkipTakeNext3Personas(string trabajo, int skip, int take)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipTakeNext3Personas(trabajo, skip, take);
            return Ok(persons);
        }
        #endregion


    }
}
