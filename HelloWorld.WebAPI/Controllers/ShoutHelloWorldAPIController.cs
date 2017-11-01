using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using HelloWorld.WebAPI.Models;
using Newtonsoft.Json;

namespace HelloWorld.WebAPI.Controllers
{
    public class ShoutHelloWorldAPIController : ApiController
    {
        private TESTDATABASEEntities1 db = new TESTDATABASEEntities1();

        // GET: api/ShoutHelloWorldAPI
        public  IQueryable<GreetingTbl> GetGreetingTbls()
        {
            var response = db.GreetingTbls;
            
            return response;
            
        }

        // GET: api/ShoutHelloWorldAPI/5
        [ResponseType(typeof(GreetingTbl))]
        public IHttpActionResult GetGreetingTbl(string id)
        {
            GreetingTbl greetingTbl = db.GreetingTbls.Find(id);
            if (greetingTbl == null)
            {
                return NotFound();
            }

            return Ok(greetingTbl);
        }

        // PUT: api/ShoutHelloWorldAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGreetingTbl(string id, GreetingTbl greetingTbl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != greetingTbl.GreetingID)
            {
                return BadRequest();
            }

            db.Entry(greetingTbl).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GreetingTblExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ShoutHelloWorldAPI
        [ResponseType(typeof(GreetingTbl))]
        public IHttpActionResult PostGreetingTbl(GreetingTbl greetingTbl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GreetingTbls.Add(greetingTbl);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (GreetingTblExists(greetingTbl.GreetingID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = greetingTbl.GreetingID }, greetingTbl);
        }

        // DELETE: api/ShoutHelloWorldAPI/5
        [ResponseType(typeof(GreetingTbl))]
        public IHttpActionResult DeleteGreetingTbl(string id)
        {
            GreetingTbl greetingTbl = db.GreetingTbls.Find(id);
            if (greetingTbl == null)
            {
                return NotFound();
            }

            db.GreetingTbls.Remove(greetingTbl);
            db.SaveChanges();

            return Ok(greetingTbl);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GreetingTblExists(string id)
        {
            return db.GreetingTbls.Count(e => e.GreetingID == id) > 0;
        }
    }
}