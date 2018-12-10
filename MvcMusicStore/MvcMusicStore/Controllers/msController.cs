using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class msController : Controller
    {

        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };
            return View(album);
        }

            public ActionResult Browse(string genre)
            {
                var genreModel = new Genre { Name = genre };
                return View(genreModel);
            }

        }

    

    }

