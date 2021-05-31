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
    public partial class ListeDemandesForm : MetroFramework.Forms.MetroForm
    {
        BDGestionDesCongesEntities2 db = new BDGestionDesCongesEntities2();
        public ListeDemandesForm()
        {
            InitializeComponent();
        }

        // Charger le comboBox avec les services disponibles
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

        public void ChargerListeDemandes()
        {
            try
            {

                this.dataGridView1.DataSource = null;
                this.dataGridView1.Columns.Clear();

                // Récuperer le service du chef
                int idServiceDuChef = db.Chef.Where(c => c.NomUtilisateur.Equals(Session.NomUtilisateur)).FirstOrDefault().IDService;

                this.dataGridView1.DataSource = (from c in db.Conge
                                                 join emp in db.Employe on c.IDEmp equals emp.CIN
                                                 join s in db.Service on emp.IDService equals s.IDService
                                                 where c.Etat.Equals(this.metroComboBox1.Text) && emp.IDService == idServiceDuChef
                                                 select new
                                                 {
                                                     CIN = emp.CIN,
                                                     NomEmp = emp.NomEmp,
                                                     PrenomEmp = emp.PrenomEmp,
                                                     IDConge = c.IDConge,
                                                     DateDemandeConge = c.DateDemandeConge,
                                                     DateDebut = c.DateDebut,
                                                     DateFin = c.DateFin
                                                 }).ToList();

                if (this.metroComboBox1.Text.Equals("En Attente"))
                {
                    // Ajouter une colonne pour le boutton supprimer
                    DataGridViewButtonColumn validateButton = new DataGridViewButtonColumn();
                    validateButton.Name = "Valider les demandes";
                    validateButton.Text = "Valider";
                    validateButton.UseColumnTextForButtonValue = true;
                    validateButton.FlatStyle = FlatStyle.Flat;
                    validateButton.DefaultCellStyle.BackColor = Color.Green;
                    validateButton.DefaultCellStyle.ForeColor = Color.White;
                    this.dataGridView1.Columns.Add(validateButton);

                    // Ajouter une colonne pour le boutton Rejeter
                    DataGridViewButtonColumn RefuseButton = new DataGridViewButtonColumn();
                    RefuseButton.Name = "Refuser les demandes";
                    RefuseButton.Text = "Refuser";
                    RefuseButton.UseColumnTextForButtonValue = true;
                    RefuseButton.FlatStyle = FlatStyle.Flat;
                    RefuseButton.DefaultCellStyle.BackColor = Color.Red;
                    RefuseButton.DefaultCellStyle.ForeColor = Color.White;
                    this.dataGridView1.Columns.Add(RefuseButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ChargerListeDemandes(DateTime? dateInf, DateTime? dateSup)
        {
            try
            {

                this.dataGridView1.DataSource = null;
                this.dataGridView1.Columns.Clear();

                // Récuperer le service du chef
                int idServiceDuChef = db.Chef.Where(c => c.NomUtilisateur.Equals(Session.NomUtilisateur)).FirstOrDefault().IDService;
                this.dataGridView1.DataSource = (from c in db.Conge
                                                 join emp in db.Employe on c.IDEmp equals emp.CIN
                                                 join s in db.Service on emp.IDService equals s.IDService
                                                 where c.Etat.Equals(this.metroComboBox1.Text) && emp.IDService == idServiceDuChef
                                                 && c.DateDemandeConge >= dateInf && c.DateDemandeConge <= dateSup
                                                 select new
                                                 {
                                                     CIN = emp.CIN,
                                                     NomEmp = emp.NomEmp,
                                                     PrenomEmp = emp.PrenomEmp,
                                                     IDConge = c.IDConge,
                                                     DateDemandeConge = c.DateDemandeConge,
                                                     DateDebut = c.DateDebut,
                                                     DateFin = c.DateFin
                                                 }).ToList();

                if (this.metroComboBox1.Text.Equals("En Attente"))
                {
                    // Ajouter une colonne pour le boutton supprimer
                    DataGridViewButtonColumn validateButton = new DataGridViewButtonColumn();
                    validateButton.Name = "Valider les demandes";
                    validateButton.Text = "Valider";
                    validateButton.UseColumnTextForButtonValue = true;
                    validateButton.FlatStyle = FlatStyle.Flat;
                    validateButton.DefaultCellStyle.BackColor = Color.Green;
                    validateButton.DefaultCellStyle.ForeColor = Color.White;
                    this.dataGridView1.Columns.Add(validateButton);

                    // Ajouter une colonne pour le boutton Rejeter
                    DataGridViewButtonColumn RefuseButton = new DataGridViewButtonColumn();
                    RefuseButton.Name = "Refuser les demandes";
                    RefuseButton.Text = "Refuser";
                    RefuseButton.UseColumnTextForButtonValue = true;
                    RefuseButton.FlatStyle = FlatStyle.Flat;
                    RefuseButton.DefaultCellStyle.BackColor = Color.Red;
                    RefuseButton.DefaultCellStyle.ForeColor = Color.White;
                    this.dataGridView1.Columns.Add(RefuseButton);
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
            if (e.ColumnIndex != 7 && e.ColumnIndex != 8 || e.RowIndex == -1)
            {
                return;
            }
            else if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Voulez vous vraiment valider ce congé?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int idConge = Convert.ToInt32(this.dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString());

                    // Valider le congé => changer l'état du congé affecté par employe
                    Conge validateConge = db.Conge.Where(c => c.IDConge == idConge).FirstOrDefault();
                    validateConge.Etat = "Validée";
                    db.SaveChanges();

                    // Recharger DGV avec les congés
                    ChargerListeDemandes();
                }
            }
            else if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("Voulez vous vraiment rejeter ce congé?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int idConge = Convert.ToInt32(this.dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString());

                    // Valider le congé => changer l'état du congé affecté par employe
                    Conge validateConge = db.Conge.Where(c => c.IDConge == idConge).FirstOrDefault();
                    validateConge.Etat = "Refusée";
                    db.SaveChanges();

                    // Recharger DGV avec les congés
                    ChargerListeDemandes();
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ChargerListeDemandes(this.metroDateTime1.Value, this.metroDateTime2.Value);
        }

        private void listeDesDemandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionEmployesForm gestionEmployesForm = new GestionEmployesForm();
            gestionEmployesForm.Show();
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

        private void ListeDemandesForm_Load(object sender, EventArgs e)
        {
            this.menuStrip1.ForeColor = Color.White;
        }
    }
}
