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
    public partial class Login : Form
    {
        private readonly Auth userAuthenticated = new Auth();
       
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPsw.Checked)
            {
                pswLoginInput.UseSystemPasswordChar = false;
            }
            else
            {
                pswLoginInput.UseSystemPasswordChar = true;
            }
        }

        private void guestLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MainForm program = new MainForm();
            program.Show();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
            
        }

        private void helpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                //Call to 0.4.Helper
                VisitLink("https://github.com/LuigeloDV/ProjectG6/blob/master/README.md");
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido abrir el repositorio remoto.");
            }
        }

        
        //0.2.Helper: Function to visit a custom link
        private void VisitLink(string url)
        {
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start(url);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userNameEmail = userNameLoginInput.Text;
            string psw = pswLoginInput.Text;
            //Do the Login
            int check = userAuthenticated.CheckLogin(userNameEmail, psw);
            //Check if the info is correct
            if(check == 0)
            {
                
                //Getting the user
                if (this.rememberMe.Checked == true)
                {
                    Properties.Settings.Default.Username = userNameEmail;
                    Properties.Settings.Default.Password = psw;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Username = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                }
                //Showing Main Form 
                MainForm main = new MainForm();
                //User authenticated pass to MainForm
                main.UserAuthenticated = userAuthenticated;
                this.Hide();
                main.Show();
            }
            else
            {
                if(check== 1)
                    MessageBox.Show("El nombre de usuario que ha introducido es incorrecto o no existe. Por favor intentelo de nuevo o cree una cuenta.",
                                        "El nombre de usuario no existe",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if(check==2)
                        MessageBox.Show("La contraseña que ha introducido es incorrecta. Por favor introduzca la contraseña correctamente o restablezcala.",
                                         "Contraseña incorrecta",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       

    }
}
