
namespace FrmSport
{
    partial class Form1
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
            this.BtnAjouterSport = new System.Windows.Forms.Button();
            this.TxtSaisieSport = new System.Windows.Forms.TextBox();
            this.groupBoxListeSport = new System.Windows.Forms.GroupBox();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.groupBoxSaisieSport.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSaisieSport
            // 
            this.groupBoxSaisieSport.Controls.Add(this.TxtSaisieSport);
            this.groupBoxSaisieSport.Controls.Add(this.BtnAjouterSport);
            this.groupBoxSaisieSport.Location = new System.Drawing.Point(259, 394);
            this.groupBoxSaisieSport.Name = "groupBoxSaisieSport";
            this.groupBoxSaisieSport.Size = new System.Drawing.Size(290, 44);
            this.groupBoxSaisieSport.TabIndex = 0;
            this.groupBoxSaisieSport.TabStop = false;
            this.groupBoxSaisieSport.Text = "Saisie d\'un sport";
            // 
            // BtnAjouterSport
            // 
            this.BtnAjouterSport.Location = new System.Drawing.Point(209, 15);
            this.BtnAjouterSport.Name = "BtnAjouterSport";
            this.BtnAjouterSport.Size = new System.Drawing.Size(75, 23);
            this.BtnAjouterSport.TabIndex = 0;
            this.BtnAjouterSport.Text = "Ajouter";
            this.BtnAjouterSport.UseVisualStyleBackColor = true;
            // 
            // TxtSaisieSport
            // 
            this.TxtSaisieSport.Location = new System.Drawing.Point(6, 17);
            this.TxtSaisieSport.Name = "TxtSaisieSport";
            this.TxtSaisieSport.Size = new System.Drawing.Size(197, 20);
            this.TxtSaisieSport.TabIndex = 1;
            // 
            // groupBoxListeSport
            // 
            this.groupBoxListeSport.Location = new System.Drawing.Point(259, 124);
            this.groupBoxListeSport.Name = "groupBoxListeSport";
            this.groupBoxListeSport.Size = new System.Drawing.Size(290, 222);
            this.groupBoxListeSport.TabIndex = 1;
            this.groupBoxListeSport.TabStop = false;
            this.groupBoxListeSport.Text = "Sports";
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(564, 408);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(75, 23);
            this.BtnQuitter.TabIndex = 2;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.groupBoxListeSport);
            this.Controls.Add(this.groupBoxSaisieSport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxSaisieSport.ResumeLayout(false);
            this.groupBoxSaisieSport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSaisieSport;
        private System.Windows.Forms.TextBox TxtSaisieSport;
        private System.Windows.Forms.Button BtnAjouterSport;
        private System.Windows.Forms.GroupBox groupBoxListeSport;
        private System.Windows.Forms.Button BtnQuitter;
    }
}

