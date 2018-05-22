using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ThirdWcfService.MyService service = new ThirdWcfService.MyService();
            service.initUsers();
            ServiceHost host = new ServiceHost(service);
            host.Open();
            Console.Read();
        }
    }
}
