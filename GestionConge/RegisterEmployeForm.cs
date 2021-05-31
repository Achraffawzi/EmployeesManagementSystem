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
    public partial class RegisterEmployeForm : MetroFramework.Forms.MetroForm
    {
        BDGestionDesCongesEntities2 db = new BDGestionDesCongesEntities2();
        public RegisterEmployeForm()
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


        // L'inscription d'un employé
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Regex fullNameReg = new Regex(@"^[a-zA-Z]{2,}(\s[a-zA-Z]{2,})*$");
                Regex phoneReg = new Regex("^(06|05|07)[0-9]{8}$");
                Regex cinReg = new Regex("^[a-zA-Z]{1,2}[0-9]{5,6}$");
                bool isEmplty = false;
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox && c.Text == "")
                    {
                        isEmplty = true;
                        break;
                    }
                }
                // CHecker si un textbox est vide ou comboBox est vide
                if (isEmplty || this.metroComboBox1.SelectedIndex == -1 || !fullNameReg.IsMatch(this.metroTextBox1.Text)
                    || !fullNameReg.IsMatch(this.metroTextBox2.Text) || !phoneReg.IsMatch(this.metroTextBox4.Text) ||
                    !cinReg.IsMatch(this.metroTextBox3.Text))
                {
                    this.metroLabel8.Text = "Inscription échouée, veuillez vérifier votre informations";
                }
                else
                {
                    // Checker tous d'abord si le nom d'utilisateur existe dèjà dans la BD ou non
                    // Checker si le CIN existe dèjà
                    Chef chef = db.Chef.Where(c => c.NomUtilisateur.Equals(this.metroTextBox5.Text) || c.CIN.Equals(this.metroTextBox3.Text)).FirstOrDefault();
                    Employe emp = db.Employe.Where(em => em.NomUtilisateur.Equals(this.metroTextBox5.Text) || em.CIN.Equals(this.metroTextBox3.Text)).FirstOrDefault();

                    if (chef == null && emp == null)
                    {
                        // Ajouter le chef dans la base de donnée
                        Employe newEmploye = new Employe
                        {
                            CIN = this.metroTextBox3.Text,
                            NomEmp = this.metroTextBox1.Text,
                            PrenomEmp = this.metroTextBox2.Text,
                            DateNaissanceEmp = DateTime.Parse(this.metroDateTime1.Text),
                            TelEmp = this.metroTextBox4.Text,
                            NomUtilisateur = this.metroTextBox5.Text,
                            Mdp = this.metroTextBox6.Text,
                            IDService = Convert.ToInt32(this.metroComboBox1.SelectedValue),
                            Photo = (this.pictureBox1.ImageLocation == null) ? "~/Resources/defaultPicture.jpg" : this.pictureBox1.ImageLocation,
                        };
                        db.Employe.Add(newEmploye);
                        db.SaveChanges();

                        if (this.pictureBox1.ImageLocation != null)
                        {
                            // Sauvegarder la photo dans le dossier associé au chef
                            File.Copy(this.pictureBox1.ImageLocation, Path.Combine(@"C:\Pdp_congés", Path.GetFileName(this.pictureBox1.ImageLocation)), true);
                        }

                        // Redirecter l'employé vers la page de la connexion
                        LoginEmpForm logEmpForm = new LoginEmpForm();
                        logEmpForm.Show();
                        this.Close();
                    }
                    else
                    {
                        this.metroLabel8.Text = "Nom d'utilisateur ou CIN existe déjà";
                    }
                }
            }
            catch
            {
                this.metroLabel8.Text = "Inscription échouée, veuillez vérifier votre informations";
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            // Redirecter l'employé vers la page de la connexion
            LoginEmpForm logEmpForm = new LoginEmpForm();
            logEmpForm.Show();
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.ImageLocation = dialog.FileName;
            }
        }
    }
}
