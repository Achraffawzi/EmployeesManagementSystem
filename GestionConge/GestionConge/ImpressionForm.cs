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
    public partial class ImpressionForm : MetroFramework.Forms.MetroForm
    {
        BDGestionDesCongesEntities2 db = new BDGestionDesCongesEntities2();
        static int idConge;
        public ImpressionForm()
        {
            InitializeComponent();
        }

        public ImpressionForm(int p_idConge)
        {
            InitializeComponent();
            idConge = p_idConge;
        }

        private void ImpressionForm_Load(object sender, EventArgs e)
        {
            // Récupérer le congé de l'employé courant
            Conge conge = db.Conge.FirstOrDefault(c => c.IDConge == idConge);

            var query = db.Conge.Where(c => c.IDConge == idConge).ToList();

            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(query);
            this.crystalReportViewer1.ReportSource = cr;
            this.crystalReportViewer1.Refresh();
        }
    }
}
