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
    public partial class FrmMain : Form
    {
        private List<Bus> busesList = null;
        private BindingSource bsBuses = new BindingSource();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            try {
                var mock = new MockBusListCommand();
                mock.Execute();
                busesList = mock.busesList;
                Console.WriteLine(busesList);
                bsBuses.DataSource = busesList;
                dgvBuses.DataSource = bsBuses; 
                    }
            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
                LogUtility.ErrorLog(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка №2: " + ex.Message);
            }
        }

        private void mmBuses_Click(object sender, EventArgs e)
        {

        }

        private void mnOpenBuses_Click(object sender, EventArgs e)
        {
            try
            {
                var frmBuses = new FrmBuses();

                Bus bus = (bsBuses.Current as Bus);
                frmBuses.Bus = bus;

                frmBuses.ShowDialog();
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show("Ошибка №1: " + ex.Message);
                LogUtility.ErrorLog(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка №2: " + ex.Message);
            }
        }
    }
}
