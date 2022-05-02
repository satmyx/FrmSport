using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrmSport.ClassesTechniques;
using System.Windows.Forms;

namespace FrmSport
{
    public partial class FrmSport : Form
    {
        /// <summary>
        /// Initialise les compositon du winform.
        /// </summary>
        public FrmSport()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Permet de quitter l'application.
        /// </summary>
        /// <param name="sender">Envoie.</param>
        /// <param name="e">Représente la classe de base pour les classes qui contiennent des données d’événement.</param>
        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Permet de vérifier si la taille du nom du sport est supérieur a 2.
        /// </summary>
        /// <param name="sender">Envoie.</param>
        /// <param name="e">Représente la classe de base pour les classes qui contiennent des données d’événement.</param>
        private void TxtSport_TextChanged(object sender, EventArgs e)
        {
            if (TxtSport.TextLength > 2)
            {
                this.BtnAjouterSport.Enabled = true;
            }
            else
            {
                this.BtnAjouterSport.Enabled = false;
            }
        }

        /// <summary>
        /// Permet d'ajouter des sports dans la groupbox liste sport.
        /// </summary>
        /// <param name="sender">Envoie.</param>
        /// <param name="e">Représente la classe de base pour les classes qui contiennent des données d’événement.</param>
        private void BtnAjouterSport_Click(object sender, EventArgs e)
        {
            var nomBouton = "Ckc" + TxtSport.Text;
            CheckBox checkbox = new CheckBox();
            this.groupBoxListeSport.Controls.Add(checkbox);
            checkbox.Name = nomBouton;
            checkbox.Text = TxtSport.Text;
            checkbox.Location = new Point(37, 20 * (this.groupBoxListeSport.Controls.Count));
            checkbox.Size = new System.Drawing.Size(80, 17);
            MessageBox.Show(TxtSport.Text + " Ajouté");

            if (this.groupBoxListeSport.Controls.Count == 6)
            {
                this.BtnAjouterSport.Enabled = false;
            }
        }

        /// <summary>
        /// Permet de sélectionner tout les sports ajouter.
        /// </summary>
        /// <param name="sender">Envoie.</param>
        /// <param name="e">Représente la classe de base pour les classes qui contiennent des données d’événement.</param>
        private void CkcSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach(Control unControle in groupBoxListeSport.Controls)
            {
                ((CheckBox)unControle).Checked = CkcSelectAll.Checked;
            }
        }

        /// <summary>
        /// Permet d'obtenir tout les sports disponible sur la bdd et les mettre dans la comboboxselectsport.
        /// </summary>
        /// <param name="sender">Envoie.</param>
        /// <param name="e">Représente la classe de base pour les classes qui contiennent des données d’événement.</param>
        private void comboBoxSelectSport_Click(object sender, EventArgs e)
        {
            Bdd bddmysql = Bdd.getInstance(); bddmysql.Ouvrir();
            DataTable table = new DataTable();
            table.Load(bddmysql.GetSports());
            this.comboBoxSelectSport.DataSource = table;
            this.comboBoxSelectSport.ValueMember = "id";
            this.comboBoxSelectSport.DisplayMember = "libelle";
            bddmysql.Fermer();
        }

        /// <summary>
        /// Méthode qui permet de remplir la comboboxadherent des pratiquant d'un sport.
        /// </summary>
        /// <param name="sender">Envoie.</param>
        /// <param name="e">Représente la classe de base pour les classes qui contiennent des données d’événement.</param>
        private void comboBoxAdherent_Click(object sender, EventArgs e)
        {
            Bdd bddmysql = Bdd.getInstance();
            bddmysql.Ouvrir();
            DataTable tableadherent = new DataTable();
            tableadherent.Load(bddmysql.GetAdherentBySport((int)this.comboBoxSelectSport.SelectedValue));
            this.comboBoxAdherent.ValueMember = "id";
            this.comboBoxAdherent.DisplayMember = "idNom";
            this.comboBoxAdherent.DataSource = tableadherent;
            bddmysql.Fermer();
        }

        /// <summary>
        /// Méthode permettant de remplir les textbox des informations adhérents. Via un DataRow.
        /// </summary>
        /// <param name="sender">Envoie.</param>
        /// <param name="e">Représente la classe de base pour les classes qui contiennent des données d’événement.</param>
        private void comboBoxAdherent_SelectedValueChanged(object sender, EventArgs e)
        {
            Bdd bddmysql = Bdd.getInstance();
            bddmysql.Ouvrir();
            DataTable tableinfoadherent = new DataTable();
            tableinfoadherent.Load(bddmysql.GetAdherentById(Convert.ToInt32(this.comboBoxAdherent.SelectedValue)));
            foreach (DataRow row in tableinfoadherent.Rows)
            {
                this.TxtId.Text = Convert.ToString(row["id"]);
                this.TxtNom.Text = (string)row["nom"];
                this.TxtPrenom.Text = (string)row["prenom"];
                this.TxtMail.Text = (string)row["mail"];
            }
            bddmysql.Fermer();
        }

        /// <summary>
        /// Permet de vérifier si le mail a obtenu une modification. Sinon le bouton est non disponible.
        /// </summary>
        /// <param name="sender">Envoie.</param>
        /// <param name="e">Représente la classe de base pour les classes qui contiennent des données d’événement.</param>
        private void TxtMail_TextChanged(object sender, EventArgs e)
        {
            if (this.TxtMail.Modified)
            {
                this.BtnModifier.Enabled = true;
            }
            else
            {
                this.BtnModifier.Enabled = false;
            }
        }

        /// <summary>
        /// Permet de modifier le mail d'un adhérent (Affiche aussi le Lbl mis a jour).
        /// </summary>
        /// <param name="sender">Envoie</param>
        /// <param name="e">Représente la classe de base pour les classes qui contiennent des données d’événement.</param>
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            Bdd bddmysql = Bdd.getInstance();
            bddmysql.Ouvrir();
            bddmysql.UpdateMail(Convert.ToInt32(this.TxtId.Text),this.TxtMail.Text);
            bddmysql.Fermer();
            this.LblMaj.Visible = true;
        }

        /// <summary>
        /// Permet de tout sélectioner dans la groupbox liste bdd sport.
        /// </summary>
        /// <param name="sender">Envoie.</param>
        /// <param name="e">Représente la classe de base pour les classes qui contiennent des données d’événement.</param>
        private void CkcSelectAllBdd_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control unControle in groupBoxListeBddSport.Controls)
            {
                ((CheckBox)unControle).Checked = CkcSelectAllBdd.Checked;
            }
        }

        /// <summary>
        /// Chargement des checkbox dans la liste sport de la bdd. 
        /// </summary>
        /// <param name="sender">Envoie.</param>
        /// <param name="e">Représente la classe de base pour les classes qui contiennent des données d’événement.</param>
        private void FrmSport_Load(object sender, EventArgs e)
        {
            Bdd bddmysql = Bdd.getInstance();
            bddmysql.Ouvrir();
            DataTable table = new DataTable();
            table.Load(bddmysql.GetSports());
            foreach (DataRow row in table.Rows)
            {
                CheckBox checkbox = new CheckBox();
                this.groupBoxListeBddSport.Controls.Add(checkbox);
                checkbox.Name = "Ckc" + (string)row["libelle"];
                checkbox.Text = (string)row["libelle"];
                checkbox.Location = new Point(37, 20 * (this.groupBoxListeBddSport.Controls.Count));
            }
            bddmysql.Fermer();
            this.comboBoxAdherent.Enabled = false;
            this.TxtId.Enabled = false;
            this.TxtMail.Enabled = false;
            this.TxtNom.Enabled = false;
            this.TxtPrenom.Enabled = false;
            this.BtnModifier.Enabled = false;
        }

        /// <summary>
        /// Au changement de text dans la comboboxadherent les infos adherents ne sont plus grisée. 
        /// </summary>
        /// <param name="sender">Envoie.</param>
        /// <param name="e">Représente la classe de base pour les classes qui contiennent des données d’événement.</param>
        private void comboBoxAdherent_TextChanged(object sender, EventArgs e)
        {
            this.TxtId.Enabled = true;
            this.TxtMail.Enabled = true;
            this.TxtNom.Enabled = true;
            this.TxtPrenom.Enabled = true;
            this.BtnModifier.Enabled = true;
        }

        /// <summary>
        /// Au changement de text dans la comboboxsport, la comboboxadherent n'est plus grisées.
        /// </summary>
        /// <param name="sender">Envoie.</param>
        /// <param name="e">Représente la classe de base pour les classes qui contiennent des données d’événement.</param>
        private void comboBoxSelectSport_TextChanged(object sender, EventArgs e)
        {
            this.comboBoxAdherent.Enabled = true;
        }
    }
}
