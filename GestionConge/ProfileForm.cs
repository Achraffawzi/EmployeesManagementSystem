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
    public partial class ProfileForm : MetroFramework.Forms.MetroForm
    {
        BDGestionDesCongesEntities2 db = new BDGestionDesCongesEntities2();
        public ProfileForm()
        {
            InitializeComponent();
        }

        // Charger le frmulaire avec les données du chef
        private void ProfileForm_Load(object sender, EventArgs e)
        {
            // Changer la couleur du menustrip
            this.menuStrip1.ForeColor = Color.White;
            // Chercher le chef
            Chef chef = db.Chef.Where(c => c.NomUtilisateur.Equals(Session.NomUtilisateur)).FirstOrDefault();

            if(chef != null)
            {
                if (!chef.Photo.Contains("~/Resources/defaultPicture.jpg")) this.pictureBox1.ImageLocation = chef.Photo;
                else this.pictureBox1.Image = Properties.Resources.defaultPicture;
                this.metroLabel14.Text = chef.CIN;
                this.metroLabel1.Text = chef.NomChef + " " + chef.PrenomChef;
                this.metroLabel7.Text = chef.DateNaissanceChef.ToString("dd/MM/yyyy");
                this.metroLabel8.Text = chef.Tel;
                this.metroLabel9.Text = chef.Service.NomService;
                this.metroLabel10.Text = chef.NomUtilisateur;
                this.metroLabel11.Text = chef.Mdp;
            }
        }

        // Diriger vers la modification du compte
        private void metroButton1_Click(object sender, EventArgs e)
        {
            ParametreForm paramForm = new ParametreForm();
            paramForm.Show();
            this.Close();
        }

        private void monProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionEmployesForm gestionEmployesForm = new GestionEmployesForm();
            gestionEmployesForm.Show();
            this.Close();
        }

        private void listeDesDemandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeDemandesForm listeDemandesForm = new ListeDemandesForm();
            listeDemandesForm.Show();
            this.Close();
        }

        private void monCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParametreForm parametreForm = new ParametreForm();
            parametreForm.Show();
            this.Close();
        }
    }
}
