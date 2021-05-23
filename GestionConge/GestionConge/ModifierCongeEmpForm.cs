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
    public partial class ModifierCongeEmpForm : MetroFramework.Forms.MetroForm
    {
        BDGestionDesCongesEntities2 db = new BDGestionDesCongesEntities2();
        static int idConge; // L'ID du congé récuperé par le formulaire précedent

        // Vérifier si la durée de congé dépasse le max
        public bool CheckDuration(DateTime dateInf, DateTime dateSup)
        {
            return (dateSup - dateInf).Days <= 30;
        }

        public ModifierCongeEmpForm()
        {
            InitializeComponent();
        }
        public ModifierCongeEmpForm(int idConge)
        {
            InitializeComponent();
            ModifierCongeEmpForm.idConge = idConge;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(this.metroDateTime1.Value >= this.metroDateTime2.Value)
            {
                this.metroLabel4.Text = "La date de fin de congé ne peut pas etre inférieur ou égale à la date de début de congé";
            }
            else if (!this.CheckDuration(this.metroDateTime1.Value, this.metroDateTime2.Value))
            {
                this.metroLabel4.Text = "vous avez dépassé le nombre de jours permis";
            }
            else
            {
                // Récupérer le congé
                Conge modifiedConge = db.Conge.Find(idConge);
                if (modifiedConge != null)
                {
                    modifiedConge.DateDebut = this.metroDateTime1.Value;
                    modifiedConge.DateFin = this.metroDateTime2.Value;

                    db.SaveChanges();
                }
            }
        }
    }
}
