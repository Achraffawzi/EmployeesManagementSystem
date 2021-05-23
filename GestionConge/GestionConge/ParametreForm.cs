using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GestionConge
{
    public partial class ParametreForm : MetroFramework.Forms.MetroForm
    {
        BDGestionDesCongesEntities2 db = new BDGestionDesCongesEntities2();
        public ParametreForm()
        {
            InitializeComponent();
        }

        // Charger le comboBox avec les services disponibles
        private void metroComboBox1_Click(object sender, EventArgs e)
        {
            this.metroComboBox1.DataSource = db.Service.ToList();
            this.metroComboBox1.DisplayMember = "NomService";
            this.metroComboBox1.ValueMember = "IDService";
        }

        // Modifier le compte
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Regex fullNameReg = new Regex(@"^[a-zA-Z]{2,}(\s[a-zA-Z]{2,})*$");
            Regex phoneReg = new Regex("^(06|05|07)[0-9]{8}$");

            // Chercher le chef => si il est dèjà connecté
            Chef searchedChef = db.Chef.Where(c => c.NomUtilisateur.Equals(Session.NomUtilisateur) && c.Mdp.Equals(Session.MotDePasse)).FirstOrDefault();

            // valeur boolénne pour vérifier les infos
            bool isOk = true;

            if (searchedChef != null)
            {
                // Checker tous d'abord si le nom d'utilisateur existe dèjà dans la BD ou non
                Chef chef = db.Chef.Where(c => c.NomUtilisateur.Equals(this.metroTextBox5.Text) && !c.NomUtilisateur.Equals(Session.NomUtilisateur)).FirstOrDefault();
                Employe emp = db.Employe.Where(em => em.NomUtilisateur.Equals(this.metroTextBox5.Text)).FirstOrDefault();

                if (chef == null && emp == null)
                {

                    // Modifier le chef dans la base de donnée
                    if (this.metroTextBox1.Text != "")
                    {
                        if (fullNameReg.IsMatch(this.metroTextBox1.Text)) searchedChef.NomChef = this.metroTextBox1.Text;
                        else isOk = false;
                    }
                    else searchedChef.NomChef = searchedChef.NomChef;

                    if (this.metroTextBox2.Text != "")
                    {
                        if (fullNameReg.IsMatch(this.metroTextBox2.Text)) searchedChef.PrenomChef = this.metroTextBox2.Text;
                        else isOk = false;
                    }
                    else searchedChef.PrenomChef = searchedChef.PrenomChef;

                    if (this.metroTextBox4.Text != "")
                    {
                        if (phoneReg.IsMatch(this.metroTextBox4.Text)) searchedChef.Tel = this.metroTextBox4.Text;
                        else isOk = false;
                    }
                    else searchedChef.Tel = searchedChef.Tel;

                    searchedChef.DateNaissanceChef = DateTime.Parse(this.metroDateTime1.Text);
                    searchedChef.NomUtilisateur = (this.metroTextBox5.Text != "") ? this.metroTextBox5.Text : searchedChef.NomUtilisateur;
                    searchedChef.Mdp = (this.metroTextBox6.Text != "") ? this.metroTextBox6.Text : searchedChef.Mdp;
                    searchedChef.IDService = (this.metroComboBox1.SelectedIndex != -1) ? Convert.ToInt32(this.metroComboBox1.SelectedValue) : searchedChef.IDService;
                    searchedChef.Photo = (this.pictureBox2.ImageLocation == null) ? searchedChef.Photo : this.pictureBox2.ImageLocation;
                    db.SaveChanges();

                    if (this.pictureBox2.ImageLocation != null)
                    {
                        // Sauvegarder la photo dans le dossier associé au chef
                        File.Copy(this.pictureBox2.ImageLocation, Path.Combine(@"C:\Pdp_congés", Path.GetFileName(this.pictureBox2.ImageLocation)), true);
                    }
                    if (isOk) this.metroLabel9.Text = "Votre compte a été modifier avec success";
                    else
                    {
                        this.metroLabel9.Text = "Inscription échouée, veuillez vérifier votre informations";
                        this.metroLabel9.ForeColor = Color.Red;
                    }
                }
                else
                {
                    this.metroLabel8.Text = "Ce Nom d'utilisateur est dèjà existe";
                }
            }
            else
            {
                this.metroLabel9.Text = "Inscription échouée, veuillez vérifier votre informations";
                this.metroLabel9.ForeColor = Color.Red;
            }
        }

        // Pour uploader la photo de profile
        private void metroButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox2.ImageLocation = dialog.FileName;
            }
        }

        private void listeDesDemandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionEmployesForm gestionEmployesForm = new GestionEmployesForm();
            gestionEmployesForm.Show();
            this.Close();
        }

        private void monCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeDemandesForm listeDemandesForm = new ListeDemandesForm();
            listeDemandesForm.Show();
            this.Close();
        }

        private void monProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
            this.Close();
        }

        private void ParametreForm_Load(object sender, EventArgs e)
        {
            this.menuStrip1.ForeColor = Color.White;
        }
    }
}
