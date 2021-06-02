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
    public partial class Confirmation : Form
    {
        private User userToConfirm = new User();
        
        public User UserToConfirm
        {
            get { return userToConfirm; }
            set { userToConfirm = value; }
        }
        public Confirmation()
        {
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            this.emailConfirmationSend.Text = UserToConfirm.Email;
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            //Check if the inputValue match with the confirmation code in email
            try
            {
                int inputUserCode = Convert.ToInt32(this.confirmationCodeInput.Text);
                if (inputUserCode == userToConfirm.ConfirmationCode)
                {
                    //Code Ok, set value verified
                    userToConfirm.Verified = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El código de confirmación introducido es incorrecto. " +
                                    "Por favor inserte el código correctamente o haga click en el enlace de abajo para volver a enviar su código. Si todo lo anterior no funciona acceda como invitado.",
                                     "Código de confirmación incorrecto",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ha introducido un formato no válido en la casilla del código de confirmación.",
                                    "Formato del código incorrecto",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
