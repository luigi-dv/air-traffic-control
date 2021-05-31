using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightsLib;

namespace FormPrincipal
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPsw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPsw.Checked)
            {
                pswRegisterInput.UseSystemPasswordChar = false;
            }
            else
            {
                pswRegisterInput.UseSystemPasswordChar = true;
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
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

           // Check in db if username or email are already taken 
            User newUser = new User();

            newUser.Email = this.emailRegisterInput.Text;
            newUser.Username = this.userNameRegisterInput.Text;
            newUser.Password = this.pswRegisterInput.Text;
            string cPsw = this.pswConfirmRegisterInput.Text;
            if(newUser.Password == cPsw)
            {
                //Generates a confirmation code to send via email
                newUser.ConfirmationCode = GenerateConfirmationCode();

                //Email values 
                MailAddress from = new MailAddress("Someone@domain.topleveldomain", "Name and stuff");
                MailAddress to = new MailAddress(newUser.Email, "About your registration " + newUser.Email);
                SendEmail("Want to test this damn thing", from, to);
            }
            else
            {
                //Show password message
            }

            //Username or email already exist
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

        //0.1.Helper: Function to visit a custom link
        private void VisitLink(string url)
        {
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start(url);
        }
        //0.2.Helper: Code Confirmation for send in email
        private int GenerateConfirmationCode()
        {
           
            Random rnd = new Random();
            int code = rnd.Next(9999);
            return code;
        }
        //0.3.Helper: Send email via c#
        protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _bcc = null)
        {
            string Text = "";
            SmtpClient mailClient = new SmtpClient("Mailhost");
            MailMessage msgMail;
            Text = "Stuff";
            msgMail = new MailMessage();
            msgMail.From = _from;
            msgMail.To.Add(_to);
           
            if (_bcc != null)
            {
                foreach (MailAddress addr in _bcc)
                {
                    msgMail.Bcc.Add(addr);
                }
            }

            //Email send
            msgMail.Subject = _subject;
            msgMail.Body = Text;
            msgMail.IsBodyHtml = true;
            mailClient.Send(msgMail);
            msgMail.Dispose();
        }
    }
}
