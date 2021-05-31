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

namespace GestionConge
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        BDGestionDesCongesEntities2 db = new BDGestionDesCongesEntities2();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            // Checker si le chef de service est dèjà inscrit
            Chef chef = db.Chef.FirstOrDefault(c => c.CIN == this.metroTextBox1.Text && c.Mdp == this.metroTextBox2.Text);

            if (chef != null)
            {
                // Enregistrer la session
                Session.NomUtilisateur = chef.NomUtilisateur;
                Session.MotDePasse = chef.Mdp;

                // Redirecter le chef vers la page principale
                AccueilFrom accForm = new AccueilFrom();
                accForm.Show();
                this.Close();
            }
            else
            {
                this.metroLabel3.Text = "Nom d'utilisateur ou le mot de passe est incorrecte!";
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Close();
        }

        // show or hide the panel
        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroCheckBox1.Checked)
            {
                this.metroPanel1.Visible = true;
            }
            else
            {
                this.metroPanel1.Visible = false;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (this.metroTextBox1.Text != "")
            {
                var randomPassword = new Random();
                var mail = new MailMessage();
                var loginInfo = new NetworkCredential(this.metroTextBox3.Text, this.metroTextBox4.Text);
                mail.From = new MailAddress(this.metroTextBox3.Text);
                mail.To.Add(new MailAddress(this.metroTextBox3.Text));
                mail.Subject = "Réinitialiser le mot de passe du chef de service";
                var code = randomPassword.Next(121, 9999);
                mail.Body = "Votre nouveau mot de passe est : " + code;
                var chef = this.db.Chef.FirstOrDefault(c => c.CIN == this.metroTextBox1.Text);
                chef.Mdp = code.ToString();
                this.db.SaveChanges();

                var smtpClient = new SmtpClient("smtp.gmail.com", 587); // https://myaccount.google.com/lesssecureapps
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = loginInfo;
                smtpClient.Send(mail);
            }
            else
            {
                MessageBox.Show("veuillez saisir votre CIN");
            }
        }
    }
}
