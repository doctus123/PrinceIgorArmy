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
    public partial class frmAddContributionForm : Form
    {
        public Contribution ContributionInfo { get; set; }

        public frmAddContributionForm()
        {
            InitializeComponent();
        }

        private void btnAddContribution_Click(object sender, EventArgs e)
        {
            ContributionInfo.ContributionText = rtxbContribution.Text;
        }
    }
}
