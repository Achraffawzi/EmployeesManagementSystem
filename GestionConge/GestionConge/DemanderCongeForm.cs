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
    public partial class DemanderCongeForm : MetroFramework.Forms.MetroForm
    {
        BDGestionDesCongesEntities2 db = new BDGestionDesCongesEntities2();
        public DemanderCongeForm()
        {
            InitializeComponent();
        }

        // Vérifier si la durée de congé dépasse le max
        public bool CheckDuration(DateTime dateInf, DateTime dateSup)
        {
            return (dateSup - dateInf).Days <= 30;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Récuperer l'ID de l'employé
                Employe emp = db.Employe.Where(em => em.NomUtilisateur.Equals(Session.NomUtilisateur)).FirstOrDefault();

                if (emp != null && this.metroDateTime1.Value < this.metroDateTime2.Value)
                {
                    if (this.CheckDuration(this.metroDateTime1.Value, this.metroDateTime2.Value))
                    {
                        Conge newConge = new Conge
                        {
                            DateDebut = this.metroDateTime1.Value,
                            DateFin = this.metroDateTime2.Value,
                            DateDemandeConge = DateTime.Now.Date,
                            IDEmp = emp.CIN,
                            Etat = "En Attente"
                        };
                        db.Conge.Add(newConge);
                        db.SaveChanges();

                        MessageBox.Show("La demande a été envoyée avec success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Redirection vers la page des demandes faites par l'employé
                        ListeDemandesEmpForm listeDemandesEmpForm = new ListeDemandesEmpForm();
                        listeDemandesEmpForm.Show();
                        this.Close();
                    }
                    else
                    {
                        this.metroLabel3.Text = "vous avez dépassé le nombre de jours permis";
                    }
                }
                else
                {
                    this.metroLabel3.Text = "La date de fin de congé ne peut pas etre inférieur ou égale à la date de début de congé";
                }
            }
            catch
            {
                this.metroLabel3.Text = "Une erreur s'est produite";
            }
        }

        private void DemanderCongeForm_Load(object sender, EventArgs e)
        {
            this.menuStrip1.ForeColor = Color.White;
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
            ProfileEmpForm profileEmpForm = new ProfileEmpForm();
            profileEmpForm.Show();
            this.Close();
        }
    }
}
