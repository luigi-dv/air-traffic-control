﻿using System;
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
        private const string EMAIL = "testing@ldvloper.com";
        private const string SERVER = "smtp.ionos.es";
        private const int PORT = 587;

        User newUser = new User();
        Email email = new Email();

        private Auth userAuthenticated = new Auth();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.errorAlertLabel.Visible = false;
            this.errorAlertPanel.Visible = false;
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
            try
            {
                // Check in db if username or email are already taken 
                string email = this.emailRegisterInput.Text;
                string username = this.userNameRegisterInput.Text;
                string psw = this.pswRegisterInput.Text;
                string cPsw = this.pswConfirmRegisterInput.Text;
                if (email != "" && username != "" && psw != "" && cPsw != "")
                {
                    int res = userAuthenticated.checkIfExist(username, email);
                    if (res == 1)
                    {
                        MessageBox.Show("El email introducido se encuentra actualmente vinculado a otra cuenta. Introduzca un email diferente o ingrese a su cuenta.",
                                                "El email está en uso",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (res == 2)
                        {
                            MessageBox.Show("El nombre de usuario introducido se encuentra actualmente en uso. Introduzca un nombre de usuario diferente o ingrese a su cuenta.",
                                               "El nombre de usuario está en uso",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //This adds the data into a new User class 
                        newUser.Email = email;
                        newUser.Username = username;
                        newUser.Password = psw;
                        newUser.Token = newUser.SetToken();

                        //Checking if the password and confirmation match 
                        if (newUser.Password == cPsw)
                        {
                            //Generates a confirmation code to send via email
                            newUser.ConfirmationCode = GenerateConfirmationCode();

                            //Email values to send the email using - 0.3.Helper: Send email via c#
                            MailAddress from = new MailAddress(EMAIL, "Project G6");
                            MailAddress to = new MailAddress(newUser.Email, newUser.Username);
                            SendEmail("Confirme su Registro", from, to);
                            //Open Form Confirmation
                            this.Text = "Confirme su registro";
                            Confirmation confirmationForm = new Confirmation();
                            //Send the confirmation code to the confirmationForm;
                            confirmationForm.UserToConfirm = newUser;
                            confirmationForm.ShowDialog();
                            //Dialog is closed the user value is imported and 
                            newUser.Verified = confirmationForm.UserToConfirm.Verified;
                            //Hacemos un check de el usuario 
                            if (newUser.Verified == true)
                            {
                                //Adding the user to de database
                                newUser.SetUser(newUser);
                                this.Close();
                                MainForm mainForm = new MainForm();
                                //New user as an user authenticated
                                mainForm.UserAuthenticated = userAuthenticated.SetNewUserAuth(newUser);
                                //Set Authenticated true 
                                mainForm.UserAuthenticated.Authenticated = true;
                                mainForm.Show();

                            }
                            else
                            {
                                this.errorAlertLabel.Visible = true;
                                this.errorAlertPanel.Visible = true;
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
                else
                {
                    MessageBox.Show("Por favor rellene todos los campos para poder crear su cuenta.",
                                              "Campos necesarios vacios",
                                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor introduzca un formato valido en los campos",
                                             "Formato de campos invalido",
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            

        }

        private void helpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                //Call to 0.4.Helper
                VisitLink("https://github.com/LuigeloDV/ProjectG6#readme");
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido abrir el cuadro de ayuda.");
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
            
            SmtpClient mailClient = new SmtpClient(SERVER, PORT);
            //La Constraseña se encuentra segura en la tabla emailClients
            email = email.GetEmailAuth(EMAIL);
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
            try
            {
                mailClient.Send(msgMail);
            }
            catch
            {
                MessageBox.Show("No ha sido posible enviar el email de confirmación. Por favor intentelo de nuevo o continue como invitado si sigue experimentando el mismo problema.",
                                     "Error al enviar el código de confirmación",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            msgMail.Dispose();
        }
    }
}
