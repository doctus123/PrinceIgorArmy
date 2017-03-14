namespace PrinceIgor
{
    partial class frmAddWarriorForm
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
            this.lblAddWarriorName = new System.Windows.Forms.Label();
            this.txbWarriorName = new System.Windows.Forms.TextBox();
            this.btnAddWarrior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddWarriorName
            // 
            this.lblAddWarriorName.AutoSize = true;
            this.lblAddWarriorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddWarriorName.Location = new System.Drawing.Point(12, 24);
            this.lblAddWarriorName.Name = "lblAddWarriorName";
            this.lblAddWarriorName.Size = new System.Drawing.Size(74, 25);
            this.lblAddWarriorName.TabIndex = 0;
            this.lblAddWarriorName.Text = "Name:";
            // 
            // txbWarriorName
            // 
            this.txbWarriorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbWarriorName.Location = new System.Drawing.Point(92, 21);
            this.txbWarriorName.Name = "txbWarriorName";
            this.txbWarriorName.Size = new System.Drawing.Size(198, 31);
            this.txbWarriorName.TabIndex = 1;
            // 
            // btnAddWarrior
            // 
            this.btnAddWarrior.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddWarrior.Location = new System.Drawing.Point(17, 58);
            this.btnAddWarrior.Name = "btnAddWarrior";
            this.btnAddWarrior.Size = new System.Drawing.Size(273, 41);
            this.btnAddWarrior.TabIndex = 2;
            this.btnAddWarrior.Text = "Add Warrior";
            this.btnAddWarrior.UseVisualStyleBackColor = true;
            this.btnAddWarrior.Click += new System.EventHandler(this.btnInsertWarriorIntoTable_Click);
            // 
            // frmAddWarriorForm
            // 
            this.AcceptButton = this.btnAddWarrior;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 111);
            this.Controls.Add(this.btnAddWarrior);
            this.Controls.Add(this.txbWarriorName);
            this.Controls.Add(this.lblAddWarriorName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddWarriorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Warrior";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddWarriorName;
        private System.Windows.Forms.TextBox txbWarriorName;
        private System.Windows.Forms.Button btnAddWarrior;
    }
}