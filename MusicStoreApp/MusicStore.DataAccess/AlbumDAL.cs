using MusicStore.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DataAccess
{
    public class AlbumDAL : DABase
    {
        private SqlCommand _cmd;
        private string insert_SP = "USP_INSERT_ALBUM";
        private string getAll_SP = "USP_GET_ALBUMS";
        private SqlDataAdapter _da;
        public AlbumDAL()
        {
            _cmd = new SqlCommand();
        }

        public int CreateAlbum(Album album)
        {
            _cmd.Connection = _connection;
            _cmd.CommandType = System.Data.CommandType.StoredProcedure;
            _cmd.CommandText = insert_SP;
            _cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@GENREID",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = album.GenreId
            });
            _cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@ARTISTID",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = album.ArtistId
            });
            _cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@PRICE",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = album.Price
            });
            _cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@TITLE",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = album.Title
            });
            _cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@ALBUMARTURL",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = album.AlbumArtUrl
            });

            _cmd.Connection.Open();
            var result=_cmd.ExecuteNonQuery();
            _cmd.Connection.Close();
            return result;
        }

        public List<Album> GetAllAlbums()
        {

            _cmd.Connection = _connection;
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.CommandText = getAll_SP;
            _da = new SqlDataAdapter(_cmd);
            var dataSet = new DataSet();
            _da.Fill(dataSet);
            var albums = new List<Album>();
            foreach(DataRow row in dataSet.Tables[0].Rows)
            {
                albums.Add(new Album()
                {
                    Price = Convert.ToInt32(row["Price"]),
                    AlbumArtUrl = row["AlbumArtUrl"].ToString(),
                    Title = row["Title"].ToString()
                });

            }

            return albums;

        }
    }
}
