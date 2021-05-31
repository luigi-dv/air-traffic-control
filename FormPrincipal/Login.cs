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
    public partial class Login : Form
    {
        //Auth variables
        private bool logged = true;
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
            MainForm program = new MainForm();
            program.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
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
    }
}
