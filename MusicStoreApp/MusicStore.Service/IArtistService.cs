using MusicStore.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service
{
    public interface IArtistService
    {
        int CreateArtist(Artist artist);
    }
}
