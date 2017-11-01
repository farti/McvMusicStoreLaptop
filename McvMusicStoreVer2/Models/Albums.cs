using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace McvMusicStoreVer2.Models
{
    public class Albums
    {
        public int AlbumID { get; set; }

        public string Title { get; set; }

        public Artist Artist { get; set; }

        public virtual List<Review> List { get; set; }
    }
}