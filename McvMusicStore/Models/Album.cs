using System.Collections.Generic;

namespace McvMusicStore.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        public string Title { get; set; }
        
        public Artist Artist { get; set; }

        public virtual List<Review> List { get; set; }
    }
}