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
        FlightsList flightsListInfo = new FlightsList();
        public FlightsListInfoForm()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
           
            try{
                FlightListGrid.ColumnCount = 6;
                FlightListGrid.Columns[0].HeaderText = "ID";
                FlightListGrid.Columns[1].HeaderText = "Compañía";
                FlightListGrid.Columns[2].HeaderText = "Origen";
                FlightListGrid.Columns[3].HeaderText = "Destino";
                FlightListGrid.Columns[4].HeaderText = "Posición";
                FlightListGrid.Columns[5].HeaderText = "Velocidad";
                FlightListGrid.RowCount = flightsListInfo.number;
                FlightListGrid.ColumnHeadersVisible = true;
                FlightListGrid.RowHeadersVisible = false;
                FlightListGrid.RowsDefaultCellStyle.BackColor = Color.Bisque;
                FlightListGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                FlightListGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
                FlightListGrid.DefaultCellStyle.SelectionBackColor = Color.Red;
                FlightListGrid.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                FlightListGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                FlightListGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                FlightListGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                FlightListGrid.AllowUserToResizeColumns = false;
                FlightListGrid.ReadOnly = true;
                FlightListGrid.DataSource = flightsListInfo.Flights;
            
                for (int i = 0; i < flightsListInfo.number; i++)
                {
                    FlightListGrid.Rows[i].Cells[0].Value = flightsListInfo.Flights[i].flightID;
                    FlightListGrid.Rows[i].Cells[1].Value = flightsListInfo.Flights[i].company;
                    FlightListGrid.Rows[i].Cells[2].Value = "(" + flightsListInfo.Flights[i].originX + "," + flightsListInfo.Flights[i].originY + ")";
                    FlightListGrid.Rows[i].Cells[3].Value = "(" + flightsListInfo.Flights[i].destinationX + "," + flightsListInfo.Flights[i].destinationY + ")";
                    FlightListGrid.Rows[i].Cells[4].Value = "(" + flightsListInfo.Flights[i].positionX + "," + flightsListInfo.Flights[i].positionY + ")";
                    FlightListGrid.Rows[i].Cells[5].Value = flightsListInfo.Flights[i].velocity;
                }
            }
            catch
            {
                 MessageBox.Show("El programa no puede mostrar la lista de vuelos porque no se ha cargado ninguna. " +
                                                        "Por favor cargue la lista", "No se ha cargado ninguna lista de vuelo.",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
        }
    
       
        private void FlightsListInfoForm_Load(object sender, EventArgs e)
        {

        }

        public void SetInfo(FlightsList flightsListObject)
        {
            this.flightsListInfo = flightsListObject;
        }

        public void LoadFlightsDataForm2(string route)
        {
            flightsListInfo.LoadFlightsFile(route);
        }
    }
}

