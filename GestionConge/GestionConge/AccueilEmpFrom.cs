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
    public partial class AccueilEmpFrom : MetroFramework.Forms.MetroForm
    {
        public AccueilEmpFrom()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ParametreEmpForm paramEmpForm = new ParametreEmpForm();
            paramEmpForm.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DemanderCongeForm demanderCongeForm = new DemanderCongeForm();
            demanderCongeForm.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            ListeDemandesEmpForm listeDemandesEmpForm = new ListeDemandesEmpForm();
            listeDemandesEmpForm.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            // Vider la Session
            Session.NomUtilisateur = null;
            Session.MotDePasse = null;

            // Rediriger l'employé vers la page de login
            LoginEmpForm loginEmpForm = new LoginEmpForm();
            loginEmpForm.Show();
            this.Close();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ProfileEmpForm profileEmpForm = new ProfileEmpForm();
            profileEmpForm.Show();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
