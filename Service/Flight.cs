using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    [DataContract]
    public class Flight
    {
        [DataMember]
        public int FlightNumber { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string LocationF { get; set; }
        [DataMember]
        public string LocationT { get; set; }
        [DataMember]
        public DateTime DepDate { get; set; }
        [DataMember]
        public DateTime ArrivalD { get; set; }

        public Flight(int fn, string t, string lf, string lt, DateTime dd , DateTime ad)
        {
            FlightNumber = fn;
            Type = t;
            LocationF = lf;
            LocationT = lt;
            DepDate = dd;
            ArrivalD = ad;




        }
    }
}
