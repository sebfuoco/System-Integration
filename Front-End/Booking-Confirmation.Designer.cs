namespace Front_End
{
    partial class Booking_Confirmation
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
            this.nxtButton = new System.Windows.Forms.Button();
            this.rtnButton = new System.Windows.Forms.Button();
            this.bckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nxtButton
            // 
            this.nxtButton.Location = new System.Drawing.Point(650, 405);
            this.nxtButton.Name = "nxtButton";
            this.nxtButton.Size = new System.Drawing.Size(138, 33);
            this.nxtButton.TabIndex = 3;
            this.nxtButton.Text = "Next";
            this.nxtButton.UseVisualStyleBackColor = true;
            this.nxtButton.Click += new System.EventHandler(this.nxtButton_Click);
            // 
            // rtnButton
            // 
            this.rtnButton.Location = new System.Drawing.Point(12, 405);
            this.rtnButton.Name = "rtnButton";
            this.rtnButton.Size = new System.Drawing.Size(153, 33);
            this.rtnButton.TabIndex = 4;
            this.rtnButton.Text = "Return to Homepage";
            this.rtnButton.UseVisualStyleBackColor = true;
            this.rtnButton.Click += new System.EventHandler(this.cnlButton_Click);
            // 
            // bckButton
            // 
            this.bckButton.Location = new System.Drawing.Point(506, 405);
            this.bckButton.Name = "bckButton";
            this.bckButton.Size = new System.Drawing.Size(138, 33);
            this.bckButton.TabIndex = 6;
            this.bckButton.Text = "Back";
            this.bckButton.UseVisualStyleBackColor = true;
            this.bckButton.Click += new System.EventHandler(this.bckButton_Click);
            // 
            // Booking_Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bckButton);
            this.Controls.Add(this.rtnButton);
            this.Controls.Add(this.nxtButton);
            this.Name = "Booking_Confirmation";
            this.Text = "Booking Confirmation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nxtButton;
        private System.Windows.Forms.Button rtnButton;
        private System.Windows.Forms.Button bckButton;
    }
}