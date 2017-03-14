using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrinceIgor
{
    public partial class frmAddSquadForm : Form
    {
        public Squads SquadInfo { get; set; }

        public frmAddSquadForm()
        {
            InitializeComponent();
        }

        private void btnAddSquad_Click(object sender, EventArgs e)
        {
            SquadInfo.SingleSquadName = txbSquadName.Text;
        }
    }
}
