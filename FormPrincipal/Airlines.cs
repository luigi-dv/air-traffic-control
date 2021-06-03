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
    public partial class Airlines : Form
    {
        readonly DbCnx db = new DbCnx();
        public Airlines()
        {
            InitializeComponent();
        }

        private void Airlines_Load(object sender, EventArgs e)
        {
            FillDGV();
            
        }

        private void airlinesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(this.airlinesDGV.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                Airline airline = new Airline();
                airline.Rowid = Convert.ToInt32(this.airlinesDGV.CurrentRow.Cells[0].Value);
                airline.ID = this.airlinesDGV.CurrentRow.Cells[1].Value.ToString();
                airline.NameAirline = this.airlinesDGV.CurrentRow.Cells[2].Value.ToString();
                airline.Country = this.airlinesDGV.CurrentRow.Cells[3].Value.ToString();
                airline.Prefix = this.airlinesDGV.CurrentRow.Cells[4].Value.ToString();
                airline.Phone = this.airlinesDGV.CurrentRow.Cells[5].Value.ToString();
                airline.Email = this.airlinesDGV.CurrentRow.Cells[6].Value.ToString();
                airline.Direction = this.airlinesDGV.CurrentRow.Cells[7].Value.ToString();
                airline.Website = this.airlinesDGV.CurrentRow.Cells[8].Value.ToString();
                airline.ShowDialog();
                //Updating the DGV
                FillDGV();
            }
        }

        private void FillDGV()
        {
            db.Start();
            DataTable dt = db.GetAllAirlines();
            db.End();
            this.airlinesDGV.DataSource = dt;
            this.airlinesDGV.Columns[0].HeaderText = "ID";
            this.airlinesDGV.Columns[1].HeaderText = "Aerolínea ID";
            this.airlinesDGV.Columns[2].HeaderText = "Compañía";
            this.airlinesDGV.Columns[3].HeaderText = "País";
            this.airlinesDGV.Columns[4].HeaderText = "Prefijo";
            this.airlinesDGV.Columns[5].HeaderText = "Teléfono";
            this.airlinesDGV.Columns[6].HeaderText = "Email";
            this.airlinesDGV.Columns[7].HeaderText = "Dirección";
            this.airlinesDGV.Columns[8].HeaderText = "Página Web";
            this.airlinesDGV.ColumnHeadersVisible = true;
            this.airlinesDGV.RowHeadersVisible = false;
            this.airlinesDGV.RowTemplate.Height = 40;
            this.airlinesDGV.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.airlinesDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.airlinesDGV.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            this.airlinesDGV.DefaultCellStyle.SelectionBackColor = Color.Red;
            this.airlinesDGV.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.airlinesDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.airlinesDGV.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.airlinesDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.airlinesDGV.AllowUserToResizeColumns = false;
            this.airlinesDGV.ReadOnly = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AddAirline addAirline = new AddAirline();
            addAirline.ShowDialog();
            //Updating the DGV
            FillDGV();
        }
    }
}
