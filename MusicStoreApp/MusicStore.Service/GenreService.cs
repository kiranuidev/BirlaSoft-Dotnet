using MusicStore.DataAccess;
using MusicStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service
{
    public class GenreService
    {
        private GenreDAL _dalGenre;
            public GenreService()
        {
            _dalGenre = new GenreDAL();
        }
        //public List<Genre> GetGenre()
        //{
        //    var genreList = new List<Genre>();
        //    genreList.Add(new Genre() { GenreId = 1, Name = "Rock" });
        //    genreList.Add(new Genre() { GenreId = 2, Name = "Jazz" });
        //    return genreList;
        //}

        public List<Genre> GetAllGenre()
        {
            return _dalGenre.GetAllArtists();
        }
    }
}
