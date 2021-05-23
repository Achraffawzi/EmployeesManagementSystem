using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            Chef chef = db.Chef.FirstOrDefault(c => c.NomUtilisateur == this.metroTextBox1.Text && c.Mdp == this.metroTextBox2.Text);

            if(chef != null)
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
    }
}
