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
    public partial class ProfileEmpForm : MetroFramework.Forms.MetroForm
    {
        BDGestionDesCongesEntities2 db = new BDGestionDesCongesEntities2();
        public ProfileEmpForm()
        {
            InitializeComponent();
        }

        private void ProfileEmpForm_Load(object sender, EventArgs e)
        {
            // Chnager la couleur du text du menustrip
            this.menuStrip1.ForeColor = Color.White;

            // Chercher l'employé

            Employe employe = db.Employe.Where(c => c.NomUtilisateur.Equals(Session.NomUtilisateur)).FirstOrDefault();

            if (employe != null)
            {
                this.pictureBox1.ImageLocation = employe.Photo;
                this.metroLabel1.Text = employe.NomEmp + " " + employe.PrenomEmp;
                this.metroLabel7.Text = employe.DateNaissanceEmp.ToString("dd/MM/yyyy");
                this.metroLabel8.Text = employe.TelEmp;
                this.metroLabel9.Text = employe.Service.NomService;
                this.metroLabel10.Text = employe.NomUtilisateur;
                this.metroLabel11.Text = employe.Mdp;
            }
        }

        // Diriger vers la modification du compte
        private void metroButton1_Click(object sender, EventArgs e)
        {
            ParametreEmpForm paramEmpForm = new ParametreEmpForm();
            paramEmpForm.Show();
            this.Close();
        }

        private void mesDemandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeDemandesEmpForm listeDemandesEmpForm = new ListeDemandesEmpForm();
            listeDemandesEmpForm.Show();
            this.Close();
        }

        private void monCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParametreEmpForm paramEmpForm = new ParametreEmpForm();
            paramEmpForm.Show();
            this.Close();
        }

        private void monProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemanderCongeForm demanderCongeForm = new DemanderCongeForm();
            demanderCongeForm.Show();
            this.Close();
        }
    }
}
