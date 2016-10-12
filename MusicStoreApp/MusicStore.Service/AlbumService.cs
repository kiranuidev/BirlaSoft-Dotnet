using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicStore.Entities.Entities;
using MusicStore.DataAccess;

namespace MusicStore.Service
{
    public class AlbumService : IAlbumService
    {
        private AlbumDAL _dal;
        public AlbumService()
        {
            _dal = new AlbumDAL();

        }
        public int Create(Album album)
        {
            var result = _dal.CreateAlbum(album);
            return result;
        }

        public int Delete(Album album)
        {
            throw new NotImplementedException();
        }

        public Album GetAlbumById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Album> GetAll()
        {
            return _dal.GetAllAlbums();
        }

        public int Update(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
