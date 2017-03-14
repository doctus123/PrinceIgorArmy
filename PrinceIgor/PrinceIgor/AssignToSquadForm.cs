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
    public partial class frmAssignToSquadForm : Form
    {
        public Squads SquadInfo { get; set; }

        public frmAssignToSquadForm()
        {
            InitializeComponent();
                          
        }

        

        private void btnAssingToSquad_Click(object sender, EventArgs e)
        {
            SquadInfo.SingleSquadName = lbxSquads.SelectedItem.ToString();
        }

        private void frmAssignToSquad_Load(object sender, EventArgs e)
        {
            foreach (var squadName in SquadInfo.SquadsList)
                lbxSquads.Items.Add(squadName);

        }
    }
}
