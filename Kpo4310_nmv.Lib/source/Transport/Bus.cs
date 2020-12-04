using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nmv.Lib
{
    public class Bus
    {
        private string _route;
        private double _routeDistance;
        private long _travelTime;

        public string Route
        {
            get => _route;
            set => _route = value;
        }

        public double RouteDistance 
        {
            get => _routeDistance;
            set => _routeDistance = value;
        }

        public long TravelTime 
        {
            get => _travelTime;
            set => _travelTime = value;
        }
        public Bus() 
        {
            Route = "12a";
            RouteDistance = 57.3;
            TravelTime = 117;
        }
    }
}
