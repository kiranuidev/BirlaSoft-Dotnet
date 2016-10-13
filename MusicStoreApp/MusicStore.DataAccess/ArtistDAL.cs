using MusicStore.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace MusicStore.DataAccess
{
    public class ArtistDAL:DABase
    {
       
        private SqlCommand _cmd;
        private string getAll_SP = "USP_GET_ARTISTS";
        private SqlDataAdapter _da;

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

        public List<Artist> GetAllArtists()
        {

            _cmd.Connection = _connection;
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.CommandText = getAll_SP;
            _da = new SqlDataAdapter(_cmd);
            var dataSet = new DataSet();
            _da.Fill(dataSet);
            var artists = new List<Artist>();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                artists.Add(new Artist()
                {
                    Id = Convert.ToInt32(row["ArtistId"]),
                    Name = row["Name"].ToString(),
                });

            }

            return artists;

        }

    }
}
