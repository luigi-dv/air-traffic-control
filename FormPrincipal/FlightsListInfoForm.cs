using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightsLib;

namespace FormPrincipal
{
    public partial class FlightsListInfoForm : Form
    {
        FlightsList flights = new FlightsList();
        string filename;
        public FlightsListInfoForm()
        {
            InitializeComponent();
        }
      
        private void Form_Load(object sender, EventArgs e)
        {
            FlightListGrid.ColumnCount = 6;
            FlightListGrid.Columns[0].HeaderText = "ID";
            FlightListGrid.Columns[1].HeaderText = "Compañía";
            FlightListGrid.Columns[2].HeaderText = "Origen";
            FlightListGrid.Columns[3].HeaderText = "Destino";
            FlightListGrid.Columns[4].HeaderText = "Posición";
            FlightListGrid.Columns[5].HeaderText = "Velocidad";
            FlightListGrid.RowCount = 10;
            FlightListGrid.ColumnHeadersVisible = true;
            FlightListGrid.RowHeadersVisible = false;
            FlightListGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            FlightListGrid.DataSource = flights;
            for(int i = 0; i<flights.number; i++)
            {
                for(int j = 0; j<6; j++)
                {

                }
            }
        }
        public void LoadFlightsDataForm2(string route)
        {
            flights.LoadFlightsFile(route);
            
            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FlightsListInfoForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FlightsListInfoForm";
            this.Load += new System.EventHandler(this.FlightsListInfoForm_Load);
            this.ResumeLayout(false);

        }

        private void FlightsListInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
