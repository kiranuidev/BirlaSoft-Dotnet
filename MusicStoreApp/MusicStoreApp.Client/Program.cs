using MusicStore.Entities.Entities;
using MusicStore.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreApp.Client
{
    public class Program
    {
       public static void Main(string[] args)
        {
            ArtistService service = new ArtistService();
            Artist artist = new Artist();
            artist.Id = 1;
            artist.Name = "Rehman";
            service.CreateArtist(artist);
        }
    }

    
}
