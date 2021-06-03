using FlightsLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormPrincipal
{
    public partial class UserFlights : Form
    {
        private Auth authUser = new Auth();
        public Auth AuthUser
        {
            get { return authUser; }
            set { authUser = value; }

        }
        public UserFlights()
        {
            InitializeComponent();
        }

        private void UserFlights_Load(object sender, EventArgs e)
        {   DataTable dt = new DataTable();
            dt = authUser.ShowUserFlightData(authUser.GetID());
            this.userFlightsInfoDGV.DataSource = dt;
            this.userFlightsInfoDGV.Columns[0].HeaderText = "ID";
            this.userFlightsInfoDGV.Columns[1].HeaderText = "Compañía";
            this.userFlightsInfoDGV.Columns[2].HeaderText = "Posición X";
            this.userFlightsInfoDGV.Columns[3].HeaderText = "Posición Y";
            this.userFlightsInfoDGV.Columns[4].HeaderText = "Origen X";
            this.userFlightsInfoDGV.Columns[5].HeaderText = "Origen Y";
            this.userFlightsInfoDGV.Columns[6].HeaderText = "Destinación X";
            this.userFlightsInfoDGV.Columns[7].HeaderText = "Destinación Y";
            this.userFlightsInfoDGV.Columns[8].HeaderText = "Velocidad";
            this.userFlightsInfoDGV.ColumnHeadersVisible = true;
            this.userFlightsInfoDGV.RowHeadersVisible = false;
            this.userFlightsInfoDGV.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.userFlightsInfoDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.userFlightsInfoDGV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            this.userFlightsInfoDGV.DefaultCellStyle.SelectionBackColor = Color.Red;
            this.userFlightsInfoDGV.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.userFlightsInfoDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.userFlightsInfoDGV.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.userFlightsInfoDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.userFlightsInfoDGV.AllowUserToResizeColumns = false;
            this.userFlightsInfoDGV.ReadOnly = true;
        }
    }
}
