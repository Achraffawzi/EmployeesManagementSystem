
namespace GestionConge
{
    partial class GestionEmployesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionEmployesForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listeDesDemandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.PrenomEmp});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(56, 234);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(809, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // IDEmp
            // 
            this.IDEmp.DataPropertyName = "IDEmp";
            this.IDEmp.HeaderText = "CIN";
            this.IDEmp.Name = "IDEmp";
            this.IDEmp.ReadOnly = true;
            // 
            // NomEmp
            // 
            this.NomEmp.DataPropertyName = "NomEmp";
            this.NomEmp.HeaderText = "Nom employé";
            this.NomEmp.Name = "NomEmp";
            this.NomEmp.ReadOnly = true;
            // 
            // PrenomEmp
            // 
            this.PrenomEmp.DataPropertyName = "PrenomEmp";
            this.PrenomEmp.HeaderText = "Prénom employé";
            this.PrenomEmp.Name = "PrenomEmp";
            this.PrenomEmp.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(711, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listeDesDemandesToolStripMenuItem
            // 
            this.listeDesDemandesToolStripMenuItem.Name = "listeDesDemandesToolStripMenuItem";
            this.listeDesDemandesToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.listeDesDemandesToolStripMenuItem.Text = "liste des demandes";
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(56, 115);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(31, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "CIN";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(110, 106);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(150, 37);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroButton1.Location = new System.Drawing.Point(277, 106);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(100, 37);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Recherche";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.Color.Gray;
            this.metroLabel2.Location = new System.Drawing.Point(225, 492);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(512, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Ministère de l\'interieur, prefecture d\'Inezegane Ait-melloul, commune Dcheira Elj" +
    "ihadia";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile5.BackColor = System.Drawing.Color.Transparent;
            this.metroTile5.Location = new System.Drawing.Point(787, 9);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(45, 48);
            this.metroTile5.TabIndex = 11;
            this.metroTile5.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile5.TileImage")));
            this.metroTile5.UseCustomBackColor = true;
            this.metroTile5.UseCustomForeColor = true;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            // 
            // GestionEmployesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 531);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestionEmployesForm";
            this.Text = "Gestion des employés";
            this.Load += new System.EventHandler(this.GestionEmployesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomEmp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeDesDemandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monProfileToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile5;
    }
}