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
    public partial class Airline : Form
    {
        DbCnx db = new DbCnx();
        private int rowid;
        public Airline()
        {
            InitializeComponent();
        }

        private void Airline_Load(object sender, EventArgs e)
        {
           
        }
        public int Rowid
        {
            get { return rowid; }
            set { rowid = value; }
        }
        public string ID
        {
            get { return this.IDInput.Text; }
            set { this.IDInput.Text = value; }
        }
        public string NameAirline
        {
            get { return this.nameInput.Text; }
            set { this.nameInput.Text = value; }
        }
        public string Country
        {
            get { return this.countryInput.Text; }
            set { this.countryInput.Text = value; }
        }
        public string Prefix
        {
            get { return this.prefixInput.Text; }
            set { this.prefixInput.Text = value; }
        }
        public string Phone
        {
            get { return this.phoneInput.Text; }
            set { this.phoneInput.Text = value; }
        }
        public string Email
        {
            get { return this.emailInput.Text; }
            set { this.emailInput.Text = value; }
        }
        public string Direction
        {
            get { return this.directionInput.Text; }
            set { this.directionInput.Text = value; }
        }
        public string Website
        {
            get { return this.websiteInput.Text; }
            set { this.websiteInput.Text = value; }
        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            db.Start();
            int airlineValue = db.GetAirlane(this.rowid);
            if (airlineValue == 0)
            {
                //There is not any airline matching the id consider save 
                MessageBox.Show("La aerolínea que desea eliminar no existe y por tanto no se puede eliminar. Considere guardar la aerolínea actual.",
                                      "No se pudo eliminar la aerolínea",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Está a punto de eliminar la Aerolínea.¿Está seguro de que desea realizar esta acción?", "Eliminando Aerolínea", MessageBoxButtons.YesNo) ==
               DialogResult.Yes)
                {
                    db.DeleteAirline(this.rowid);
                    this.Close();
                }
            }

            db.End();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.IDInput.Text;
                string name = this.nameInput.Text;
                string country = this.countryInput.Text;
                string prefixPhone = this.prefixInput.Text;
                string phone = this.phoneInput.Text;
                string email = this.emailInput.Text;
                string direction = this.directionInput.Text;
                string website = this.websiteInput.Text;

                if(id != "" && name != "" && country != "" && prefixPhone != "" && phone != "" && email != "" && direction != "" && website != "")
                {
                    db.Start();
                    int airlineValue = db.GetAirlane(this.rowid);
                    if (airlineValue != 0)
                    {
                        //UPDATE
                        db.UpdateAirline(this.rowid, id, name, country, prefixPhone, phone, email, direction, website);
                        MessageBox.Show("Se ha actualizado la Aerolínea satisfactoriamente.",
                                              "Aerolínea Guardada",
                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La Aerolínea no se ha podido guardar correctamente.",
                                             "Error Guardando",
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    db.End();
                }
                else
                {
                    MessageBox.Show("Por favor rellene todos los campos para poder guardar la aerolinea.",
                                    "Campos Vacios",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error en el formato de los datos introducidos.",
                                     "Error Guardando",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
