
namespace GestionConge
{
    partial class DemanderCongeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemanderCongeForm));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mesDemandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton1.Location = new System.Drawing.Point(185, 264);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(139, 36);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Envoyer la demande";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(185, 138);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Date Début";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(185, 198);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Date Fin";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroDateTime1.Location = new System.Drawing.Point(287, 134);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 3;
            this.metroDateTime1.Value = new System.DateTime(2021, 5, 9, 0, 0, 0, 0);
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroDateTime2.Location = new System.Drawing.Point(287, 193);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime2.TabIndex = 4;
            this.metroDateTime2.Value = new System.DateTime(2021, 5, 5, 0, 0, 0, 0);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Red;
            this.metroLabel3.Location = new System.Drawing.Point(185, 93);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(0, 0);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesDemandesToolStripMenuItem,
            this.monCompteToolStripMenuItem,
            this.monProfileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mesDemandesToolStripMenuItem
            // 
            this.mesDemandesToolStripMenuItem.Name = "mesDemandesToolStripMenuItem";
            this.mesDemandesToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.mesDemandesToolStripMenuItem.Text = "Mes demandes";
            this.mesDemandesToolStripMenuItem.Click += new System.EventHandler(this.mesDemandesToolStripMenuItem_Click);
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
            this.metroLabel4.Location = new System.Drawing.Point(127, 411);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(512, 19);
            this.metroLabel4.TabIndex = 12;
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
            this.metroTile5.Location = new System.Drawing.Point(642, 9);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(45, 48);
            this.metroTile5.TabIndex = 11;
            this.metroTile5.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile5.TileImage")));
            this.metroTile5.UseCustomBackColor = true;
            this.metroTile5.UseCustomForeColor = true;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseTileImage = true;
            // 
            // DemanderCongeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DemanderCongeForm";
            this.Text = "Demander nouveau congé";
            this.Load += new System.EventHandler(this.DemanderCongeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mesDemandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monProfileToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile metroTile5;
    }
}