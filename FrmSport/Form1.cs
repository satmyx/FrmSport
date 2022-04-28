using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
        }
    }
}
