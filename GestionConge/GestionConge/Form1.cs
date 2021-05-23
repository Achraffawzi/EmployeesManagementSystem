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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // GOTO : Redirection vers la page d'inscription de l'employé 
        private void metroTile1_Click(object sender, EventArgs e)
        {
            LoginEmpForm loginEmpForm = new LoginEmpForm();
            loginEmpForm.Show();
            //this.Hide();
        }

        // GOTO : Redirection vers la page d'inscription du chef 
        private void metroTile2_Click(object sender, EventArgs e)
        {
            LoginForm logForm = new LoginForm();
            logForm.Show();
            //this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment quitter l'application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.ExitThread();
            }
            else e.Cancel = true;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
