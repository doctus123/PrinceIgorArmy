namespace PrinceIgor
{
    partial class frmAddSquadForm
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
            this.btnAddSquad = new System.Windows.Forms.Button();
            this.txbSquadName = new System.Windows.Forms.TextBox();
            this.lblAddSquadName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddSquad
            // 
            this.btnAddSquad.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddSquad.Location = new System.Drawing.Point(8, 49);
            this.btnAddSquad.Name = "btnAddSquad";
            this.btnAddSquad.Size = new System.Drawing.Size(273, 41);
            this.btnAddSquad.TabIndex = 5;
            this.btnAddSquad.Text = "Add Squad";
            this.btnAddSquad.UseVisualStyleBackColor = true;
            this.btnAddSquad.Click += new System.EventHandler(this.btnAddSquad_Click);
            // 
            // txbSquadName
            // 
            this.txbSquadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbSquadName.Location = new System.Drawing.Point(83, 12);
            this.txbSquadName.Name = "txbSquadName";
            this.txbSquadName.Size = new System.Drawing.Size(198, 31);
            this.txbSquadName.TabIndex = 4;
            // 
            // lblAddSquadName
            // 
            this.lblAddSquadName.AutoSize = true;
            this.lblAddSquadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddSquadName.Location = new System.Drawing.Point(3, 15);
            this.lblAddSquadName.Name = "lblAddSquadName";
            this.lblAddSquadName.Size = new System.Drawing.Size(74, 25);
            this.lblAddSquadName.TabIndex = 3;
            this.lblAddSquadName.Text = "Name:";
            // 
            // frmAddSquadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 103);
            this.Controls.Add(this.btnAddSquad);
            this.Controls.Add(this.txbSquadName);
            this.Controls.Add(this.lblAddSquadName);
            this.Name = "frmAddSquadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Squad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSquad;
        private System.Windows.Forms.TextBox txbSquadName;
        private System.Windows.Forms.Label lblAddSquadName;
    }
}