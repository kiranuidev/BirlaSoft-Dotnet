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
    public class ArtistDAL
    {
        private string _connectionString;
        private SqlConnection _conn;
        private SqlCommand _cmd;

        public ArtistDAL()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MusicStoreDB"].ConnectionString;
            _conn = new SqlConnection(_connectionString);
            _cmd = new SqlCommand();
        }
        public int CreateArtist(Artist artist)
        {

            try
            {
               
                _cmd.CommandType = System.Data.CommandType.Text;
                _cmd.CommandText = "INSERT INTO [Artist] VALUES ('" + artist.Name + "')";
                _conn.Open();
                _cmd.Connection = _conn;
                var result = _cmd.ExecuteNonQuery();
                _conn.Close();
                return result;
            }
            catch (Exception ex)
            {

                return 0;
            }

        }

    }
}
