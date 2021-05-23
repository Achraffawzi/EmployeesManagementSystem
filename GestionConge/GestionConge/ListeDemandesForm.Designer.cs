
namespace GestionConge
{
    partial class ListeDemandesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeDemandesForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDConge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDemandeConge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listeDesDemandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEmp,
            this.NomEmp,
            this.PrenomEmp,
            this.IDConge,
            this.DateDemandeConge,
            this.DateDebut,
            this.DateFin});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(54, 237);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(853, 227);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IDEmp
            // 
            this.IDEmp.DataPropertyName = "IDEmp";
            this.IDEmp.HeaderText = "ID Employé";
            this.IDEmp.Name = "IDEmp";
            this.IDEmp.ReadOnly = true;
            // 
            // NomEmp
            // 
            this.NomEmp.DataPropertyName = "NomEmp";
            this.NomEmp.HeaderText = "Nom d\'employé";
            this.NomEmp.Name = "NomEmp";
            this.NomEmp.ReadOnly = true;
            // 
            // PrenomEmp
            // 
            this.PrenomEmp.DataPropertyName = "PrenomEmp";
            this.PrenomEmp.HeaderText = "Prénom d\'employé";
            this.PrenomEmp.Name = "PrenomEmp";
            this.PrenomEmp.ReadOnly = true;
            // 
            // IDConge
            // 
            this.IDConge.DataPropertyName = "IDConge";
            this.IDConge.HeaderText = "ID Congé";
            this.IDConge.Name = "IDConge";
            this.IDConge.ReadOnly = true;
            // 
            // DateDemandeConge
            // 
            this.DateDemandeConge.DataPropertyName = "DateDemandeConge";
            this.DateDemandeConge.HeaderText = "Date demande";
            this.DateDemandeConge.Name = "DateDemandeConge";
            this.DateDemandeConge.ReadOnly = true;
            // 
            // DateDebut
            // 
            this.DateDebut.DataPropertyName = "DateDebut";
            this.DateDebut.HeaderText = "Date début congé";
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.ReadOnly = true;
            // 
            // DateFin
            // 
            this.DateFin.DataPropertyName = "DateFin";
            this.DateFin.HeaderText = "Date Fin Congé";
            this.DateFin.Name = "DateFin";
            this.DateFin.ReadOnly = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(107, 111);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 4;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            this.metroComboBox1.Click += new System.EventHandler(this.metroComboBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 115);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(31, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Etat";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(43, 196);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Date Inférieur";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(410, 195);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Date Supérieur";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroDateTime1.Location = new System.Drawing.Point(147, 191);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 8;
            this.metroDateTime1.Value = new System.DateTime(2021, 5, 8, 0, 0, 0, 0);
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroDateTime2.Location = new System.Drawing.Point(524, 191);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 9;
            this.metroDateTime2.Value = new System.DateTime(2021, 5, 8, 0, 0, 0, 0);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton1.Location = new System.Drawing.Point(783, 191);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(101, 29);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "Filtrer";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesDemandesToolStripMenuItem,
            this.monCompteToolStripMenuItem,
            this.monProfileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listeDesDemandesToolStripMenuItem
            // 
            this.listeDesDemandesToolStripMenuItem.Name = "listeDesDemandesToolStripMenuItem";
            this.listeDesDemandesToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.listeDesDemandesToolStripMenuItem.Text = "Gestion des employés";
            this.listeDesDemandesToolStripMenuItem.Click += new System.EventHandler(this.listeDesDemandesToolStripMenuItem_Click);
            // 
            // monCompteToolStripMenuItem
            // 
            this.monCompteToolStripMenuItem.Name = "monCompteToolStripMenuItem";
            this.monCompteToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.monCompteToolStripMenuItem.Text = "Mon compte";
            this.monCompteToolStripMenuItem.Click += new System.EventHandler(this.monCompteToolStripMenuItem_Click);
            // 
            // monProfileToolStripMenuItem
            // 
            this.monProfileToolStripMenuItem.Name = "monProfileToolStripMenuItem";
            this.monProfileToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.monProfileToolStripMenuItem.Text = "Mon profile";
            this.monProfileToolStripMenuItem.Click += new System.EventHandler(this.monProfileToolStripMenuItem_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.ForeColor = System.Drawing.Color.Gray;
            this.metroLabel4.Location = new System.Drawing.Point(241, 483);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(512, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Ministère de l\'interieur, prefecture d\'Inezegane Ait-melloul, commune Dcheira Elj" +
    "ihadia";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile5.BackColor = System.Drawing.Color.Transparent;
            this.metroTile5.Location = new System.Drawing.Point(831, 9);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(45, 48);
            this.metroTile5.TabIndex = 12;
            this.metroTile5.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile5.TileImage")));
            this.metroTile5.UseCustomBackColor = true;
            this.metroTile5.UseCustomForeColor = true;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            // 
            // ListeDemandesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 511);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListeDemandesForm";
            this.Text = "La liste des demandes";
            this.Load += new System.EventHandler(this.ListeDemandesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDConge;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDemandeConge;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeDesDemandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monProfileToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile metroTile5;
    }
}