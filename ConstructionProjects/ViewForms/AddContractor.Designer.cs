namespace ViewForms
{
    partial class AddContractor
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
            this.lblContractorName = new System.Windows.Forms.Label();
            this.lblContractorAddress = new System.Windows.Forms.Label();
            this.txtContractorName = new System.Windows.Forms.TextBox();
            this.txtContractorAddress = new System.Windows.Forms.TextBox();
            this.btnContractorSubmit = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContractorName
            // 
            this.lblContractorName.AutoSize = true;
            this.lblContractorName.Location = new System.Drawing.Point(56, 29);
            this.lblContractorName.Name = "lblContractorName";
            this.lblContractorName.Size = new System.Drawing.Size(87, 13);
            this.lblContractorName.TabIndex = 0;
            this.lblContractorName.Text = "Contractor Name";
            // 
            // lblContractorAddress
            // 
            this.lblContractorAddress.AutoSize = true;
            this.lblContractorAddress.Location = new System.Drawing.Point(56, 63);
            this.lblContractorAddress.Name = "lblContractorAddress";
            this.lblContractorAddress.Size = new System.Drawing.Size(97, 13);
            this.lblContractorAddress.TabIndex = 1;
            this.lblContractorAddress.Text = "Contractor Address";
            // 
            // txtContractorName
            // 
            this.txtContractorName.Location = new System.Drawing.Point(173, 29);
            this.txtContractorName.Name = "txtContractorName";
            this.txtContractorName.Size = new System.Drawing.Size(191, 20);
            this.txtContractorName.TabIndex = 2;
            // 
            // txtContractorAddress
            // 
            this.txtContractorAddress.Location = new System.Drawing.Point(173, 63);
            this.txtContractorAddress.Name = "txtContractorAddress";
            this.txtContractorAddress.Size = new System.Drawing.Size(389, 20);
            this.txtContractorAddress.TabIndex = 3;
            // 
            // btnContractorSubmit
            // 
            this.btnContractorSubmit.Location = new System.Drawing.Point(59, 141);
            this.btnContractorSubmit.Name = "btnContractorSubmit";
            this.btnContractorSubmit.Size = new System.Drawing.Size(112, 21);
            this.btnContractorSubmit.TabIndex = 4;
            this.btnContractorSubmit.Text = "Submit";
            this.btnContractorSubmit.UseVisualStyleBackColor = true;
            this.btnContractorSubmit.Click += new System.EventHandler(this.btnContractorSubmit_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(56, 97);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 5;
            this.lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(173, 97);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(389, 20);
            this.txtNotes.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(210, 141);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 21);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AddContractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 174);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.btnContractorSubmit);
            this.Controls.Add(this.txtContractorAddress);
            this.Controls.Add(this.txtContractorName);
            this.Controls.Add(this.lblContractorAddress);
            this.Controls.Add(this.lblContractorName);
            this.Name = "AddContractor";
            this.Text = "AddContractor";
            this.Load += new System.EventHandler(this.AddContractor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContractorName;
        private System.Windows.Forms.Label lblContractorAddress;
        private System.Windows.Forms.TextBox txtContractorName;
        private System.Windows.Forms.TextBox txtContractorAddress;
        private System.Windows.Forms.Button btnContractorSubmit;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnExit;
    }
}