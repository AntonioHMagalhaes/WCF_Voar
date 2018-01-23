using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients.ServiceReference1;

namespace Clients
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            Console.ReadKey();
        }
        public void Run()
        {
            ServiceReference1.IService1 servicez = new ServiceReference1.Service1Client();

            List<ServiceReference1.Flight> listacenas = servicez.GetFlights();
            for(int i=0; i<=5; i++)
            {
                foreach (Flight flight in listacenas)
                {
                    FlightInfo(flight);

                }

                Flight f = servicez.GetByFn(1);
                FlightInfo(f);


                int id = Int32.Parse(Console.ReadLine());
                string type = Console.ReadLine();
                string locationfr = Console.ReadLine();
                string locationto =Console.ReadLine();
                DateTime departure= DateTime.Parse(Console.ReadLine());
                DateTime arrival= DateTime.Parse(Console.ReadLine());
                servicez.UpdateFlight(id, type, locationfr, locationto, departure, arrival);

                f = servicez.GetByFn(id);
                FlightInfo(f);
            }
        }

        public void FlightInfo(Flight flight)
        {
            Console.WriteLine(flight.FlightNumber);
            Console.WriteLine(flight.Type);
            Console.WriteLine(flight.LocationF);
            Console.WriteLine(flight.LocationT);
            Console.WriteLine(flight.DepDate);
            Console.WriteLine(flight.ArrivalD);
            Console.WriteLine(); 
        }
    }
}
