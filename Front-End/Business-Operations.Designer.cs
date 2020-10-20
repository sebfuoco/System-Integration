namespace Front_End
{
    partial class Business_Operations
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
            this.extButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // extButton
            // 
            this.extButton.Location = new System.Drawing.Point(12, 405);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(138, 33);
            this.extButton.TabIndex = 1;
            this.extButton.Text = "Exit";
            this.extButton.UseVisualStyleBackColor = true;
            this.extButton.Click += new System.EventHandler(this.extButton_Click);
            // 
            // Business_Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.extButton);
            this.Name = "Business_Operations";
            this.Text = "Business Operations";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button extButton;
    }
}