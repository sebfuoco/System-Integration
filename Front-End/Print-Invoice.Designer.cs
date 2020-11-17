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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prntInvButton
            // 
            this.prntInvButton.Location = new System.Drawing.Point(731, 506);
            this.prntInvButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prntInvButton.Name = "prntInvButton";
            this.prntInvButton.Size = new System.Drawing.Size(155, 41);
            this.prntInvButton.TabIndex = 4;
            this.prntInvButton.Text = "Print Invoice";
            this.prntInvButton.UseVisualStyleBackColor = true;
            this.prntInvButton.Click += new System.EventHandler(this.prntInvButton_Click);
            // 
            // rtnButtom
            // 
            this.rtnButtom.Location = new System.Drawing.Point(14, 506);
            this.rtnButtom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtnButtom.Name = "rtnButtom";
            this.rtnButtom.Size = new System.Drawing.Size(178, 41);
            this.rtnButtom.TabIndex = 5;
            this.rtnButtom.Text = "Return to Homepage";
            this.rtnButtom.UseVisualStyleBackColor = true;
            this.rtnButtom.Click += new System.EventHandler(this.rtnButtom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Print_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtnButtom);
            this.Controls.Add(this.prntInvButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Print_Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Print_Invoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prntInvButton;
        private System.Windows.Forms.Button rtnButtom;
        private System.Windows.Forms.Label label1;
    }
}