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
    public partial class AccueilFrom : MetroFramework.Forms.MetroForm
    {
        BDGestionDesCongesEntities2 db = new BDGestionDesCongesEntities2();
        public AccueilFrom()
        {
            InitializeComponent();
        }

        // Récupérer le nombre de demandes actuel
        public int GetNumberOfDemandes()
        {
            // Récupérer l'id du service affecté par le chef de service
            int idService = db.Chef.Where(c => c.NomUtilisateur.Equals(Session.NomUtilisateur)).FirstOrDefault().IDService;

            return (from c in db.Conge
                    join emp in db.Employe on c.IDEmp equals emp.CIN
                    join s in db.Service on emp.IDService equals s.IDService
                    where s.IDService == idService && c.Etat.Equals("En Attente")
                    select c).ToList().Count;
        }
        private void AccueilFrom_Load(object sender, EventArgs e)
        {
            int totalDemandes = GetNumberOfDemandes();
            this.metroLabel2.Text = totalDemandes.ToString();
            //MessageBox.Show("total = " + totalDemandes);
        }

        // Redirecter le chef vers la page de paramètre
        private void metroTile2_Click(object sender, EventArgs e)
        {
            ParametreForm paramForm = new ParametreForm();
            paramForm.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ListeDemandesForm listeDemandesForm = new ListeDemandesForm();
            listeDemandesForm.Show();
            this.Close();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ProfileForm proForm = new ProfileForm();
            proForm.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            GestionEmployesForm gestionEmpForm = new GestionEmployesForm();
            gestionEmpForm.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            // Vider la Session
            Session.NomUtilisateur = null;
            Session.MotDePasse = null;

            // Rediriger l'employé vers la page de login
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }
    }
}
