using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightsLib;

namespace FormPrincipal
{
    public partial class Register : Form
    {
        User newUser = new User();
        Email email = new Email();

        private readonly Auth userAuthenticated = new Auth();
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
            string email = this.emailRegisterInput.Text;
            string username = this.userNameRegisterInput.Text;
            int res = userAuthenticated.checkIfExist(username, email);
            if (res == 1)
            {
                MessageBox.Show("El email introducido se encuentra actualmente vinculado a otra cuenta. Introduzca un email diferente o ingrese a su cuenta.",
                                        "El email está en uso",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(res == 2)
                {
                    MessageBox.Show("El nombre de usuario introducido se encuentra actualmente en uso. Introduzca un nombre de usuario diferente o ingrese a su cuenta.",
                                       "El nombre de usuario está en uso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //This adds the data into a new User class 
                newUser.Email = email;
                newUser.Username = username;
                newUser.Password = this.pswRegisterInput.Text;
                newUser.Token = newUser.SetToken();
                string cPsw = this.pswConfirmRegisterInput.Text;
                //Checking if the password and confirmation match 
                if (newUser.Password == cPsw)
                {
                    //Generates a confirmation code to send via email
                    newUser.ConfirmationCode = GenerateConfirmationCode();
                    try
                    {
                        //Email values to send the email using - 0.3.Helper: Send email via c#
                        MailAddress from = new MailAddress("testing@ldvloper.com", "Project G6");
                        MailAddress to = new MailAddress(newUser.Email, newUser.Username);
                        SendEmail("Confirme su Registro", from, to);
                        //Open Form Confirmation
                        Confirmation confirmationForm = new Confirmation();
                        //Send the confirmation code to the confirmationForm;
                        confirmationForm.UserToConfirm = newUser;
                        confirmationForm.ShowDialog();
                        //Dialog is closed the user value is imported and 
                        newUser.Verified = confirmationForm.UserToConfirm.Verified;
                        //Añadimos el usuario
                        newUser.SetUser(newUser);

                    }
                    catch
                    {
                        MessageBox.Show("No ha sido posible enviar el email de confirmación. Por favor intentelo de nuevo o continue como invitado si sigue experimentando el mismo problema.",
                                      "Error al enviar el código de confirmación",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }   

                   
                }
                else
                {
                    MessageBox.Show("Las contraseña no coincide. Introduzca la constraseña correctamente en ambas entradas.",
                                      "Las contraseñas no coinciden",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

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
            
            SmtpClient mailClient = new SmtpClient("smtp.ionos.es", 587);
            //La Constaseña se encuentra segura en la tabla emailClients
            email = email.GetEmailAuth("testing@ldvloper.com");
            NetworkCredential cred = new NetworkCredential(email.Username, email.Password);
            MailMessage msgMail;
            
            msgMail = new MailMessage();
            Text = email.GenerateTemplate(newUser);
            msgMail.IsBodyHtml = true;
            msgMail.From = _from;
            msgMail.To.Add(_to);
           
          
            mailClient.Credentials = cred;
            //Email send
            msgMail.Subject = _subject;
            msgMail.Body = Text;
            msgMail.IsBodyHtml = true;
            
            mailClient.Send(msgMail);
            msgMail.Dispose();
        }
    }
}
