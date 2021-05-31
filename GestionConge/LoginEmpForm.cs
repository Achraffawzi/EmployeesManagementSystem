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
    public partial class LoginEmpForm : MetroFramework.Forms.MetroForm
    {
        BDGestionDesCongesEntities2 db = new BDGestionDesCongesEntities2();
        public LoginEmpForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // Checker si l'employé est dèjà inscrit
            Employe emp = db.Employe.Where(em => em.NomUtilisateur.Equals(this.metroTextBox1.Text) && em.Mdp.Equals(this.metroTextBox2.Text)).FirstOrDefault();

            if (emp != null)
            {
                // Enregistrer la session
                Session.NomUtilisateur = emp.NomUtilisateur;
                Session.MotDePasse = emp.Mdp;

                // Redirecter l'employé vers la page principale
                AccueilEmpFrom accEmpForm = new AccueilEmpFrom();
                accEmpForm.Show();
                this.Close();
            }
            else
            {
                this.metroLabel3.Text = "Authentification a échouée";
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            RegisterEmployeForm regEmpForm = new RegisterEmployeForm();
            regEmpForm.Show();
            this.Close();
        }
    }
}
