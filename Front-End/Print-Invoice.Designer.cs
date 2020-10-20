namespace Front_End
{
    partial class Print_Invoice
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
            this.prntInvButton = new System.Windows.Forms.Button();
            this.rtnButtom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prntInvButton
            // 
            this.prntInvButton.Location = new System.Drawing.Point(650, 405);
            this.prntInvButton.Name = "prntInvButton";
            this.prntInvButton.Size = new System.Drawing.Size(138, 33);
            this.prntInvButton.TabIndex = 4;
            this.prntInvButton.Text = "Print Invoice";
            this.prntInvButton.UseVisualStyleBackColor = true;
            this.prntInvButton.Click += new System.EventHandler(this.prntInvButton_Click);
            // 
            // rtnButtom
            // 
            this.rtnButtom.Location = new System.Drawing.Point(12, 405);
            this.rtnButtom.Name = "rtnButtom";
            this.rtnButtom.Size = new System.Drawing.Size(158, 33);
            this.rtnButtom.TabIndex = 5;
            this.rtnButtom.Text = "Return to Homepage";
            this.rtnButtom.UseVisualStyleBackColor = true;
            this.rtnButtom.Click += new System.EventHandler(this.rtnButtom_Click);
            // 
            // Print_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtnButtom);
            this.Controls.Add(this.prntInvButton);
            this.Name = "Print_Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Print_Invoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button prntInvButton;
        private System.Windows.Forms.Button rtnButtom;
    }
}