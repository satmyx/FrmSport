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
        public FrmSport()
        {
            InitializeComponent();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtSport_TextChanged(object sender, EventArgs e)
        {
            if (TxtSport.TextLength <= 2)
            {
                this.BtnAjouterSport.Enabled = false;
            }
            else
            {
                this.BtnAjouterSport.Enabled = true;
            }
        }

        private void BtnAjouterSport_Click(object sender, EventArgs e)
        {
            var nomBouton = "Ckc" + TxtSport.Text;
            CheckBox checkbox = new CheckBox();
            this.groupBoxListeSport.Controls.Add(checkbox);
            checkbox.Name = nomBouton;
            checkbox.Text = TxtSport.Text;
            checkbox.Location = new Point(37, 30 * (this.groupBoxListeSport.Controls.Count));
            checkbox.Size = new System.Drawing.Size(80, 17);
            MessageBox.Show(TxtSport.Text + " Ajouté");

            if (this.groupBoxListeSport.Controls.Count == 6)
            {
                this.BtnAjouterSport.Enabled = false;
            }
        }

        private void CkcSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach(Control unControle in groupBoxListeSport.Controls)
            {
                ((CheckBox)unControle).Checked = CkcSelectAll.Checked;
            }
        }

        private void groupBoxListeBddSport_Enter(object sender, EventArgs e)
        {
            // Pas encore
        }

        private void comboBoxSelectSport_Click(object sender, EventArgs e)
        {
            Bdd bddmysql = new Bdd();
            bddmysql.Ouvrir();
            bddmysql.GetSports();
            DataTable table = new DataTable();

            bddmysql.Fermer();
        }
    }
}
