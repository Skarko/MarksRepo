

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;
 
namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();

        public ActionResult Index()

            {
            var genres = storeDB.Genres.ToList();
            return View(genres);
            }



    //    {
    //        var genres = new List<Genre>
    //{
    //    new Genre { Name = "Disco"},
    //    new Genre { Name = "Jazz"},
    //    new Genre { Name = "Rock"}
    //};
    //        return View(genres);
    //    }


        
        //
        // GET: /Store/Browse?genre=Disco
        public string Browse(string genre)
        {

            // Retrieve Genre and its Associated Albums from database
            var genreModel = storeDB.Genres.Include("Albums")
                .Single(g => g.Name == genre);

            return "test";
                //View(genreModel);
            
           string message = HttpUtility.HtmlEncode("Store.Browse, Genre = "
        + genre);

            //return message;

        }
        //
        // GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };
            return View(album);
        }
    }
}

    

