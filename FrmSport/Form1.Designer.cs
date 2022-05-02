
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
            this.CkcSelectAllBdd = new System.Windows.Forms.CheckBox();
            this.comboBoxSelectSport = new System.Windows.Forms.ComboBox();
            this.groupBoxAdherents = new System.Windows.Forms.GroupBox();
            this.LblMaj = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.LblNom = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblAdherent = new System.Windows.Forms.Label();
            this.comboBoxAdherent = new System.Windows.Forms.ComboBox();
            this.LblSports = new System.Windows.Forms.Label();
            this.groupBoxSaisieSport.SuspendLayout();
            this.groupBoxListeSport.SuspendLayout();
            this.groupBoxListeBddSport.SuspendLayout();
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
            this.BtnQuitter.Location = new System.Drawing.Point(67, 538);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(673, 39);
            this.BtnQuitter.TabIndex = 2;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // groupBoxListeBddSport
            // 
            this.groupBoxListeBddSport.Controls.Add(this.CkcSelectAllBdd);
            this.groupBoxListeBddSport.Location = new System.Drawing.Point(498, 12);
            this.groupBoxListeBddSport.Name = "groupBoxListeBddSport";
            this.groupBoxListeBddSport.Size = new System.Drawing.Size(290, 225);
            this.groupBoxListeBddSport.TabIndex = 3;
            this.groupBoxListeBddSport.TabStop = false;
            this.groupBoxListeBddSport.Text = "Sports Base de données";
            // 
            // CkcSelectAllBdd
            // 
            this.CkcSelectAllBdd.AutoSize = true;
            this.CkcSelectAllBdd.Location = new System.Drawing.Point(6, 199);
            this.CkcSelectAllBdd.Name = "CkcSelectAllBdd";
            this.CkcSelectAllBdd.Size = new System.Drawing.Size(108, 17);
            this.CkcSelectAllBdd.TabIndex = 1;
            this.CkcSelectAllBdd.Text = "Tout sélectionner";
            this.CkcSelectAllBdd.UseVisualStyleBackColor = true;
            this.CkcSelectAllBdd.CheckedChanged += new System.EventHandler(this.CkcSelectAllBdd_CheckedChanged);
            // 
            // comboBoxSelectSport
            // 
            this.comboBoxSelectSport.FormattingEnabled = true;
            this.comboBoxSelectSport.Location = new System.Drawing.Point(55, 32);
            this.comboBoxSelectSport.Name = "comboBoxSelectSport";
            this.comboBoxSelectSport.Size = new System.Drawing.Size(181, 21);
            this.comboBoxSelectSport.TabIndex = 4;
            this.comboBoxSelectSport.Text = "-- Sélectionnez --";
            this.comboBoxSelectSport.TextChanged += new System.EventHandler(this.comboBoxSelectSport_TextChanged);
            this.comboBoxSelectSport.Click += new System.EventHandler(this.comboBoxSelectSport_Click);
            // 
            // groupBoxAdherents
            // 
            this.groupBoxAdherents.Controls.Add(this.LblMaj);
            this.groupBoxAdherents.Controls.Add(this.LblMail);
            this.groupBoxAdherents.Controls.Add(this.LblPrenom);
            this.groupBoxAdherents.Controls.Add(this.LblNom);
            this.groupBoxAdherents.Controls.Add(this.LblId);
            this.groupBoxAdherents.Controls.Add(this.BtnModifier);
            this.groupBoxAdherents.Controls.Add(this.TxtMail);
            this.groupBoxAdherents.Controls.Add(this.TxtPrenom);
            this.groupBoxAdherents.Controls.Add(this.TxtNom);
            this.groupBoxAdherents.Controls.Add(this.TxtId);
            this.groupBoxAdherents.Controls.Add(this.LblAdherent);
            this.groupBoxAdherents.Controls.Add(this.comboBoxAdherent);
            this.groupBoxAdherents.Controls.Add(this.LblSports);
            this.groupBoxAdherents.Controls.Add(this.comboBoxSelectSport);
            this.groupBoxAdherents.Location = new System.Drawing.Point(67, 319);
            this.groupBoxAdherents.Name = "groupBoxAdherents";
            this.groupBoxAdherents.Size = new System.Drawing.Size(673, 213);
            this.groupBoxAdherents.TabIndex = 5;
            this.groupBoxAdherents.TabStop = false;
            this.groupBoxAdherents.Text = "Adhérents";
            // 
            // LblMaj
            // 
            this.LblMaj.AutoSize = true;
            this.LblMaj.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblMaj.Location = new System.Drawing.Point(265, 40);
            this.LblMaj.Name = "LblMaj";
            this.LblMaj.Size = new System.Drawing.Size(149, 13);
            this.LblMaj.TabIndex = 17;
            this.LblMaj.Text = "Changements pris en comptes";
            this.LblMaj.Visible = false;
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(18, 155);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(26, 13);
            this.LblMail.TabIndex = 16;
            this.LblMail.Text = "Mail";
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Location = new System.Drawing.Point(6, 132);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(43, 13);
            this.LblPrenom.TabIndex = 15;
            this.LblPrenom.Text = "Prénom";
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(15, 106);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(29, 13);
            this.LblNom.TabIndex = 14;
            this.LblNom.Text = "Nom";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(28, 80);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(16, 13);
            this.LblId.TabIndex = 13;
            this.LblId.Text = "Id";
            // 
            // BtnModifier
            // 
            this.BtnModifier.Location = new System.Drawing.Point(296, 181);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(75, 23);
            this.BtnModifier.TabIndex = 12;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(55, 155);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(570, 20);
            this.TxtMail.TabIndex = 11;
            this.TxtMail.TextChanged += new System.EventHandler(this.TxtMail_TextChanged);
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Location = new System.Drawing.Point(55, 129);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(570, 20);
            this.TxtPrenom.TabIndex = 10;
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(55, 103);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(570, 20);
            this.TxtNom.TabIndex = 9;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(55, 77);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(570, 20);
            this.TxtId.TabIndex = 8;
            // 
            // LblAdherent
            // 
            this.LblAdherent.AutoSize = true;
            this.LblAdherent.Location = new System.Drawing.Point(497, 18);
            this.LblAdherent.Name = "LblAdherent";
            this.LblAdherent.Size = new System.Drawing.Size(55, 13);
            this.LblAdherent.TabIndex = 7;
            this.LblAdherent.Text = "Adhérents";
            // 
            // comboBoxAdherent
            // 
            this.comboBoxAdherent.FormattingEnabled = true;
            this.comboBoxAdherent.Location = new System.Drawing.Point(444, 32);
            this.comboBoxAdherent.Name = "comboBoxAdherent";
            this.comboBoxAdherent.Size = new System.Drawing.Size(181, 21);
            this.comboBoxAdherent.TabIndex = 6;
            this.comboBoxAdherent.Text = "-- Sélectionnez --";
            this.comboBoxAdherent.SelectedValueChanged += new System.EventHandler(this.comboBoxAdherent_SelectedValueChanged);
            this.comboBoxAdherent.TextChanged += new System.EventHandler(this.comboBoxAdherent_TextChanged);
            this.comboBoxAdherent.Click += new System.EventHandler(this.comboBoxAdherent_Click);
            // 
            // LblSports
            // 
            this.LblSports.AutoSize = true;
            this.LblSports.Location = new System.Drawing.Point(112, 16);
            this.LblSports.Name = "LblSports";
            this.LblSports.Size = new System.Drawing.Size(37, 13);
            this.LblSports.TabIndex = 5;
            this.LblSports.Text = "Sports";
            // 
            // FrmSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupBoxAdherents);
            this.Controls.Add(this.groupBoxListeBddSport);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.groupBoxListeSport);
            this.Controls.Add(this.groupBoxSaisieSport);
            this.Name = "FrmSport";
            this.Text = "FrmSport";
            this.Load += new System.EventHandler(this.FrmSport_Load);
            this.groupBoxSaisieSport.ResumeLayout(false);
            this.groupBoxSaisieSport.PerformLayout();
            this.groupBoxListeSport.ResumeLayout(false);
            this.groupBoxListeSport.PerformLayout();
            this.groupBoxListeBddSport.ResumeLayout(false);
            this.groupBoxListeBddSport.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxListeBddSport;
        private System.Windows.Forms.CheckBox CkcSelectAllBdd;
        private System.Windows.Forms.ComboBox comboBoxSelectSport;
        private System.Windows.Forms.GroupBox groupBoxAdherents;
        private System.Windows.Forms.Label LblSports;
        private System.Windows.Forms.Label LblAdherent;
        private System.Windows.Forms.ComboBox comboBoxAdherent;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label LblPrenom;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.CheckBox CkcSelectAll;
        private System.Windows.Forms.Label LblMaj;
    }
}

