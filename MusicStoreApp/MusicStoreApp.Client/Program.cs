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
            // var result = CreateAlbum();
            // var result = GetAllAlbums();
            Demo<string> demo = new Demo<string>("Kiran");
            demo.LogToConsole();
            Demo<int> demoInt = new Demo<int>(100);
            demoInt.LogToConsole();
            Console.ReadKey();
           
        }

        public static int CreateAtrtist()
        {
            ArtistService service = new ArtistService();
            Artist artist = new Artist();
            artist.Name = "Rehman";
            var result =service.CreateArtist(artist);
            return result;
        }

        public static int CreateAlbum()
        {
            var albumService = new AlbumService();
            var album = new Album();
            album.ArtistId = 280;
            album.GenreId = 9;
            album.Title = "Songs of Earth";
            album.AlbumArtUrl = "http://localhost:8080";
            album.Price = 1000;
            var result = albumService.Create(album);
            return result;
           
        }

        public static List<Album> GetAllAlbums()
        {
            var albumService = new AlbumService();
            return albumService.GetAll();
        }
    }

    
}
