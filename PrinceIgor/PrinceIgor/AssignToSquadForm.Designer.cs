namespace PrinceIgor
{
    partial class frmAssignToSquadForm
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
            this.btnAssingToSquad = new System.Windows.Forms.Button();
            this.lbxSquads = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAssingToSquad
            // 
            this.btnAssingToSquad.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAssingToSquad.Location = new System.Drawing.Point(8, 184);
            this.btnAssingToSquad.Name = "btnAssingToSquad";
            this.btnAssingToSquad.Size = new System.Drawing.Size(273, 41);
            this.btnAssingToSquad.TabIndex = 3;
            this.btnAssingToSquad.Text = "Assign to Squad";
            this.btnAssingToSquad.UseVisualStyleBackColor = true;
            this.btnAssingToSquad.Click += new System.EventHandler(this.btnAssingToSquad_Click);
            // 
            // lbxSquads
            // 
            this.lbxSquads.FormattingEnabled = true;
            this.lbxSquads.Location = new System.Drawing.Point(12, 26);
            this.lbxSquads.Name = "lbxSquads";
            this.lbxSquads.Size = new System.Drawing.Size(269, 147);
            this.lbxSquads.TabIndex = 4;
            // 
            // frmAssignToSquadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 232);
            this.Controls.Add(this.lbxSquads);
            this.Controls.Add(this.btnAssingToSquad);
            this.Name = "frmAssignToSquadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign To Squad";
            this.Load += new System.EventHandler(this.frmAssignToSquad_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAssingToSquad;
        private System.Windows.Forms.ListBox lbxSquads;
    }
}