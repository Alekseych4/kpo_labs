using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310_nmv.Lib
{
    public class MockBusListCommand
    {
        public MockBusListCommand()
        {
            this._busesList = new List<Bus>();
        }
        private readonly string _dataFileName = "";
        private List<Bus> _busesList = null;
        public List<Bus> busesList
        {
            get => _busesList;
        }
        public void Execute()
        {
            {
                Bus bus = new Bus()
                {
                    Route = "12a",
                    RouteDistance = 123.0,
                    TravelTime = 123
                };
                busesList.Add(bus);
            }
            {
                Bus bus = new Bus()
                {
                    Route = "14",
                    RouteDistance = 123.0,
                    TravelTime = 123
                };
                busesList.Add(bus);
            }
        }
    }
}
