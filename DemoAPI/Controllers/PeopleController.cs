using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    /// <summary>
    /// This is where I give you all the information about my people.
    /// </summary>
    public class PeopleController : ApiController
    {
        public List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Corey", ID = 1 });
            people.Add(new Person { FirstName = "kam", LastName = "Ouh", ID = 2 });
            people.Add(new Person { FirstName = "Hey", LastName = "Coucoute", ID = 3 });
        }
        public List<Person> Get()
        {
            return people;
        }
        /// <summary>
        /// Get a list of all users.
        /// </summary>
        /// <param name="UserID">The unique identifier</param>
        /// <param name="Age">How old they are</param>
        /// <returns> A list of the names...</returns>
        [Route("api/people/GetFirstNames/{userID:int}/{Age:int}")]
        [HttpGet]
       public List<string> GetFirstNames(int UserID, int Age)
        {
            List<string> output = new List<string>();

            foreach(var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }
        

        // GET: api/People
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.ID == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // PUT: api/People/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
