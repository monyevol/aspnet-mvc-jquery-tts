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
    public class TrafficViolationsController : ApiController
    {
        private TicketsManagementModel db = new TicketsManagementModel();

        // GET: api/TrafficViolations
        public IQueryable<TrafficViolation> GetTrafficViolations()
        {
            return db.TrafficViolations;
        }

        // GET: api/TrafficViolations/5
        [ResponseType(typeof(TrafficViolation))]
        public IHttpActionResult GetTrafficViolation(int id)
        {
            TrafficViolation trafficViolation = db.TrafficViolations.Find(id);
            if (trafficViolation == null)
            {
                return NotFound();
            }

            return Ok(trafficViolation);
        }

        // PUT: api/TrafficViolations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTrafficViolation(int id, TrafficViolation trafficViolation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != trafficViolation.TrafficViolationId)
            {
                return BadRequest();
            }

            db.Entry(trafficViolation).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrafficViolationExists(id))
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

        // POST: api/TrafficViolations
        [ResponseType(typeof(TrafficViolation))]
        public IHttpActionResult PostTrafficViolation(TrafficViolation trafficViolation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TrafficViolations.Add(trafficViolation);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = trafficViolation.TrafficViolationId }, trafficViolation);
        }

        // DELETE: api/TrafficViolations/5
        [ResponseType(typeof(TrafficViolation))]
        public IHttpActionResult DeleteTrafficViolation(int id)
        {
            TrafficViolation trafficViolation = db.TrafficViolations.Find(id);
            if (trafficViolation == null)
            {
                return NotFound();
            }

            db.TrafficViolations.Remove(trafficViolation);
            db.SaveChanges();

            return Ok(trafficViolation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TrafficViolationExists(int id)
        {
            return db.TrafficViolations.Count(e => e.TrafficViolationId == id) > 0;
        }
    }
}