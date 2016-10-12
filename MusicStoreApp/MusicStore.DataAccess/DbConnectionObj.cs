using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DataAccess
{
    public class DbConnectionObj
    {
        public static string GetConnectionString() {
            return ConfigurationManager.ConnectionStrings["MusicStoreDB"].ConnectionString;
        } 
    }
}
