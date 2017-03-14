namespace PrinceIgor
{
    partial class frmAddContributionForm
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
            this.btnAddContribution = new System.Windows.Forms.Button();
            this.lblContribution = new System.Windows.Forms.Label();
            this.rtxbContribution = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAddContribution
            // 
            this.btnAddContribution.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddContribution.Location = new System.Drawing.Point(14, 87);
            this.btnAddContribution.Name = "btnAddContribution";
            this.btnAddContribution.Size = new System.Drawing.Size(273, 41);
            this.btnAddContribution.TabIndex = 5;
            this.btnAddContribution.Text = "Add Contribution";
            this.btnAddContribution.UseVisualStyleBackColor = true;
            this.btnAddContribution.Click += new System.EventHandler(this.btnAddContribution_Click);
            // 
            // lblContribution
            // 
            this.lblContribution.AutoSize = true;
            this.lblContribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblContribution.Location = new System.Drawing.Point(10, 9);
            this.lblContribution.Name = "lblContribution";
            this.lblContribution.Size = new System.Drawing.Size(99, 20);
            this.lblContribution.TabIndex = 3;
            this.lblContribution.Text = "Contribution:";
            // 
            // rtxbContribution
            // 
            this.rtxbContribution.Location = new System.Drawing.Point(14, 32);
            this.rtxbContribution.Name = "rtxbContribution";
            this.rtxbContribution.Size = new System.Drawing.Size(271, 49);
            this.rtxbContribution.TabIndex = 6;
            this.rtxbContribution.Text = "";
            // 
            // frmAddContributionForm
            // 
            this.AcceptButton = this.btnAddContribution;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 140);
            this.Controls.Add(this.rtxbContribution);
            this.Controls.Add(this.btnAddContribution);
            this.Controls.Add(this.lblContribution);
            this.Name = "frmAddContributionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Contribution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddContribution;
        private System.Windows.Forms.Label lblContribution;
        private System.Windows.Forms.RichTextBox rtxbContribution;
    }
}