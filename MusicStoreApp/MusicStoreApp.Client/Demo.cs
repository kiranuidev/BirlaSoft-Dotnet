using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreApp.Client
{
    public class Demo<T>
    {
        T _value;
        public Demo(T t)
        {
            this._value = t;
        }

        public void LogToConsole()
        {
            Console.WriteLine(this._value);
        }
    }
}
