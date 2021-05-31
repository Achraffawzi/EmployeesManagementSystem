using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionConge
{
    public partial class ParametreEmpForm : MetroFramework.Forms.MetroForm
    {
        BDGestionDesCongesEntities2 db = new BDGestionDesCongesEntities2();
        public ParametreEmpForm()
        {
            InitializeComponent();
        }

        // Charger le comboBox avec les services disponibles
        private void metroComboBox1_Click_1(object sender, EventArgs e)
        {
            this.metroComboBox1.DataSource = db.Service.ToList();
            this.metroComboBox1.DisplayMember = "NomService";
            this.metroComboBox1.ValueMember = "IDService";
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Regex fullNameReg = new Regex(@"^[a-zA-Z]{2,}(\s[a-zA-Z]{2,})*$");
            Regex phoneReg = new Regex("^(06|05|07)[0-9]{8}$");

            // Chercher l'employé
            Employe searchedEmploye = db.Employe.Where(c => c.NomUtilisateur.Equals(Session.NomUtilisateur) && c.Mdp.Equals(Session.MotDePasse)).FirstOrDefault();

            // valeur boolénne pour vérifier les infos
            bool isOk = true;

            if (searchedEmploye != null)
            {
                // Checker tous d'abord si le nom d'utilisateur existe dèjà dans la BD ou non
                Chef chef = db.Chef.Where(c => c.NomUtilisateur.Equals(this.metroTextBox5.Text)).FirstOrDefault();
                Employe emp = db.Employe.Where(em => em.NomUtilisateur.Equals(this.metroTextBox5.Text) && !em.NomUtilisateur.Equals(Session.NomUtilisateur)).FirstOrDefault();

                if (chef == null && emp == null)
                {
                    // Modifier le chef dans la base de donnée
                    if (this.metroTextBox1.Text != "")
                    {
                        if (fullNameReg.IsMatch(this.metroTextBox1.Text)) searchedEmploye.NomEmp = this.metroTextBox1.Text;
                        else isOk = false;
                    }
                    else searchedEmploye.NomEmp = searchedEmploye.NomEmp;

                    if (this.metroTextBox2.Text != "")
                    {
                        if (fullNameReg.IsMatch(this.metroTextBox2.Text)) searchedEmploye.PrenomEmp = this.metroTextBox2.Text;
                        else isOk = false;
                    }
                    else searchedEmploye.PrenomEmp = searchedEmploye.PrenomEmp;

                    if (this.metroTextBox4.Text != "")
                    {
                        if (phoneReg.IsMatch(this.metroTextBox4.Text)) searchedEmploye.TelEmp = this.metroTextBox4.Text;
                        else isOk = false;
                    }
                    else searchedEmploye.TelEmp = searchedEmploye.TelEmp;

                    searchedEmploye.DateNaissanceEmp = DateTime.Parse(this.metroDateTime1.Text);
                    searchedEmploye.NomUtilisateur = (this.metroTextBox5.Text != "") ? this.metroTextBox5.Text : searchedEmploye.NomUtilisateur;
                    searchedEmploye.Mdp = (this.metroTextBox6.Text != "") ? this.metroTextBox6.Text : searchedEmploye.Mdp;
                    searchedEmploye.IDService = (this.metroComboBox1.SelectedIndex != -1) ? Convert.ToInt32(this.metroComboBox1.SelectedValue) : searchedEmploye.IDService;
                    searchedEmploye.Photo = (this.pictureBox2.ImageLocation == null) ? searchedEmploye.Photo : this.pictureBox2.ImageLocation;
                    db.SaveChanges();

                    if (this.pictureBox2.ImageLocation != null)
                    {
                        // Sauvegarder la photo dans le dossier associé au chef
                        File.Copy(this.pictureBox2.ImageLocation, Path.Combine(@"C:\Pdp_congés", Path.GetFileName(this.pictureBox2.ImageLocation)), true);
                    }

                    if(isOk) this.metroLabel9.Text = "Votre compte a été modifier avec success";
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox2.ImageLocation = dialog.FileName;
            }
        }

        private void ParametreEmpForm_Load(object sender, EventArgs e)
        {
            this.menuStrip1.ForeColor = Color.White;
        }

        private void monCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemanderCongeForm demanderCongeorm = new DemanderCongeForm();
            demanderCongeorm.Show();
            this.Close();
        }

        private void mesDemandesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
ListeDemandesEmpForm listeDemandesEmpForm = new ListeDemandesEmpForm();
            listeDemandesEmpForm.Show();
            this.Close();
        }

        private void monProfileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
ProfileEmpForm profileEmpForm = new ProfileEmpForm();
            profileEmpForm.Show();
            this.Close();
        }
    }
}
