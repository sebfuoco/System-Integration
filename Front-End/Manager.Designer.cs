namespace Front_End
{
    partial class Manager
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
            this.cnlButton = new System.Windows.Forms.Button();
            this.lgnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cnlButton
            // 
            this.cnlButton.Location = new System.Drawing.Point(12, 405);
            this.cnlButton.Name = "cnlButton";
            this.cnlButton.Size = new System.Drawing.Size(138, 33);
            this.cnlButton.TabIndex = 2;
            this.cnlButton.Text = "Cancel";
            this.cnlButton.UseVisualStyleBackColor = true;
            this.cnlButton.Click += new System.EventHandler(this.cnlButton_Click);
            // 
            // lgnButton
            // 
            this.lgnButton.Location = new System.Drawing.Point(331, 209);
            this.lgnButton.Name = "lgnButton";
            this.lgnButton.Size = new System.Drawing.Size(138, 33);
            this.lgnButton.TabIndex = 3;
            this.lgnButton.Text = "Log In";
            this.lgnButton.UseVisualStyleBackColor = true;
            this.lgnButton.Click += new System.EventHandler(this.lgnButton_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lgnButton);
            this.Controls.Add(this.cnlButton);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cnlButton;
        private System.Windows.Forms.Button lgnButton;
    }
}