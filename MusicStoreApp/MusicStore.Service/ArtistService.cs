using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStore.Entities.Entities;
using MusicStore.DataAccess;

namespace MusicStore.Service
{
    public class ArtistService : IArtistService
    {
        private ArtistDAL _dalArtist;
        public ArtistService()
        {
            _dalArtist = new ArtistDAL();
        }
        public int CreateArtist(Artist artist)
        {
            return _dalArtist.CreateArtist(artist);
        }
        

        public List<Artist> GetArtists()
        {
            return _dalArtist.GetAllArtists();
        }
    }
}
