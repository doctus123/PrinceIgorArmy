using MySql.Data.MySqlClient;
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
    public partial class PrinceIgorForm : Form
    {
        public Squads SquadsInfo { get; set; }

        public PrinceIgorForm()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection();


        private void btnConnectDB_Click(object sender, EventArgs e)
        {
            ConnectDB();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseDBConnection();
        }


        private void dgvWarriors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbxContributions.Items.Clear();
            lbxSquads.Items.Clear();
            btnAssagnToSquad.Enabled = true;
            btnAddContribution.Enabled = true;
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                RefreshContributions();
                RefreshWarriorsSquads();

            }
        }

        private void btnAddWarrior_Click(object sender, EventArgs e)
        {
            AddWarrior();

        }



        private void btnAddContribution_Click(object sender, EventArgs e)
        {
            AddContribution();
            
        }

        
        private void btnAssagnToSquad_Click(object sender, EventArgs e)
        {
            AssignToSquad();
        }

        private void btnAddSquad_Click(object sender, EventArgs e)
        {
            AddSquad();
        }

        private void btnDeleteSquad_Click(object sender, EventArgs e)
        {
            DeleteSquad();
            RefreshSquads();
            RefreshWarriorsInSquad();
            RefreshSlaveSquads();
            RefreshMasterSquads();

        }

        private void btnAddMasterSquad_Click(object sender, EventArgs e)
        {
            AddMasterSquad();
        }


        private void btnAddSlaveSquad_Click(object sender, EventArgs e)
        {
            AddSlaveSquad();
        }

        private void dgvSquads_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddMasterSquad.Enabled = true;
            btnAddSlaveSquad.Enabled = true;
            btnDeleteSquad.Enabled = true;
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                RefreshSlaveSquads();
                RefreshMasterSquads();
                RefreshWarriorsInSquad();
            }
        }

        private void ConnectDB()
        {
            btnClose.Enabled = true;
            btnConnectDB.Enabled = false;
            string myConnectionString;
            string dBName = txbDBName.Text;

            myConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=;database=" + dBName + ";";

            lblConnectionStatus.Text = "Connected";
            lblConnectionStatus.ForeColor = Color.Green;

            try
            {
                connection.ConnectionString = myConnectionString;
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            RefreshWorriors();
            RefreshSquads();
        }

        private void CloseDBConnection()
        {
            connection.Close();
            btnClose.Enabled = false;
            btnConnectDB.Enabled = true;
            lblConnectionStatus.Text = "Disconnected";
            lblConnectionStatus.ForeColor = Color.Red;
        }

        private void AddWarrior()
        {
            using (frmAddWarriorForm frm = new frmAddWarriorForm() { WarriorInfo = new Warrior() })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO Warriors (name, alive, gold) VALUES (\"" + frm.WarriorInfo.Name + "\", TRUE, 0)";
                    MySqlDataReader Reader = command.ExecuteReader();
                    Reader.Close();
                    RefreshWorriors();

                }
            }
        }

        private void AddSquad()
        {
            using (frmAddSquadForm frm = new frmAddSquadForm() { SquadInfo = new Squads() })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO Squads (name) VALUES (\"" + frm.SquadInfo.SingleSquadName + "\")";
                    MySqlDataReader SquadReader = command.ExecuteReader();
                    SquadReader.Close();

                }
            }
            RefreshSquads();
        }

        private void AddMasterSquad()
        {
            int selectedrowindex = dgvSquads.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSquads.Rows[selectedrowindex];
            string squadId = Convert.ToString(selectedRow.Cells[0].Value);
            List<string> squadsList = new List<string>();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT name FROM Squads";
            MySqlDataReader SquadsReader = command.ExecuteReader();
            while (SquadsReader.Read())
            {
                if (!SquadsReader.IsDBNull(0))
                {
                    squadsList.Add((string)SquadsReader["name"]);

                }
            }
            SquadsReader.Close();
            using (frmAssignToSquadForm frm = new frmAssignToSquadForm() { SquadInfo = new Squads() })
            {
                frm.SquadInfo.SquadsList = squadsList;
                frm.Text = "Add Master Squad";
                btnAssagnToSquad.Text = "Add Master Squad";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    command.CommandText = "INSERT INTO Squads_membership (id_master_squad, id_slave_squad) " +
                        "VALUES ((SELECT id_squads FROM Squads WHERE name = \"" + frm.SquadInfo.SingleSquadName + "\"), " + squadId + ")";
                    MySqlDataReader Reader = command.ExecuteReader();
                    Reader.Close();
                }
            }
            RefreshMasterSquads();
        }

        private void AssignToSquad()
        {
            int selectedrowindex = dgvWarriors.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvWarriors.Rows[selectedrowindex];
            string warriorId = Convert.ToString(selectedRow.Cells[0].Value);
            List<string> squadsList = new List<string>();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT name FROM Squads";
            MySqlDataReader SquadsReader = command.ExecuteReader();
            while (SquadsReader.Read())
            {
                if (!SquadsReader.IsDBNull(0))
                {
                    squadsList.Add((string)SquadsReader["name"]);

                }
            }
            SquadsReader.Close();
            using (frmAssignToSquadForm frm = new frmAssignToSquadForm() { SquadInfo = new Squads() })
            {
                frm.SquadInfo.SquadsList = squadsList;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    command.CommandText = "INSERT INTO Warriors_membership (id_warriors, id_squads) " +
                        "VALUES (" + warriorId + ", (SELECT id_squads FROM Squads WHERE name = \"" + frm.SquadInfo.SingleSquadName + "\"))";
                    MySqlDataReader Reader = command.ExecuteReader();
                    Reader.Close();
                }
            }
            RefreshWarriorsSquads();
        }

        private void AddSlaveSquad()
        {
            int selectedrowindex = dgvSquads.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSquads.Rows[selectedrowindex];
            string squadId = Convert.ToString(selectedRow.Cells[0].Value);
            List<string> squadsList = new List<string>();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT name FROM Squads";
            MySqlDataReader SquadsReader = command.ExecuteReader();
            while (SquadsReader.Read())
            {
                if (!SquadsReader.IsDBNull(0))
                {
                    squadsList.Add((string)SquadsReader["name"]);

                }
            }
            SquadsReader.Close();
            using (frmAssignToSquadForm frm = new frmAssignToSquadForm() { SquadInfo = new Squads() })
            {
                frm.SquadInfo.SquadsList = squadsList;
                frm.Text = "Add Slave Squad";
                btnAssagnToSquad.Text = "Add Slave Squad";
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    command.CommandText = "INSERT INTO Squads_membership (id_master_squad, id_slave_squad) " +
                        "VALUES (" + squadId + ", (SELECT id_squads FROM Squads WHERE name = \"" + frm.SquadInfo.SingleSquadName + "\"))";
                    MySqlDataReader Reader = command.ExecuteReader();
                    Reader.Close();
                }
            }
            RefreshSlaveSquads();
        }


        private void RefreshWarriorsInSquad()
        {
            dgvWarriorsInSquad.Rows.Clear();
            MySqlCommand command = connection.CreateCommand();
            int selectedrowindex = dgvSquads.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSquads.Rows[selectedrowindex];
            command.CommandText = "SELECT * FROM Warriors WHERE id_warriors IN (SELECT id_warriors FROM Warriors_membership WHERE id_squads = " + Convert.ToString(selectedRow.Cells[0].Value) + ")";
            MySqlDataReader WarriorsReader = command.ExecuteReader();
            while (WarriorsReader.Read())
            {
                if (!WarriorsReader.IsDBNull(0))

                    dgvWarriorsInSquad.Rows.Add((int)WarriorsReader["id_warriors"], (string)WarriorsReader["name"]);
            }
            WarriorsReader.Close();
        }

        private void RefreshMasterSquads()
        {
            lbxMasterSquads.Items.Clear();
            MySqlCommand command = connection.CreateCommand();
            int selectedrowindex = dgvSquads.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSquads.Rows[selectedrowindex];
            command.CommandText = "SELECT name FROM Squads WHERE id_squads IN (SELECT id_slave_squad FROM Squads_membership WHERE id_master_squad = " + Convert.ToString(selectedRow.Cells[0].Value) + ")";
            MySqlDataReader SquadsReader = command.ExecuteReader();
            while (SquadsReader.Read())
            {
                if (!SquadsReader.IsDBNull(0))

                    lbxMasterSquads.Items.Add((string)SquadsReader["name"]);
            }
            SquadsReader.Close();
        }

        private void RefreshSlaveSquads()
        {
            lbxSlaveSquads.Items.Clear();
            MySqlCommand command = connection.CreateCommand();
            int selectedrowindex = dgvSquads.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSquads.Rows[selectedrowindex];
            command.CommandText = "SELECT name FROM Squads WHERE id_squads IN (SELECT id_master_squad FROM Squads_membership WHERE id_slave_squad = " + Convert.ToString(selectedRow.Cells[0].Value) + ")";
            MySqlDataReader SquadsReader = command.ExecuteReader();
            while (SquadsReader.Read())
            {
                if (!SquadsReader.IsDBNull(0))

                    lbxSlaveSquads.Items.Add((string)SquadsReader["name"]);
            }
            SquadsReader.Close();
        }

        private void RefreshSquads()
        {
            dgvSquads.Rows.Clear();
            try
            {
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Squads";
                MySqlDataReader SquadsReader = command.ExecuteReader();
                while (SquadsReader.Read())
                {
                    if (!SquadsReader.IsDBNull(0))

                        dgvSquads.Rows.Add((int)SquadsReader["id_squads"], (string)SquadsReader["name"]);
                }
                SquadsReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void RefreshWorriors()
        {
            dgvWarriors.Rows.Clear();
            try
            {
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Warriors";
                MySqlDataReader WarriorsReader = command.ExecuteReader();
                while (WarriorsReader.Read())
                {
                    if (!WarriorsReader.IsDBNull(0))

                        dgvWarriors.Rows.Add((int)WarriorsReader["id_warriors"], (string)WarriorsReader["name"], (bool)WarriorsReader["alive"], (int)WarriorsReader["gold"]);
                }
                WarriorsReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddContribution()
        {
            int selectedrowindex = dgvWarriors.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvWarriors.Rows[selectedrowindex];
            string warriorId = Convert.ToString(selectedRow.Cells[0].Value);
            using (frmAddContributionForm frm = new frmAddContributionForm() { ContributionInfo = new Contribution() })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO Contributions (id_warriors, contribution) VALUES (" + warriorId + ", \"" + frm.ContributionInfo.ContributionText + "\")";
                    MySqlDataReader Reader = command.ExecuteReader();
                    Reader.Close();
                }
            }
            RefreshContributions();
        }

        private void RefreshWarriorsSquads()
        {
            MySqlCommand command = connection.CreateCommand();
            int selectedrowindex = dgvWarriors.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvWarriors.Rows[selectedrowindex];
            command.CommandText = "SELECT name FROM Squads WHERE id_squads IN (SELECT id_squads FROM Warriors_membership WHERE id_warriors = " + Convert.ToString(selectedRow.Cells[0].Value) + ")";
            MySqlDataReader SquadsReader = command.ExecuteReader();
            while (SquadsReader.Read())
            {
                if (!SquadsReader.IsDBNull(0))

                    lbxSquads.Items.Add((string)SquadsReader["name"]);
            }
            SquadsReader.Close();
        }

        private void RefreshContributions()
        {
            MySqlCommand command = connection.CreateCommand();
            int selectedrowindex = dgvWarriors.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvWarriors.Rows[selectedrowindex];
            command.CommandText = "SELECT contribution FROM Contributions WHERE id_warriors = " + Convert.ToString(selectedRow.Cells[0].Value);
            MySqlDataReader ContributionsReader = command.ExecuteReader();
            while (ContributionsReader.Read())
            {
                if (!ContributionsReader.IsDBNull(0))

                    lbxContributions.Items.Add((string)ContributionsReader["contribution"]);
            }
            ContributionsReader.Close();
        }

        private void DeleteSquad()
        {
            MySqlCommand command = connection.CreateCommand();
            int selectedrowindex = dgvSquads.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSquads.Rows[selectedrowindex];
            string squadId = Convert.ToString(selectedRow.Cells[0].Value);
            command.CommandText = "DELETE FROM Warriors_membership WHERE id_squads  = " + squadId;
            MySqlDataReader SquadReader = command.ExecuteReader();
            SquadReader.Close();
            command.CommandText = "DELETE FROM Squads_membership WHERE id_master_squad  = " + squadId + " OR id_slave_squad = " + squadId;
            SquadReader = command.ExecuteReader();
            SquadReader.Close();
            command.CommandText = "DELETE FROM Squads WHERE id_squads  = " + squadId;
            SquadReader = command.ExecuteReader();
            SquadReader.Close();
        }


    }
}

