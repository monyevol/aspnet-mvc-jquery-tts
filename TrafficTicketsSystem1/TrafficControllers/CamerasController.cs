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
    public class CamerasController : ApiController
    {
        private TicketsManagementModel db = new TicketsManagementModel();

        // GET: api/Cameras
        public IQueryable<Camera> GetCameras()
        {
            return db.Cameras;
        }

        // GET: api/Cameras/5
        [ResponseType(typeof(Camera))]
        public IHttpActionResult GetCamera(int id)
        {
            Camera camera = db.Cameras.Find(id);
            if (camera == null)
            {
                return NotFound();
            }

            return Ok(camera);
        }

        // PUT: api/Cameras/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCamera(int id, Camera camera)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != camera.CameraId)
            {
                return BadRequest();
            }

            db.Entry(camera).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CameraExists(id))
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

        // POST: api/Cameras
        [ResponseType(typeof(Camera))]
        public IHttpActionResult PostCamera(Camera camera)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cameras.Add(camera);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = camera.CameraId }, camera);
        }

        // DELETE: api/Cameras/5
        [ResponseType(typeof(Camera))]
        public IHttpActionResult DeleteCamera(int id)
        {
            Camera camera = db.Cameras.Find(id);
            if (camera == null)
            {
                return NotFound();
            }

            db.Cameras.Remove(camera);
            db.SaveChanges();

            return Ok(camera);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CameraExists(int id)
        {
            return db.Cameras.Count(e => e.CameraId == id) > 0;
        }
    }
}