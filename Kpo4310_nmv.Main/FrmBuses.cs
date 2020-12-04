using Kpo4310_nmv.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kpo4310_nmv.Main
{
    public partial class FrmBuses : Form
    {
        public FrmBuses()
        {
            InitializeComponent();
            _bus = null;
        }

        private Bus _bus = null;
        public Bus Bus
        {
            get => _bus;
            set
            {
                _bus = value;
                this.txtBoxBuses.Text = $"Маршрут: {Bus.Route} Длина маршрута: {Bus.RouteDistance} Время в пути: {Bus.TravelTime}";
            }
        }
    }
}
