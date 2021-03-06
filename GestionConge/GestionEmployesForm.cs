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

namespace GestionConge
{
    public partial class GestionEmployesForm : MetroFramework.Forms.MetroForm
    {
        BDGestionDesCongesEntities2 db = new BDGestionDesCongesEntities2();
        public GestionEmployesForm()
        {
            InitializeComponent();
        }

        // Charger la liste des employés affecté au service du chef courant
        private void GestionEmployesForm_Load(object sender, EventArgs e)
        {
            // Changer la couler du text du Menustrip
            this.menuStrip1.ForeColor = Color.White;
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            //Vider DGV
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Columns.Clear();

            // Récupérer l'ID Service du chef connecté
            int idService = db.Chef.Where(c => c.NomUtilisateur.Equals(Session.NomUtilisateur)).FirstOrDefault().IDService;

            // Récupérer les employés affecté au service du chef
            this.dataGridView1.DataSource = (from emp in db.Employe
                                             where emp.IDService == idService
                                             select new
                                             {
                                                 CIN = emp.CIN,
                                                 NomEmp = emp.NomEmp,
                                                 PrenomEmp = emp.PrenomEmp,
                                             }).ToList();

            this.dataGridView1.Rows[0].Selected = false;
            List<Employe> listeEmp = db.Employe.Where(em => em.IDService == idService).ToList();

            // Adding a column for deletion
            DataGridViewButtonColumn delButton = new DataGridViewButtonColumn
            {
                Name = "Supression",
                Text = "Supprimer",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
            };
            delButton.DefaultCellStyle.BackColor = Color.Red;
            delButton.DefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.Columns.Add(delButton);
            this.dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Adding a column for resetting the employee's password
            DataGridViewButtonColumn resetPasswordButton = new DataGridViewButtonColumn
            {
                Name = "Réinitialiser le mot de passe",
                Text = "Réinitialiser",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
            };
            resetPasswordButton.DefaultCellStyle.BackColor = Color.DodgerBlue;
            resetPasswordButton.DefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.Columns.Add(resetPasswordButton);
            this.dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex != 3 && e.ColumnIndex != 4) || e.RowIndex == -1) return;
            else if(e.ColumnIndex == 3)
            {
                if (MessageBox.Show("Voulez vous vraiment Supprimer cet employé?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    // Rechercher l'employé
                    Employe emp = db.Employe.Find(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (emp != null)
                    {
                        db.Employe.Remove(emp);
                        db.SaveChanges();
                        MessageBox.Show("Suppression éffectuée avec success");
                        LoadEmployees();
                    }
                }
            }
            else if(e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Voulez vous vraiment réinitialiser le mot de passe?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    // Rechercher l'employé
                    Employe emp = db.Employe.Find(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (emp != null)
                    {
                        emp.Mdp = emp.CIN.ToUpper() + "_" + emp.NomEmp.ToUpper();
                        db.SaveChanges();
                        MessageBox.Show("La réinitialisation du mot de passe est éffectuée avec success!");
                    }
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Cherchr l'URL de la photo de l'employé séléctionné
                string cin = this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["CIN"].Value.ToString();
                string imageURL = db.Employe.Where(em => em.CIN.Equals(cin)).FirstOrDefault().Photo;
                string username = db.Employe.Where(em => em.CIN.Equals(cin)).FirstOrDefault().NomUtilisateur;

                if (!imageURL.Contains("~/Resources/defaultPicture.jpg"))
                {
                    this.pictureBox1.ImageLocation = imageURL;
                }
                else this.pictureBox1.Image = Properties.Resources.defaultPicture;
                this.metroLabel3.Text = username;
            }
            catch(Exception ex)
            {
                return;
            }
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

        private void monProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ChercherParCIN();
        }

        private void ChercherParCIN()
        {
            this.dataGridView1.Columns.Clear();
            this.pictureBox1.Image = null;
            this.metroLabel3.Text = "";
            this.dataGridView1.DataSource = (from emp in db.Employe
                                             where emp.CIN.Contains(this.metroTextBox1.Text)
                                             select new
                                             {
                                                 CIN = emp.CIN,
                                                 NomEmp = emp.NomEmp,
                                                 PrenomEmp = emp.PrenomEmp,
                                             }).ToList();
            if (this.dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("L'employé avec le CIN " + this.metroTextBox1.Text + " n'existe pas");
                this.pictureBox1.Image = null;
                this.metroLabel3.Text = "";
                return;
            }
            // Adding a column for deletion
            DataGridViewButtonColumn delButton = new DataGridViewButtonColumn
            {
                Name = "Supression",
                Text = "Supprimer",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
            };
            delButton.DefaultCellStyle.BackColor = Color.Red;
            delButton.DefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.Columns.Add(delButton);
            this.dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            ChercherParCIN();
        }
    }
}
