
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
            this.groupBoxSaisieSport.SuspendLayout();
            this.groupBoxListeSport.SuspendLayout();
            this.groupBoxListeBddSport.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSaisieSport
            // 
            this.groupBoxSaisieSport.Controls.Add(this.TxtSport);
            this.groupBoxSaisieSport.Controls.Add(this.BtnAjouterSport);
            this.groupBoxSaisieSport.Location = new System.Drawing.Point(259, 394);
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
            this.groupBoxListeSport.Location = new System.Drawing.Point(12, 124);
            this.groupBoxListeSport.Name = "groupBoxListeSport";
            this.groupBoxListeSport.Size = new System.Drawing.Size(290, 222);
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
            this.BtnQuitter.Location = new System.Drawing.Point(564, 408);
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
            this.groupBoxListeBddSport.Location = new System.Drawing.Point(498, 124);
            this.groupBoxListeBddSport.Name = "groupBoxListeBddSport";
            this.groupBoxListeBddSport.Size = new System.Drawing.Size(290, 222);
            this.groupBoxListeBddSport.TabIndex = 3;
            this.groupBoxListeBddSport.TabStop = false;
            this.groupBoxListeBddSport.Text = "Sports Base de données";
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
            // FrmSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxListeBddSport);
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
    }
}

