using MusicStore.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service
{
    public interface IAlbumService
    {
         int Create(Album album);
         int Update(Album album);
         int Delete(Album album);
         List<Album> GetAll();
         Album GetAlbumById(int Id);
    }
}
