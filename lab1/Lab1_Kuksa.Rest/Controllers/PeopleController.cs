using lab1_Kuksa.Rest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1_Kuksa.Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        public PeopleDb db;
        public PeopleController(PeopleDb db)
        {
            this.db = db;
        }

        ////Get
        //[HttpGet]

        //public IActionResult Get()
        //{

        //    var people = db.People.ToList();


        //    return Ok(people);
        //}
        ////Post
        //[HttpGet]
        //public async Task<ActionResult<Person>> PostPerson(Person person)
        //{

        //    db.People.Add(person);
        //    await db.SaveChangesAsync();

        //    return Ok(person);

        //}

        //PUT
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutPerson(long id, Person person)
        //{
        //    if (id != person.PersonId)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(person).State = EntityState.Modified;

        //    return NoContent();
        //}

        //GET by ID
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Person>> GetPerson(int id)
        //{
        //    var person = await db.People.FindAsync(id);

        //    if (person == null)
        //    {
        //        return NotFound();
        //    }

        //    return person;
        //}

        //DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(long id)
        {
            var person = await db.People.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            db.People.Remove(person);
            await db.SaveChangesAsync();

            return NoContent();
        }
    }
}
