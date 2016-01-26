using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyMethodInjection
{
    public interface IService
    {
        void Serve();
    }

    public class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service Called");
        }
    }

    public class Client
    {
        private IService _service;
        public void Start(IService service)
        {
            this._service = service;
            Console.WriteLine("Service Started");
            this._service.Serve();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Start(new Service());

            Console.ReadKey();
        }
    }
}
