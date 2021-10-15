using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using Practica1.Domain;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Extensions.Localization;

namespace Practica1.Repositories
{
    public class PersonRepository
    {
        List<Person> _persons;
        //int edad1 = 1;
        //int edad2 = 1;
        //int edad3 = 1;
        //int ages = new List<int> { edad1, edad2, edad3 };
        public PersonRepository()
        {
            var fileName = "dummy.data.queries.json";
            if (File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json).ToList();
            }
        }
        #region"Escribe un método en el cual se retorne la información de todas las personas."
        public IEnumerable<Person> GetAll()
        {
            var query = _persons.Select(person => person);
            return query;
        }
        #endregion

        #region"Escribe un método en el cual se retorne únicamente el nombre completo de las personas, el correo y el año de nacimiento."
        public IEnumerable<Object> GetCampos()
        {
            var query = _persons.Select(person => new {
                NombreCompleto = $"{person.FirstName} {person.LastName}",
                AnioNacimiento = DateTime.Now.AddYears(person.Age * -1),
                Correo = person.Email
            });

            return query;
        }
        #endregion

        #region"Escribe un método que retorne la información de todas las personas cuyo genero sea Femenino."
        public IEnumerable<Person> GetByGenero(char genero)
        {
            //var gender = 'F';
            var query = _persons.Where(person => person.Gender == genero);
            return query;
        }
        #endregion

        #region"Escribe un método que retorne la información de todas las personas cuya edad se encuentre entre los 20 y 30 años."
        public IEnumerable<Person> GetByRangoEdad(int minAge, int maxAge)
        {
            //var minAge = 20;
            //var maxAge = 30;
            var query = _persons.Where(Person => Person.Age >= minAge && Person.Age <= maxAge);
            return query;
        }
        #endregion

        #region"Escribe un método que retorne la información de los diferentes trabajos que tienen las personas."
        public IEnumerable<string> GetDistintosTrabajos()
        {
            var query = _persons.Select(person => person.Job).Distinct();
            return query;
        }
        #endregion

        #region"Escribe un método que retorne la información de las personas cuyo nombre contenga la palabra “ar”."
        public IEnumerable<Person> GetContieneAr(string word)
        {
            var query = _persons.Where(person => person.FirstName.Contains(word));
            return query;
        }
        #endregion

        #region"Escribe un método que retorna la información de las personas cuyas edades sean 25, 35 y 45 años"
        public IEnumerable<Person> GetByEdades(int edad1, int edad2, int edad3)
        {
            var ages = new List<int> { edad1, edad2, edad3 };
            //var query = _persons.Where(Person => ages.Contains(Person.Age));
            var query = _persons.Where(person => ages.Contains(person.Age));
            return query;
        }
        #endregion

        #region"Escribe un método que retorne la información ordenas por edad para las personas que sean mayores a 40 años."
        public IEnumerable<Person> GetOrderedCuarentones(int edad)
        {
            var query = _persons.Where(person => person.Age >= edad).OrderBy(person => person.Age);
            return query;
        }
        #endregion

        #region"Escribe un método que retorne la información ordenada de manera descendente para todas las personas de género masculino y que se encuentren entre los 20 y 30 años de edad"
        public IEnumerable<Person> GetPersonsOrderedDescending(char genero, int edadMin, int edadMax)
        {
            var query = _persons.Where(person => person.Gender == genero && person.Age >= edadMin && person.Age <= edadMax).OrderByDescending(person => person.Age);
            return query;
        }
        #endregion

        #region"Escribe un método que retorne la cantidad de personas con género femenino."
        public int CountPersonas(char genero)
        {
            var query = _persons.Count(person => person.Gender == genero);
            return query;
        }
        #endregion

        #region"Escribe un método que retorna si existen personas con el apellido “Shemelt”."
        public bool PersonaExistente(string apellido)
        {
            var query = _persons.Exists(person => person.LastName == apellido);
            return query;
        }
        #endregion

        #region"Escribe un método que retorne únicamente una persona cuyo trabajo sea “Software Consultant” y tenga 25 años de edad."
        public IEnumerable<Person> GetPersonaYEdad(string trabajo, int edad)
        {
            var query = _persons.Where(person => person.Job == trabajo && person.Age == edad);
            return query;
        }
        #endregion

        #region"Escribe un método que retorne la información de las primeras 3 personas cuyo puesto de trabajo sea “Software Consultant.”"
        public IEnumerable<Person> Take3Personas(string trabajo, int take)
        {
            var query = _persons.Where(person => person.Job == trabajo).Take(take);
            return query;
        }
        #endregion

        #region"Escribe un método que omita la información de las primeras 3 personas cuyo puesto de trabajo sea “Software Consultant”"
        public IEnumerable<Person> SkipTake3Personas(string trabajo, int skip, int take)
        {
            var query = _persons.Where(person => person.Job == trabajo).Skip(skip).Take(take);
            return query;
        }
        #endregion

        #region"Escribe un método que omita la información de las primeras 3 personas y que retorne la información de las siguientes 3 personas cuyo puesto de trabajo sea “Software Consultant”"
        public IEnumerable<Person> SkipTakeNext3Personas(string trabajo, int skip, int take)
        {
            var query = _persons.Where(person => person.Job == trabajo).Skip(skip).Take(take);
            return query;
        }
        #endregion
        
    }
}