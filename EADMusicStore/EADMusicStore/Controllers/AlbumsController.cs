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
using EADMusicStore.Models;

namespace EADMusicStore.Controllers
{
    public class AlbumsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Albums
        [ResponseType(typeof(IEnumerable<String>))]
        [HttpGet]
        public IHttpActionResult GetAlbums()
        {
            // ensure there is at least one property in the list
            if (db.Albums.Count() == 0)
                return NotFound();
            
            var albums = db.Albums.Select(w => w.Title);      
            return Ok(albums);
        }
    }
}