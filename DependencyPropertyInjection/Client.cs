using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyPropertyInjection
{
    public class Client
    {
        private IService _service;

        public IService Service
        {
            set { this._service = value; }
        }

        public void Start()
        {
            Console.WriteLine("Service Started");
            this._service.Serve();
        }
    }
}
