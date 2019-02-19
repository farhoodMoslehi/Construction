namespace ViewForms
{
    partial class MainAssets
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
            this.btnContractor = new System.Windows.Forms.Button();
            this.btnSite = new System.Windows.Forms.Button();
            this.btnJob = new System.Windows.Forms.Button();
            this.lbl_DbConnection = new System.Windows.Forms.Label();
            this.lstContractors = new System.Windows.Forms.ListBox();
            this.lstSite = new System.Windows.Forms.ListBox();
            this.lstJob = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnContractor
            // 
            this.btnContractor.Location = new System.Drawing.Point(41, 41);
            this.btnContractor.Name = "btnContractor";
            this.btnContractor.Size = new System.Drawing.Size(120, 23);
            this.btnContractor.TabIndex = 0;
            this.btnContractor.Text = "Add Contractor";
            this.btnContractor.UseVisualStyleBackColor = true;
            this.btnContractor.Click += new System.EventHandler(this.btnContractor_Click);
            // 
            // btnSite
            // 
            this.btnSite.Location = new System.Drawing.Point(237, 41);
            this.btnSite.Name = "btnSite";
            this.btnSite.Size = new System.Drawing.Size(120, 23);
            this.btnSite.TabIndex = 1;
            this.btnSite.Text = "Add Site";
            this.btnSite.UseVisualStyleBackColor = true;
            // 
            // btnJob
            // 
            this.btnJob.Location = new System.Drawing.Point(431, 41);
            this.btnJob.Name = "btnJob";
            this.btnJob.Size = new System.Drawing.Size(120, 23);
            this.btnJob.TabIndex = 2;
            this.btnJob.Text = "Add Job";
            this.btnJob.UseVisualStyleBackColor = true;
            // 
            // lbl_DbConnection
            // 
            this.lbl_DbConnection.AutoSize = true;
            this.lbl_DbConnection.Location = new System.Drawing.Point(809, 290);
            this.lbl_DbConnection.Name = "lbl_DbConnection";
            this.lbl_DbConnection.Size = new System.Drawing.Size(75, 13);
            this.lbl_DbConnection.TabIndex = 3;
            this.lbl_DbConnection.Text = "DbConnection";
            // 
            // lstContractors
            // 
            this.lstContractors.FormattingEnabled = true;
            this.lstContractors.Location = new System.Drawing.Point(41, 92);
            this.lstContractors.Name = "lstContractors";
            this.lstContractors.Size = new System.Drawing.Size(120, 95);
            this.lstContractors.TabIndex = 4;
            // 
            // lstSite
            // 
            this.lstSite.FormattingEnabled = true;
            this.lstSite.Location = new System.Drawing.Point(237, 92);
            this.lstSite.Name = "lstSite";
            this.lstSite.Size = new System.Drawing.Size(120, 95);
            this.lstSite.TabIndex = 5;
            // 
            // lstJob
            // 
            this.lstJob.FormattingEnabled = true;
            this.lstJob.Location = new System.Drawing.Point(431, 92);
            this.lstJob.Name = "lstJob";
            this.lstJob.Size = new System.Drawing.Size(120, 95);
            this.lstJob.TabIndex = 6;
            // 
            // MainAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 312);
            this.Controls.Add(this.lstJob);
            this.Controls.Add(this.lstSite);
            this.Controls.Add(this.lstContractors);
            this.Controls.Add(this.lbl_DbConnection);
            this.Controls.Add(this.btnJob);
            this.Controls.Add(this.btnSite);
            this.Controls.Add(this.btnContractor);
            this.Name = "MainAssets";
            this.Text = "MainAssets";
            this.Load += new System.EventHandler(this.MainAssets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContractor;
        private System.Windows.Forms.Button btnSite;
        private System.Windows.Forms.Button btnJob;
        private System.Windows.Forms.Label lbl_DbConnection;
        private System.Windows.Forms.ListBox lstContractors;
        private System.Windows.Forms.ListBox lstSite;
        private System.Windows.Forms.ListBox lstJob;
    }
}

