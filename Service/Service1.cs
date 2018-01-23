using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public Service1()
        {
             dictionary = new Dictionary<int, Flight>();
            dictionary.Add(1, new Flight(1,"Boing","Paris","Rome",new DateTime(2017,01,14),new DateTime(2017, 01, 15)));
            dictionary.Add(2, new Flight(2, "cenas", "Paris", "caralho", new DateTime(2017, 01, 14), new DateTime(2017, 01, 15)));

        }

        private Dictionary<int, Flight> dictionary;
    

        public List<Flight> GetFlights()
        {
            return dictionary.Values.ToList();
        }

        public Flight GetByFn(int flightnumber)
        {
            if (dictionary.ContainsKey(flightnumber))
            {
                return dictionary[flightnumber];   

            }
            else
            {
                return null;
            }
        }

        public void UpdateFlight(int fn, string t, string lf, string lt, DateTime dd, DateTime ad)
        {
            dictionary[fn].Type=t;
            dictionary[fn].LocationF=lf;
            dictionary[fn].LocationT = lt;
            dictionary[fn].DepDate=dd;
            dictionary[fn].ArrivalD = ad;
        }


    }
}
