
namespace FrmSport
{
    partial class FrmSport
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSaisieSport = new System.Windows.Forms.GroupBox();
            this.TxtSport = new System.Windows.Forms.TextBox();
            this.BtnAjouterSport = new System.Windows.Forms.Button();
            this.groupBoxListeSport = new System.Windows.Forms.GroupBox();
            this.CkcSelectAll = new System.Windows.Forms.CheckBox();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.groupBoxListeBddSport = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBoxSelectSport = new System.Windows.Forms.ComboBox();
            this.groupBoxAdherents = new System.Windows.Forms.GroupBox();
            this.LblSports = new System.Windows.Forms.Label();
            this.comboBoxAdherent = new System.Windows.Forms.ComboBox();
            this.LblAdherent = new System.Windows.Forms.Label();
            this.groupBoxSaisieSport.SuspendLayout();
            this.groupBoxListeSport.SuspendLayout();
            this.groupBoxListeBddSport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxAdherents.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSaisieSport
            // 
            this.groupBoxSaisieSport.Controls.Add(this.TxtSport);
            this.groupBoxSaisieSport.Controls.Add(this.BtnAjouterSport);
            this.groupBoxSaisieSport.Location = new System.Drawing.Point(12, 269);
            this.groupBoxSaisieSport.Name = "groupBoxSaisieSport";
            this.groupBoxSaisieSport.Size = new System.Drawing.Size(290, 44);
            this.groupBoxSaisieSport.TabIndex = 0;
            this.groupBoxSaisieSport.TabStop = false;
            this.groupBoxSaisieSport.Text = "Saisie d\'un sport";
            // 
            // TxtSport
            // 
            this.TxtSport.Location = new System.Drawing.Point(6, 16);
            this.TxtSport.Name = "TxtSport";
            this.TxtSport.Size = new System.Drawing.Size(196, 20);
            this.TxtSport.TabIndex = 1;
            this.TxtSport.TextChanged += new System.EventHandler(this.TxtSport_TextChanged);
            // 
            // BtnAjouterSport
            // 
            this.BtnAjouterSport.Location = new System.Drawing.Point(209, 15);
            this.BtnAjouterSport.Name = "BtnAjouterSport";
            this.BtnAjouterSport.Size = new System.Drawing.Size(75, 23);
            this.BtnAjouterSport.TabIndex = 0;
            this.BtnAjouterSport.Text = "Ajouter";
            this.BtnAjouterSport.UseVisualStyleBackColor = true;
            this.BtnAjouterSport.Click += new System.EventHandler(this.BtnAjouterSport_Click);
            // 
            // groupBoxListeSport
            // 
            this.groupBoxListeSport.Controls.Add(this.CkcSelectAll);
            this.groupBoxListeSport.Location = new System.Drawing.Point(12, 12);
            this.groupBoxListeSport.Name = "groupBoxListeSport";
            this.groupBoxListeSport.Size = new System.Drawing.Size(290, 225);
            this.groupBoxListeSport.TabIndex = 1;
            this.groupBoxListeSport.TabStop = false;
            this.groupBoxListeSport.Text = "Sports";
            // 
            // CkcSelectAll
            // 
            this.CkcSelectAll.AutoSize = true;
            this.CkcSelectAll.Location = new System.Drawing.Point(6, 199);
            this.CkcSelectAll.Name = "CkcSelectAll";
            this.CkcSelectAll.Size = new System.Drawing.Size(108, 17);
            this.CkcSelectAll.TabIndex = 0;
            this.CkcSelectAll.Text = "Tout sélectionner";
            this.CkcSelectAll.UseVisualStyleBackColor = true;
            this.CkcSelectAll.CheckedChanged += new System.EventHandler(this.CkcSelectAll_CheckedChanged);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(317, 283);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(75, 23);
            this.BtnQuitter.TabIndex = 2;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // groupBoxListeBddSport
            // 
            this.groupBoxListeBddSport.Controls.Add(this.checkBox1);
            this.groupBoxListeBddSport.Location = new System.Drawing.Point(498, 12);
            this.groupBoxListeBddSport.Name = "groupBoxListeBddSport";
            this.groupBoxListeBddSport.Size = new System.Drawing.Size(290, 225);
            this.groupBoxListeBddSport.TabIndex = 3;
            this.groupBoxListeBddSport.TabStop = false;
            this.groupBoxListeBddSport.Text = "Sports Base de données";
            this.groupBoxListeBddSport.Enter += new System.EventHandler(this.groupBoxListeBddSport_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 199);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Tout sélectionner";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sports";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 199);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Tout sélectionner";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CkcSelectAll_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Location = new System.Drawing.Point(498, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 225);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sports Base de données";
            this.groupBox2.Enter += new System.EventHandler(this.groupBoxListeBddSport_Enter);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 199);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(108, 17);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Tout sélectionner";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // comboBoxSelectSport
            // 
            this.comboBoxSelectSport.FormattingEnabled = true;
            this.comboBoxSelectSport.Location = new System.Drawing.Point(37, 30);
            this.comboBoxSelectSport.Name = "comboBoxSelectSport";
            this.comboBoxSelectSport.Size = new System.Drawing.Size(181, 21);
            this.comboBoxSelectSport.TabIndex = 4;
            this.comboBoxSelectSport.Text = "-- Sélectionnez --";
            this.comboBoxSelectSport.Click += new System.EventHandler(this.comboBoxSelectSport_Click);
            // 
            // groupBoxAdherents
            // 
            this.groupBoxAdherents.Controls.Add(this.LblAdherent);
            this.groupBoxAdherents.Controls.Add(this.comboBoxAdherent);
            this.groupBoxAdherents.Controls.Add(this.LblSports);
            this.groupBoxAdherents.Controls.Add(this.comboBoxSelectSport);
            this.groupBoxAdherents.Location = new System.Drawing.Point(78, 319);
            this.groupBoxAdherents.Name = "groupBoxAdherents";
            this.groupBoxAdherents.Size = new System.Drawing.Size(662, 232);
            this.groupBoxAdherents.TabIndex = 5;
            this.groupBoxAdherents.TabStop = false;
            this.groupBoxAdherents.Text = "Adhérents";
            // 
            // LblSports
            // 
            this.LblSports.AutoSize = true;
            this.LblSports.Location = new System.Drawing.Point(99, 16);
            this.LblSports.Name = "LblSports";
            this.LblSports.Size = new System.Drawing.Size(37, 13);
            this.LblSports.TabIndex = 5;
            this.LblSports.Text = "Sports";
            // 
            // comboBoxAdherent
            // 
            this.comboBoxAdherent.FormattingEnabled = true;
            this.comboBoxAdherent.Location = new System.Drawing.Point(426, 30);
            this.comboBoxAdherent.Name = "comboBoxAdherent";
            this.comboBoxAdherent.Size = new System.Drawing.Size(181, 21);
            this.comboBoxAdherent.TabIndex = 6;
            this.comboBoxAdherent.Text = "-- Sélectionnez --";
            // 
            // LblAdherent
            // 
            this.LblAdherent.AutoSize = true;
            this.LblAdherent.Location = new System.Drawing.Point(479, 14);
            this.LblAdherent.Name = "LblAdherent";
            this.LblAdherent.Size = new System.Drawing.Size(55, 13);
            this.LblAdherent.TabIndex = 7;
            this.LblAdherent.Text = "Adhérents";
            // 
            // FrmSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupBoxAdherents);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxListeBddSport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.groupBoxListeSport);
            this.Controls.Add(this.groupBoxSaisieSport);
            this.Name = "FrmSport";
            this.Text = "FrmSport";
            this.groupBoxSaisieSport.ResumeLayout(false);
            this.groupBoxSaisieSport.PerformLayout();
            this.groupBoxListeSport.ResumeLayout(false);
            this.groupBoxListeSport.PerformLayout();
            this.groupBoxListeBddSport.ResumeLayout(false);
            this.groupBoxListeBddSport.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxAdherents.ResumeLayout(false);
            this.groupBoxAdherents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSaisieSport;
        private System.Windows.Forms.Button BtnAjouterSport;
        private System.Windows.Forms.GroupBox groupBoxListeSport;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.TextBox TxtSport;
        private System.Windows.Forms.CheckBox CkcSelectAll;
        private System.Windows.Forms.GroupBox groupBoxListeBddSport;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comboBoxSelectSport;
        private System.Windows.Forms.GroupBox groupBoxAdherents;
        private System.Windows.Forms.Label LblSports;
        private System.Windows.Forms.Label LblAdherent;
        private System.Windows.Forms.ComboBox comboBoxAdherent;
    }
}

