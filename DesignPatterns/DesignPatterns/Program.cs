using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new Service());
            client.Start();
            Console.ReadKey();
        }

        
    }
    public interface IService
    {
        void Serve();
    }

    public class ExcellentService : IService
    {
        public void Serve()
        {
            Console.WriteLine("I am the premium Service");
        }
    }

    public class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("I am an average service");
        }
    }

    public class Client
    {
        private IService _service;
        public Client (IService service)
        {
            _service = service;
        }

        public void Start()
        {
            Console.WriteLine("Service started");
            this._service.Serve();
        }
    }
}
