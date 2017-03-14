namespace PrinceIgor
{
    partial class PrinceIgorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnectDB = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlConnection = new System.Windows.Forms.Panel();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpWarriors = new System.Windows.Forms.TabPage();
            this.pnlWarriorsButtons = new System.Windows.Forms.Panel();
            this.btnAssagnToSquad = new System.Windows.Forms.Button();
            this.btnAddContribution = new System.Windows.Forms.Button();
            this.btnAddWarrior = new System.Windows.Forms.Button();
            this.pnlTabWarriors = new System.Windows.Forms.Panel();
            this.pnlWarriorsView = new System.Windows.Forms.Panel();
            this.lblWarriors = new System.Windows.Forms.Label();
            this.dgvWarriors = new System.Windows.Forms.DataGridView();
            this.colWarriorsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarriorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsAlive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContributionsAndSquads = new System.Windows.Forms.Panel();
            this.pnlSquads = new System.Windows.Forms.Panel();
            this.lblSquads = new System.Windows.Forms.Label();
            this.lbxSquads = new System.Windows.Forms.ListBox();
            this.pnlContributions = new System.Windows.Forms.Panel();
            this.lblContributions = new System.Windows.Forms.Label();
            this.lbxContributions = new System.Windows.Forms.ListBox();
            this.tabSquads = new System.Windows.Forms.TabPage();
            this.pnlSquadButtons = new System.Windows.Forms.Panel();
            this.btnAddSlaveSquad = new System.Windows.Forms.Button();
            this.btnAddMasterSquad = new System.Windows.Forms.Button();
            this.btnDeleteSquad = new System.Windows.Forms.Button();
            this.btnAddSquad = new System.Windows.Forms.Button();
            this.pnlTabSquad = new System.Windows.Forms.Panel();
            this.pnlSquadsView = new System.Windows.Forms.Panel();
            this.pnlSquadsWithWarriors = new System.Windows.Forms.Panel();
            this.dgvWarriorsInSquad = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWarriorsFromSquad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSquads = new System.Windows.Forms.DataGridView();
            this.colSquadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSquadName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSquadList = new System.Windows.Forms.Label();
            this.pnlMasterAndSlaveSquads = new System.Windows.Forms.Panel();
            this.pnlMasterSquads = new System.Windows.Forms.Panel();
            this.lblMasterSquads = new System.Windows.Forms.Label();
            this.lbxMasterSquads = new System.Windows.Forms.ListBox();
            this.pnlSlaveSquads = new System.Windows.Forms.Panel();
            this.lblSlaveSquads = new System.Windows.Forms.Label();
            this.lbxSlaveSquads = new System.Windows.Forms.ListBox();
            this.txbDBName = new System.Windows.Forms.TextBox();
            this.lblDBName = new System.Windows.Forms.Label();
            this.pnlConnection.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpWarriors.SuspendLayout();
            this.pnlWarriorsButtons.SuspendLayout();
            this.pnlTabWarriors.SuspendLayout();
            this.pnlWarriorsView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarriors)).BeginInit();
            this.pnlContributionsAndSquads.SuspendLayout();
            this.pnlSquads.SuspendLayout();
            this.pnlContributions.SuspendLayout();
            this.tabSquads.SuspendLayout();
            this.pnlSquadButtons.SuspendLayout();
            this.pnlTabSquad.SuspendLayout();
            this.pnlSquadsView.SuspendLayout();
            this.pnlSquadsWithWarriors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarriorsInSquad)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSquads)).BeginInit();
            this.pnlMasterAndSlaveSquads.SuspendLayout();
            this.pnlMasterSquads.SuspendLayout();
            this.pnlSlaveSquads.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnectDB
            // 
            this.btnConnectDB.Location = new System.Drawing.Point(268, 12);
            this.btnConnectDB.Name = "btnConnectDB";
            this.btnConnectDB.Size = new System.Drawing.Size(75, 21);
            this.btnConnectDB.TabIndex = 0;
            this.btnConnectDB.Text = "Connect DB";
            this.btnConnectDB.UseVisualStyleBackColor = true;
            this.btnConnectDB.Click += new System.EventHandler(this.btnConnectDB_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(268, 41);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 21);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close Connection";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlConnection
            // 
            this.pnlConnection.Controls.Add(this.lblDBName);
            this.pnlConnection.Controls.Add(this.txbDBName);
            this.pnlConnection.Controls.Add(this.lblConnectionStatus);
            this.pnlConnection.Controls.Add(this.btnConnectDB);
            this.pnlConnection.Controls.Add(this.btnClose);
            this.pnlConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConnection.Location = new System.Drawing.Point(0, 0);
            this.pnlConnection.Name = "pnlConnection";
            this.pnlConnection.Size = new System.Drawing.Size(784, 75);
            this.pnlConnection.TabIndex = 3;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus.Location = new System.Drawing.Point(436, 7);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(316, 55);
            this.lblConnectionStatus.TabIndex = 3;
            this.lblConnectionStatus.Text = "Disconnected";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 367);
            this.panel2.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpWarriors);
            this.tabControl1.Controls.Add(this.tabSquads);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 367);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpWarriors
            // 
            this.tbpWarriors.Controls.Add(this.pnlWarriorsButtons);
            this.tbpWarriors.Controls.Add(this.pnlTabWarriors);
            this.tbpWarriors.Location = new System.Drawing.Point(4, 22);
            this.tbpWarriors.Name = "tbpWarriors";
            this.tbpWarriors.Padding = new System.Windows.Forms.Padding(3);
            this.tbpWarriors.Size = new System.Drawing.Size(776, 341);
            this.tbpWarriors.TabIndex = 0;
            this.tbpWarriors.Text = "Warriors";
            this.tbpWarriors.UseVisualStyleBackColor = true;
            // 
            // pnlWarriorsButtons
            // 
            this.pnlWarriorsButtons.Controls.Add(this.btnAssagnToSquad);
            this.pnlWarriorsButtons.Controls.Add(this.btnAddContribution);
            this.pnlWarriorsButtons.Controls.Add(this.btnAddWarrior);
            this.pnlWarriorsButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWarriorsButtons.Location = new System.Drawing.Point(3, 277);
            this.pnlWarriorsButtons.Name = "pnlWarriorsButtons";
            this.pnlWarriorsButtons.Size = new System.Drawing.Size(770, 61);
            this.pnlWarriorsButtons.TabIndex = 5;
            // 
            // btnAssagnToSquad
            // 
            this.btnAssagnToSquad.Enabled = false;
            this.btnAssagnToSquad.Location = new System.Drawing.Point(208, 6);
            this.btnAssagnToSquad.Name = "btnAssagnToSquad";
            this.btnAssagnToSquad.Size = new System.Drawing.Size(94, 50);
            this.btnAssagnToSquad.TabIndex = 2;
            this.btnAssagnToSquad.Text = "Assign to Squad";
            this.btnAssagnToSquad.UseVisualStyleBackColor = true;
            this.btnAssagnToSquad.Click += new System.EventHandler(this.btnAssagnToSquad_Click);
            // 
            // btnAddContribution
            // 
            this.btnAddContribution.Enabled = false;
            this.btnAddContribution.Location = new System.Drawing.Point(96, 6);
            this.btnAddContribution.Name = "btnAddContribution";
            this.btnAddContribution.Size = new System.Drawing.Size(94, 50);
            this.btnAddContribution.TabIndex = 1;
            this.btnAddContribution.Text = "Add Contribution";
            this.btnAddContribution.UseVisualStyleBackColor = true;
            this.btnAddContribution.Click += new System.EventHandler(this.btnAddContribution_Click);
            // 
            // btnAddWarrior
            // 
            this.btnAddWarrior.Location = new System.Drawing.Point(5, 6);
            this.btnAddWarrior.Name = "btnAddWarrior";
            this.btnAddWarrior.Size = new System.Drawing.Size(75, 50);
            this.btnAddWarrior.TabIndex = 0;
            this.btnAddWarrior.Text = "Add Warrior";
            this.btnAddWarrior.UseVisualStyleBackColor = true;
            this.btnAddWarrior.Click += new System.EventHandler(this.btnAddWarrior_Click);
            // 
            // pnlTabWarriors
            // 
            this.pnlTabWarriors.Controls.Add(this.pnlWarriorsView);
            this.pnlTabWarriors.Controls.Add(this.pnlContributionsAndSquads);
            this.pnlTabWarriors.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabWarriors.Location = new System.Drawing.Point(3, 3);
            this.pnlTabWarriors.Name = "pnlTabWarriors";
            this.pnlTabWarriors.Size = new System.Drawing.Size(770, 274);
            this.pnlTabWarriors.TabIndex = 4;
            // 
            // pnlWarriorsView
            // 
            this.pnlWarriorsView.Controls.Add(this.lblWarriors);
            this.pnlWarriorsView.Controls.Add(this.dgvWarriors);
            this.pnlWarriorsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWarriorsView.Location = new System.Drawing.Point(0, 0);
            this.pnlWarriorsView.Name = "pnlWarriorsView";
            this.pnlWarriorsView.Size = new System.Drawing.Size(462, 274);
            this.pnlWarriorsView.TabIndex = 1;
            // 
            // lblWarriors
            // 
            this.lblWarriors.AutoSize = true;
            this.lblWarriors.Location = new System.Drawing.Point(11, 30);
            this.lblWarriors.Name = "lblWarriors";
            this.lblWarriors.Size = new System.Drawing.Size(46, 13);
            this.lblWarriors.TabIndex = 1;
            this.lblWarriors.Text = "Warriors";
            // 
            // dgvWarriors
            // 
            this.dgvWarriors.AllowUserToAddRows = false;
            this.dgvWarriors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWarriors.BackgroundColor = System.Drawing.Color.White;
            this.dgvWarriors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarriors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWarriorsId,
            this.colWarriorName,
            this.colIsAlive,
            this.colGold});
            this.dgvWarriors.Location = new System.Drawing.Point(14, 47);
            this.dgvWarriors.Name = "dgvWarriors";
            this.dgvWarriors.RowHeadersVisible = false;
            this.dgvWarriors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarriors.Size = new System.Drawing.Size(439, 188);
            this.dgvWarriors.TabIndex = 0;
            this.dgvWarriors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWarriors_CellClick);
            // 
            // colWarriorsId
            // 
            this.colWarriorsId.FillWeight = 81.21828F;
            this.colWarriorsId.HeaderText = "ID";
            this.colWarriorsId.Name = "colWarriorsId";
            // 
            // colWarriorName
            // 
            this.colWarriorName.FillWeight = 106.2606F;
            this.colWarriorName.HeaderText = "Name";
            this.colWarriorName.Name = "colWarriorName";
            // 
            // colIsAlive
            // 
            this.colIsAlive.FillWeight = 106.2606F;
            this.colIsAlive.HeaderText = "IsAlive?";
            this.colIsAlive.Name = "colIsAlive";
            // 
            // colGold
            // 
            this.colGold.FillWeight = 106.2606F;
            this.colGold.HeaderText = "Gold";
            this.colGold.Name = "colGold";
            // 
            // pnlContributionsAndSquads
            // 
            this.pnlContributionsAndSquads.Controls.Add(this.pnlSquads);
            this.pnlContributionsAndSquads.Controls.Add(this.pnlContributions);
            this.pnlContributionsAndSquads.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlContributionsAndSquads.Location = new System.Drawing.Point(462, 0);
            this.pnlContributionsAndSquads.Name = "pnlContributionsAndSquads";
            this.pnlContributionsAndSquads.Size = new System.Drawing.Size(308, 274);
            this.pnlContributionsAndSquads.TabIndex = 3;
            // 
            // pnlSquads
            // 
            this.pnlSquads.Controls.Add(this.lblSquads);
            this.pnlSquads.Controls.Add(this.lbxSquads);
            this.pnlSquads.Location = new System.Drawing.Point(15, 134);
            this.pnlSquads.Name = "pnlSquads";
            this.pnlSquads.Size = new System.Drawing.Size(268, 135);
            this.pnlSquads.TabIndex = 2;
            // 
            // lblSquads
            // 
            this.lblSquads.AutoSize = true;
            this.lblSquads.Location = new System.Drawing.Point(27, 14);
            this.lblSquads.Name = "lblSquads";
            this.lblSquads.Size = new System.Drawing.Size(43, 13);
            this.lblSquads.TabIndex = 2;
            this.lblSquads.Text = "Squads";
            // 
            // lbxSquads
            // 
            this.lbxSquads.FormattingEnabled = true;
            this.lbxSquads.Location = new System.Drawing.Point(30, 30);
            this.lbxSquads.Name = "lbxSquads";
            this.lbxSquads.Size = new System.Drawing.Size(215, 95);
            this.lbxSquads.TabIndex = 0;
            // 
            // pnlContributions
            // 
            this.pnlContributions.Controls.Add(this.lblContributions);
            this.pnlContributions.Controls.Add(this.lbxContributions);
            this.pnlContributions.Location = new System.Drawing.Point(15, 4);
            this.pnlContributions.Name = "pnlContributions";
            this.pnlContributions.Size = new System.Drawing.Size(268, 124);
            this.pnlContributions.TabIndex = 2;
            // 
            // lblContributions
            // 
            this.lblContributions.AutoSize = true;
            this.lblContributions.Location = new System.Drawing.Point(27, 9);
            this.lblContributions.Name = "lblContributions";
            this.lblContributions.Size = new System.Drawing.Size(68, 13);
            this.lblContributions.TabIndex = 2;
            this.lblContributions.Text = "Contributions";
            // 
            // lbxContributions
            // 
            this.lbxContributions.FormattingEnabled = true;
            this.lbxContributions.Location = new System.Drawing.Point(30, 26);
            this.lbxContributions.Name = "lbxContributions";
            this.lbxContributions.Size = new System.Drawing.Size(214, 95);
            this.lbxContributions.TabIndex = 0;
            // 
            // tabSquads
            // 
            this.tabSquads.Controls.Add(this.pnlSquadButtons);
            this.tabSquads.Controls.Add(this.pnlTabSquad);
            this.tabSquads.Location = new System.Drawing.Point(4, 22);
            this.tabSquads.Name = "tabSquads";
            this.tabSquads.Padding = new System.Windows.Forms.Padding(3);
            this.tabSquads.Size = new System.Drawing.Size(776, 341);
            this.tabSquads.TabIndex = 2;
            this.tabSquads.Text = "Squads";
            this.tabSquads.UseVisualStyleBackColor = true;
            // 
            // pnlSquadButtons
            // 
            this.pnlSquadButtons.Controls.Add(this.btnAddSlaveSquad);
            this.pnlSquadButtons.Controls.Add(this.btnAddMasterSquad);
            this.pnlSquadButtons.Controls.Add(this.btnDeleteSquad);
            this.pnlSquadButtons.Controls.Add(this.btnAddSquad);
            this.pnlSquadButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSquadButtons.Location = new System.Drawing.Point(3, 277);
            this.pnlSquadButtons.Name = "pnlSquadButtons";
            this.pnlSquadButtons.Size = new System.Drawing.Size(770, 61);
            this.pnlSquadButtons.TabIndex = 5;
            // 
            // btnAddSlaveSquad
            // 
            this.btnAddSlaveSquad.Enabled = false;
            this.btnAddSlaveSquad.Location = new System.Drawing.Point(310, 6);
            this.btnAddSlaveSquad.Name = "btnAddSlaveSquad";
            this.btnAddSlaveSquad.Size = new System.Drawing.Size(118, 50);
            this.btnAddSlaveSquad.TabIndex = 3;
            this.btnAddSlaveSquad.Text = "Add Slave Squad";
            this.btnAddSlaveSquad.UseVisualStyleBackColor = true;
            this.btnAddSlaveSquad.Click += new System.EventHandler(this.btnAddSlaveSquad_Click);
            // 
            // btnAddMasterSquad
            // 
            this.btnAddMasterSquad.Enabled = false;
            this.btnAddMasterSquad.Location = new System.Drawing.Point(186, 6);
            this.btnAddMasterSquad.Name = "btnAddMasterSquad";
            this.btnAddMasterSquad.Size = new System.Drawing.Size(118, 50);
            this.btnAddMasterSquad.TabIndex = 2;
            this.btnAddMasterSquad.Text = "Add Master Squad";
            this.btnAddMasterSquad.UseVisualStyleBackColor = true;
            this.btnAddMasterSquad.Click += new System.EventHandler(this.btnAddMasterSquad_Click);
            // 
            // btnDeleteSquad
            // 
            this.btnDeleteSquad.Enabled = false;
            this.btnDeleteSquad.Location = new System.Drawing.Point(86, 6);
            this.btnDeleteSquad.Name = "btnDeleteSquad";
            this.btnDeleteSquad.Size = new System.Drawing.Size(94, 50);
            this.btnDeleteSquad.TabIndex = 1;
            this.btnDeleteSquad.Text = "Delete Squad";
            this.btnDeleteSquad.UseVisualStyleBackColor = true;
            this.btnDeleteSquad.Click += new System.EventHandler(this.btnDeleteSquad_Click);
            // 
            // btnAddSquad
            // 
            this.btnAddSquad.Location = new System.Drawing.Point(5, 6);
            this.btnAddSquad.Name = "btnAddSquad";
            this.btnAddSquad.Size = new System.Drawing.Size(75, 50);
            this.btnAddSquad.TabIndex = 0;
            this.btnAddSquad.Text = "Add Squad";
            this.btnAddSquad.UseVisualStyleBackColor = true;
            this.btnAddSquad.Click += new System.EventHandler(this.btnAddSquad_Click);
            // 
            // pnlTabSquad
            // 
            this.pnlTabSquad.Controls.Add(this.pnlSquadsView);
            this.pnlTabSquad.Controls.Add(this.pnlMasterAndSlaveSquads);
            this.pnlTabSquad.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabSquad.Location = new System.Drawing.Point(3, 3);
            this.pnlTabSquad.Name = "pnlTabSquad";
            this.pnlTabSquad.Size = new System.Drawing.Size(770, 274);
            this.pnlTabSquad.TabIndex = 4;
            // 
            // pnlSquadsView
            // 
            this.pnlSquadsView.Controls.Add(this.pnlSquadsWithWarriors);
            this.pnlSquadsView.Controls.Add(this.panel1);
            this.pnlSquadsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSquadsView.Location = new System.Drawing.Point(0, 0);
            this.pnlSquadsView.Name = "pnlSquadsView";
            this.pnlSquadsView.Size = new System.Drawing.Size(462, 274);
            this.pnlSquadsView.TabIndex = 1;
            // 
            // pnlSquadsWithWarriors
            // 
            this.pnlSquadsWithWarriors.Controls.Add(this.dgvWarriorsInSquad);
            this.pnlSquadsWithWarriors.Controls.Add(this.lblWarriorsFromSquad);
            this.pnlSquadsWithWarriors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSquadsWithWarriors.Location = new System.Drawing.Point(217, 0);
            this.pnlSquadsWithWarriors.Name = "pnlSquadsWithWarriors";
            this.pnlSquadsWithWarriors.Size = new System.Drawing.Size(245, 274);
            this.pnlSquadsWithWarriors.TabIndex = 3;
            // 
            // dgvWarriorsInSquad
            // 
            this.dgvWarriorsInSquad.AllowUserToAddRows = false;
            this.dgvWarriorsInSquad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWarriorsInSquad.BackgroundColor = System.Drawing.Color.White;
            this.dgvWarriorsInSquad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarriorsInSquad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvWarriorsInSquad.Location = new System.Drawing.Point(26, 29);
            this.dgvWarriorsInSquad.Name = "dgvWarriorsInSquad";
            this.dgvWarriorsInSquad.RowHeadersVisible = false;
            this.dgvWarriorsInSquad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarriorsInSquad.Size = new System.Drawing.Size(208, 229);
            this.dgvWarriorsInSquad.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 40.60914F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 159.3909F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // lblWarriorsFromSquad
            // 
            this.lblWarriorsFromSquad.AutoSize = true;
            this.lblWarriorsFromSquad.Location = new System.Drawing.Point(23, 13);
            this.lblWarriorsFromSquad.Name = "lblWarriorsFromSquad";
            this.lblWarriorsFromSquad.Size = new System.Drawing.Size(46, 13);
            this.lblWarriorsFromSquad.TabIndex = 3;
            this.lblWarriorsFromSquad.Text = "Warriors";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSquads);
            this.panel1.Controls.Add(this.lblSquadList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 274);
            this.panel1.TabIndex = 2;
            // 
            // dgvSquads
            // 
            this.dgvSquads.AllowUserToAddRows = false;
            this.dgvSquads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSquads.BackgroundColor = System.Drawing.Color.White;
            this.dgvSquads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSquads.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSquadId,
            this.colSquadName});
            this.dgvSquads.Location = new System.Drawing.Point(15, 30);
            this.dgvSquads.Name = "dgvSquads";
            this.dgvSquads.RowHeadersVisible = false;
            this.dgvSquads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSquads.Size = new System.Drawing.Size(147, 229);
            this.dgvSquads.TabIndex = 0;
            this.dgvSquads.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSquads_CellClick);
            // 
            // colSquadId
            // 
            this.colSquadId.FillWeight = 40.60914F;
            this.colSquadId.HeaderText = "ID";
            this.colSquadId.Name = "colSquadId";
            // 
            // colSquadName
            // 
            this.colSquadName.FillWeight = 159.3909F;
            this.colSquadName.HeaderText = "Name";
            this.colSquadName.Name = "colSquadName";
            // 
            // lblSquadList
            // 
            this.lblSquadList.AutoSize = true;
            this.lblSquadList.Location = new System.Drawing.Point(12, 13);
            this.lblSquadList.Name = "lblSquadList";
            this.lblSquadList.Size = new System.Drawing.Size(43, 13);
            this.lblSquadList.TabIndex = 1;
            this.lblSquadList.Text = "Squads";
            // 
            // pnlMasterAndSlaveSquads
            // 
            this.pnlMasterAndSlaveSquads.Controls.Add(this.pnlMasterSquads);
            this.pnlMasterAndSlaveSquads.Controls.Add(this.pnlSlaveSquads);
            this.pnlMasterAndSlaveSquads.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMasterAndSlaveSquads.Location = new System.Drawing.Point(462, 0);
            this.pnlMasterAndSlaveSquads.Name = "pnlMasterAndSlaveSquads";
            this.pnlMasterAndSlaveSquads.Size = new System.Drawing.Size(308, 274);
            this.pnlMasterAndSlaveSquads.TabIndex = 3;
            // 
            // pnlMasterSquads
            // 
            this.pnlMasterSquads.Controls.Add(this.lblMasterSquads);
            this.pnlMasterSquads.Controls.Add(this.lbxMasterSquads);
            this.pnlMasterSquads.Location = new System.Drawing.Point(15, 134);
            this.pnlMasterSquads.Name = "pnlMasterSquads";
            this.pnlMasterSquads.Size = new System.Drawing.Size(268, 135);
            this.pnlMasterSquads.TabIndex = 2;
            // 
            // lblMasterSquads
            // 
            this.lblMasterSquads.AutoSize = true;
            this.lblMasterSquads.Location = new System.Drawing.Point(27, 14);
            this.lblMasterSquads.Name = "lblMasterSquads";
            this.lblMasterSquads.Size = new System.Drawing.Size(73, 13);
            this.lblMasterSquads.TabIndex = 2;
            this.lblMasterSquads.Text = "Slave Squads";
            // 
            // lbxMasterSquads
            // 
            this.lbxMasterSquads.FormattingEnabled = true;
            this.lbxMasterSquads.Location = new System.Drawing.Point(30, 30);
            this.lbxMasterSquads.Name = "lbxMasterSquads";
            this.lbxMasterSquads.Size = new System.Drawing.Size(215, 95);
            this.lbxMasterSquads.TabIndex = 0;
            // 
            // pnlSlaveSquads
            // 
            this.pnlSlaveSquads.Controls.Add(this.lblSlaveSquads);
            this.pnlSlaveSquads.Controls.Add(this.lbxSlaveSquads);
            this.pnlSlaveSquads.Location = new System.Drawing.Point(15, 4);
            this.pnlSlaveSquads.Name = "pnlSlaveSquads";
            this.pnlSlaveSquads.Size = new System.Drawing.Size(268, 124);
            this.pnlSlaveSquads.TabIndex = 2;
            // 
            // lblSlaveSquads
            // 
            this.lblSlaveSquads.AutoSize = true;
            this.lblSlaveSquads.Location = new System.Drawing.Point(27, 9);
            this.lblSlaveSquads.Name = "lblSlaveSquads";
            this.lblSlaveSquads.Size = new System.Drawing.Size(78, 13);
            this.lblSlaveSquads.TabIndex = 2;
            this.lblSlaveSquads.Text = "Master Squads";
            // 
            // lbxSlaveSquads
            // 
            this.lbxSlaveSquads.FormattingEnabled = true;
            this.lbxSlaveSquads.Location = new System.Drawing.Point(30, 26);
            this.lbxSlaveSquads.Name = "lbxSlaveSquads";
            this.lbxSlaveSquads.Size = new System.Drawing.Size(214, 95);
            this.lbxSlaveSquads.TabIndex = 0;
            // 
            // txbDBName
            // 
            this.txbDBName.Location = new System.Drawing.Point(71, 9);
            this.txbDBName.Name = "txbDBName";
            this.txbDBName.Size = new System.Drawing.Size(158, 20);
            this.txbDBName.TabIndex = 4;
            this.txbDBName.Text = "PrinceIgorArmy";
            // 
            // lblDBName
            // 
            this.lblDBName.AutoSize = true;
            this.lblDBName.Location = new System.Drawing.Point(12, 12);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(56, 13);
            this.lblDBName.TabIndex = 5;
            this.lblDBName.Text = "DB Name:";
            // 
            // PrinceIgorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 442);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlConnection);
            this.MaximumSize = new System.Drawing.Size(800, 480);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "PrinceIgorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prince Igor";
            this.pnlConnection.ResumeLayout(false);
            this.pnlConnection.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpWarriors.ResumeLayout(false);
            this.pnlWarriorsButtons.ResumeLayout(false);
            this.pnlTabWarriors.ResumeLayout(false);
            this.pnlWarriorsView.ResumeLayout(false);
            this.pnlWarriorsView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarriors)).EndInit();
            this.pnlContributionsAndSquads.ResumeLayout(false);
            this.pnlSquads.ResumeLayout(false);
            this.pnlSquads.PerformLayout();
            this.pnlContributions.ResumeLayout(false);
            this.pnlContributions.PerformLayout();
            this.tabSquads.ResumeLayout(false);
            this.pnlSquadButtons.ResumeLayout(false);
            this.pnlTabSquad.ResumeLayout(false);
            this.pnlSquadsView.ResumeLayout(false);
            this.pnlSquadsWithWarriors.ResumeLayout(false);
            this.pnlSquadsWithWarriors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarriorsInSquad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSquads)).EndInit();
            this.pnlMasterAndSlaveSquads.ResumeLayout(false);
            this.pnlMasterSquads.ResumeLayout(false);
            this.pnlMasterSquads.PerformLayout();
            this.pnlSlaveSquads.ResumeLayout(false);
            this.pnlSlaveSquads.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnectDB;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlConnection;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpWarriors;
        private System.Windows.Forms.DataGridView dgvWarriors;
        private System.Windows.Forms.Panel pnlSquads;
        private System.Windows.Forms.ListBox lbxSquads;
        private System.Windows.Forms.Panel pnlContributions;
        private System.Windows.Forms.ListBox lbxContributions;
        private System.Windows.Forms.Panel pnlWarriorsView;
        private System.Windows.Forms.Panel pnlContributionsAndSquads;
        private System.Windows.Forms.Label lblSquads;
        private System.Windows.Forms.Label lblContributions;
        private System.Windows.Forms.Label lblWarriors;
        private System.Windows.Forms.Panel pnlWarriorsButtons;
        private System.Windows.Forms.Panel pnlTabWarriors;
        private System.Windows.Forms.Button btnAddWarrior;
        private System.Windows.Forms.Button btnAddContribution;
        private System.Windows.Forms.Button btnAssagnToSquad;
        private System.Windows.Forms.TabPage tabSquads;
        private System.Windows.Forms.Panel pnlSquadButtons;
        private System.Windows.Forms.Button btnAddMasterSquad;
        private System.Windows.Forms.Button btnDeleteSquad;
        private System.Windows.Forms.Button btnAddSquad;
        private System.Windows.Forms.Panel pnlTabSquad;
        private System.Windows.Forms.Panel pnlSquadsView;
        private System.Windows.Forms.Label lblSquadList;
        private System.Windows.Forms.DataGridView dgvSquads;
        private System.Windows.Forms.Panel pnlMasterAndSlaveSquads;
        private System.Windows.Forms.Panel pnlMasterSquads;
        private System.Windows.Forms.Label lblMasterSquads;
        private System.Windows.Forms.ListBox lbxMasterSquads;
        private System.Windows.Forms.Panel pnlSlaveSquads;
        private System.Windows.Forms.Label lblSlaveSquads;
        private System.Windows.Forms.ListBox lbxSlaveSquads;
        private System.Windows.Forms.Button btnAddSlaveSquad;
        private System.Windows.Forms.Panel pnlSquadsWithWarriors;
        private System.Windows.Forms.DataGridView dgvWarriorsInSquad;
        private System.Windows.Forms.Label lblWarriorsFromSquad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarriorsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarriorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsAlive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGold;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSquadId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSquadName;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.TextBox txbDBName;
    }
}

