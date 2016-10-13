using MusicStore.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using MusicStore.Entities;

namespace MusicStore.DataAccess
{
    public class GenreDAL : DABase
    {

        private SqlCommand _cmd;
        private string getAll_SP = "USP_GET_GENRE";
        private SqlDataAdapter _da;

        public GenreDAL()
        {
            _cmd = new SqlCommand();
        }
        

        public List<Genre> GetAllArtists()
        {

            _cmd.Connection = _connection;
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.CommandText = getAll_SP;
            _da = new SqlDataAdapter(_cmd);
            var dataSet = new DataSet();
            _da.Fill(dataSet);
            var genreList = new List<Genre>();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                genreList.Add(new Genre()
                {
                    GenreId = Convert.ToInt32(row["GenreId"]),
                    Name = row["Name"].ToString(),
                });

            }

            return genreList;

        }

    }
}
