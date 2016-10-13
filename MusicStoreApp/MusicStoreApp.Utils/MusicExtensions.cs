using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreApp.Utils
{
    public static class MusicExtensions
    {
        public static string GetLastFour(this string str)
        {
            var length = str.Length;
            return length > 4 ? str.Substring(length - 4, 4) : str;
        }
    }
}
