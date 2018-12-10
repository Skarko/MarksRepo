using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EADMusicStore.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }

        [Display(Name = "Artist")]
        public string Name { get; set; }
    }
}