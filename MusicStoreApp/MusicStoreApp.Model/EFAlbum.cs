using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreApp.Model
{
    public class EFAlbum
    {
        private MvcMusicStoreEntities _albumContext;
        public EFAlbum()
        {
            _albumContext = new MvcMusicStoreEntities();
        }

        public List<Album> GetAll()
        {
            return _albumContext.Albums.ToList();
        }
        public int CreateAlbum(Album album)
        {
            _albumContext.Albums.Add(album);
            return _albumContext.SaveChanges();
        }

        public List<Genre> GetGenre()
        {
            return _albumContext.Genres.ToList();

        }
        public List<Artist> GetArtists()
        {
            return _albumContext.Artists.ToList();
        }



    }
}
