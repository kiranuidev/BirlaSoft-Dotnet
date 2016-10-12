using MusicStore.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace MusicStore.DataAccess
{
    public class ArtistDAL:DABase
    {
       
        private SqlCommand _cmd;

        public ArtistDAL()
        {
            _cmd = new SqlCommand();
        }
        public int CreateArtist(Artist artist)
        {
            try
            {
                _cmd.CommandType = System.Data.CommandType.Text;
                _cmd.CommandText = "INSERT INTO [Artist] VALUES ('" + artist.Name + "')";
                _connection.Open();
                _cmd.Connection = _connection;
                var result = _cmd.ExecuteNonQuery();
                _connection.Close();
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

    }
}
