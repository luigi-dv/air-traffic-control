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
    public partial class AddAirline : Form
    {
        DbCnx db = new DbCnx();
        public AddAirline()
        {
            InitializeComponent();
        }

        private void emptyBtn_Click(object sender, EventArgs e)
        {
            this.IDInput.Text = null;
            this.nameInput.Text = null;
            this.countryInput.Text = null;
            this.prefixInput.Text = null;
            this.phoneInput.Text = null;
            this.emailInput.Text = null;
            this.directionInput.Text = null;
            this.websiteInput.Text = null;
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

                if (id != "" && name != "" && country != "" && prefixPhone != "" && phone != "" && email != "" && direction != "" && website != "")
                {
                    db.Start();
                    int result = db.GetAirlaneByID(id);
                    if (result != 0)
                    {
                        MessageBox.Show("La Aerolínea no se ha podido añadir correctamente debido a que existe otra con el mismo ID.",
                                             "Error Añadiendo",
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (MessageBox.Show("Está a punto de añadir una Aerolínea.¿Está seguro de que desea realizar esta acción?", "Añadiendo Aerolínea", MessageBoxButtons.YesNo) ==
                      DialogResult.Yes)
                        {
                            db.InsertAirline(id, name, country, prefixPhone, phone, email, direction, website);
                            MessageBox.Show("Se ha añadido la aerolínea satisfactoriamente.",
                                              "Aerolínea Añadida",
                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
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
            catch(FormatException)
            {
                MessageBox.Show("Error en el formato de los datos introducidos.",
                                     "Error Guardando",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddAirline_Load(object sender, EventArgs e)
        {

        }
    }
}
