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
using TrafficTicketsSystem10.Models;

namespace TrafficTicketsSystem10.TrafficControllers
{
    public class ViolationTypesController : ApiController
    {
        private TicketsManagementModel db = new TicketsManagementModel();

        // GET: api/ViolationTypes
        public IQueryable<ViolationType> GetViolationTypes()
        {
            return db.ViolationTypes;
        }

        // GET: api/ViolationTypes/5
        [ResponseType(typeof(ViolationType))]
        public IHttpActionResult GetViolationType(int id)
        {
            ViolationType violationType = db.ViolationTypes.Find(id);
            if (violationType == null)
            {
                return NotFound();
            }

            return Ok(violationType);
        }

        // PUT: api/ViolationTypes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutViolationType(int id, ViolationType violationType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != violationType.ViolationTypeId)
            {
                return BadRequest();
            }

            db.Entry(violationType).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ViolationTypeExists(id))
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

        // POST: api/ViolationTypes
        [ResponseType(typeof(ViolationType))]
        public IHttpActionResult PostViolationType(ViolationType violationType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ViolationTypes.Add(violationType);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = violationType.ViolationTypeId }, violationType);
        }

        // DELETE: api/ViolationTypes/5
        [ResponseType(typeof(ViolationType))]
        public IHttpActionResult DeleteViolationType(int id)
        {
            ViolationType violationType = db.ViolationTypes.Find(id);
            if (violationType == null)
            {
                return NotFound();
            }

            db.ViolationTypes.Remove(violationType);
            db.SaveChanges();

            return Ok(violationType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ViolationTypeExists(int id)
        {
            return db.ViolationTypes.Count(e => e.ViolationTypeId == id) > 0;
        }
    }
}