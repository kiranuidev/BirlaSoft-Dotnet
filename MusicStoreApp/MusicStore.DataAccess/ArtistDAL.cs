using MusicStore.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DataAccess
{
    public class ArtistDAL
    {
        public int CreateArtist(Artist artist)
        {
            if (artist.Id > 0)
            {
                return 1;
            }
            return 0;
        }

    }
}
