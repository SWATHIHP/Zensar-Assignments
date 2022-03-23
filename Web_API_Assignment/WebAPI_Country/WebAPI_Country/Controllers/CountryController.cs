using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Country.Models;

namespace WebAPI_Country.Controllers
{
    [RoutePrefix("api/Country")]
    public class CountryController : ApiController
    {
        CountryContext c = new CountryContext();
        [HttpPost]
        public IHttpActionResult Add([FromBody] Country countries)
        {
            c.country.Add(countries);
            int count = c.SaveChanges();
            if (count > 0)
            {
                return Ok(countries);
            }
            return BadRequest("Invalid Request. Please Recheck");
        }

        [HttpGet]
        [Route("List_of_Countries")]
        public IHttpActionResult GetAll()
        {
            var res = c.country.ToList();
            if (res.Count == 0)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [HttpGet]
        [Route("Country_Details")]
        public IHttpActionResult Getbyid(int id)
        {
            var res = c.country.Find(id);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [HttpPut]

        public IHttpActionResult Edit([FromBody] Country countries)
        {
            if (countries.Id <= 0)
            {
                return NotFound();
            }
            c.Entry(countries).State = System.Data.Entity.EntityState.Modified;
            int Count = c.SaveChanges();
            if (Count > 0)
            {
                return Ok(countries);
            }
            return BadRequest("Modification Unsuccessfull...!!!");
        }

        [HttpDelete]
        public IHttpActionResult Delete([FromBody] Country countries)
        {
            if (countries.Id <= 0)
            {
                return NotFound();
            }
            c.Entry(countries).State = System.Data.Entity.EntityState.Deleted;
            int Count = c.SaveChanges();
            if (Count > 0)
            {
                return Ok(countries);
            }
            return BadRequest("Deletion Unsuccessfull...!!!");

        }
    }
}
