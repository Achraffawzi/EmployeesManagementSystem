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
    public partial class ListeDemandesEmpForm : MetroFramework.Forms.MetroForm
    {
        BDGestionDesCongesEntities2 db = new BDGestionDesCongesEntities2();
        public ListeDemandesEmpForm()
        {
            InitializeComponent();
        }

        private void metroComboBox1_Click(object sender, EventArgs e)
        {
            this.metroComboBox1.Items.Clear();
            this.metroComboBox1.Items.AddRange(new string[3]
            {
                "En Attente",
                "Validée",
                "Refusée"
            });
        }

        // OnSelectedIndexChanged => Afficher les congés demandés selon leur état
        public void ChargerListeDemandes()
        {
            try
            {

                this.dataGridView1.DataSource = null;
                this.dataGridView1.Columns.Clear();

                // Récuperer l'ID de l'employé courant
                Employe emp = db.Employe.Where(em => em.NomUtilisateur.Equals(Session.NomUtilisateur)).FirstOrDefault();


                this.dataGridView1.DataSource = (from c in db.Conge
                                                 where c.Etat.Equals(this.metroComboBox1.Text) && c.IDEmp == emp.CIN
                                                 select new
                                                 {
                                                     IDConge = c.IDConge,
                                                     DateDebut = c.DateDebut,
                                                     DateFin = c.DateFin,
                                                     DateDemandeConge = c.DateDemandeConge
                                                 }).ToList();


                if (this.metroComboBox1.Text.Equals("En Attente"))
                {
                    // Ajouter une colonne pour le boutton supprimer
                    DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                    deleteButton.Name = "Supprimer les congés";
                    deleteButton.Text = "Suprimer";
                    deleteButton.UseColumnTextForButtonValue = true;
                    deleteButton.FlatStyle = FlatStyle.Flat;
                    deleteButton.DefaultCellStyle.BackColor = Color.Red;
                    deleteButton.DefaultCellStyle.ForeColor = Color.White;

                    this.dataGridView1.Columns.Add(deleteButton);

                    // Ajouter une colonne pour le boutton Rejeter
                    DataGridViewButtonColumn modifiedButton = new DataGridViewButtonColumn();
                    modifiedButton.Name = "Modifier Les congés";
                    modifiedButton.Text = "Modifier";
                    modifiedButton.UseColumnTextForButtonValue = true;
                    modifiedButton.FlatStyle = FlatStyle.Flat;
                    modifiedButton.DefaultCellStyle.BackColor = Color.Green;
                    modifiedButton.DefaultCellStyle.ForeColor = Color.White;
                    this.dataGridView1.Columns.Add(modifiedButton);
                }
                else if (this.metroComboBox1.Text.Equals("Validée"))
                {
                    // Ajouter une colonne pour le boutton Imprimer demande
                    DataGridViewButtonColumn demandeButton = new DataGridViewButtonColumn();
                    demandeButton.Name = "Impression";
                    demandeButton.Text = "Imprimer la demande";
                    demandeButton.UseColumnTextForButtonValue = true;
                    demandeButton.FlatStyle = FlatStyle.Flat;
                    demandeButton.DefaultCellStyle.BackColor = Color.DodgerBlue;
                    demandeButton.DefaultCellStyle.ForeColor = Color.White;
                    this.dataGridView1.Columns.Add(demandeButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerListeDemandes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4 && e.ColumnIndex != 5 || e.RowIndex == -1)
            {
                return;
            }
            else if (e.ColumnIndex == 4 && this.metroComboBox1.Text.Equals("En Attente"))
            {
                if (MessageBox.Show("Voulez vous vraiment Supprimer ce congé?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int idConge = Convert.ToInt32(this.dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["IDConge"].Value);
                    Conge deletedConge = db.Conge.Find(idConge);
                    db.Conge.Remove(deletedConge);
                    db.SaveChanges();

                    // Recharger DGV avec les congés
                    ChargerListeDemandes();
                }
            }
            else if (e.ColumnIndex == 5 && this.metroComboBox1.Text.Equals("En Attente"))
            {
                int idConge = Convert.ToInt32(this.dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["IDConge"].Value);
                // Redirection vers la page de modification d'un congé
                ModifierCongeEmpForm modifierCongeEmpForm = new ModifierCongeEmpForm(idConge);
                modifierCongeEmpForm.Show();
            }
            else if (e.ColumnIndex == 4 && this.metroComboBox1.Text.Equals("Validée"))
            {
                int idConge = Convert.ToInt32(this.dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells["IDConge"].Value.ToString());
                // Crystal report
                ImpressionForm impForm = new ImpressionForm(idConge);
                impForm.Show();
                this.Close();
            }
        }

        // Charger DGV selon le filter des dateinf et dateSup
        public void ChargerListeDemandes(DateTime? dateInf, DateTime? dateSup)
        {
            try
            {

                this.dataGridView1.DataSource = null;
                this.dataGridView1.Columns.Clear();

                // Récuperer l'ID de l'employé courant
                Employe emp = db.Employe.Where(em => em.NomUtilisateur.Equals(Session.NomUtilisateur)).FirstOrDefault();


                this.dataGridView1.DataSource = (from c in db.Conge
                                                 where c.Etat.Equals(this.metroComboBox1.Text) && c.IDEmp == emp.CIN
                                                 && c.DateDemandeConge >= dateInf && c.DateDemandeConge <= dateSup
                                                 select new
                                                 {
                                                     IDConge = c.IDConge,
                                                     DateDebut = c.DateDebut,
                                                     DateFin = c.DateFin,
                                                     DateDemandeConge = c.DateDemandeConge
                                                 }).ToList();


                if (this.metroComboBox1.Text.Equals("En Attente"))
                {
                    // Ajouter une colonne pour le boutton supprimer
                    DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                    deleteButton.Name = "Supprimer les congés";
                    deleteButton.Text = "Suprimer";
                    deleteButton.UseColumnTextForButtonValue = true;
                    deleteButton.FlatStyle = FlatStyle.Flat;
                    deleteButton.DefaultCellStyle.BackColor = Color.Red;
                    deleteButton.DefaultCellStyle.ForeColor = Color.White;

                    this.dataGridView1.Columns.Add(deleteButton);

                    // Ajouter une colonne pour le boutton Rejeter
                    DataGridViewButtonColumn modifiedButton = new DataGridViewButtonColumn();
                    modifiedButton.Name = "Modifier Les congés";
                    modifiedButton.Text = "Modifier";
                    modifiedButton.UseColumnTextForButtonValue = true;
                    modifiedButton.FlatStyle = FlatStyle.Flat;
                    modifiedButton.DefaultCellStyle.BackColor = Color.Green;
                    modifiedButton.DefaultCellStyle.ForeColor = Color.White;
                    this.dataGridView1.Columns.Add(modifiedButton);
                }
                else if (this.metroComboBox1.Text.Equals("Validée"))
                {
                    // Ajouter une colonne pour le boutton Imprimer demande
                    DataGridViewButtonColumn demandeButton = new DataGridViewButtonColumn();
                    demandeButton.Name = "Impression";
                    demandeButton.Text = "Imprimer la demande";
                    demandeButton.UseColumnTextForButtonValue = true;
                    demandeButton.FlatStyle = FlatStyle.Flat;
                    demandeButton.DefaultCellStyle.BackColor = Color.DodgerBlue;
                    demandeButton.DefaultCellStyle.ForeColor = Color.White;
                    this.dataGridView1.Columns.Add(demandeButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ChargerListeDemandes(this.metroDateTime1.Value, this.metroDateTime2.Value);
        }

        private void mesDemandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemanderCongeForm demanderCongeForm = new DemanderCongeForm();
            demanderCongeForm.Show();
            this.Close();
        }

        private void ListeDemandesEmpForm_Load(object sender, EventArgs e)
        {
            this.menuStrip1.ForeColor = Color.White;
        }

        private void monCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParametreEmpForm paramEmpForm = new ParametreEmpForm();
            paramEmpForm.Show();
            this.Close();
        }

        private void monProfileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ProfileEmpForm profileEmpForm = new ProfileEmpForm();
            profileEmpForm.Show();
            this.Close();
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
