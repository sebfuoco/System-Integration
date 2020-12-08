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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking_Confirmation));
            this.extButton = new System.Windows.Forms.Button();
            this.nxtButton = new System.Windows.Forms.Button();
            this.cnlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // extButton
            // 
            this.extButton.BackColor = System.Drawing.Color.Transparent;
            this.extButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extButton.Location = new System.Drawing.Point(578, -1);
            this.extButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(24, 24);
            this.extButton.TabIndex = 20;
            this.extButton.Text = "X";
            this.extButton.UseVisualStyleBackColor = false;
            this.extButton.Click += new System.EventHandler(this.extButton_Click);
            // 
            // nxtButton
            // 
            this.nxtButton.Image = ((System.Drawing.Image)(resources.GetObject("nxtButton.Image")));
            this.nxtButton.Location = new System.Drawing.Point(535, 436);
            this.nxtButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nxtButton.Name = "nxtButton";
            this.nxtButton.Size = new System.Drawing.Size(56, 41);
            this.nxtButton.TabIndex = 18;
            this.nxtButton.UseVisualStyleBackColor = true;
            this.nxtButton.Click += new System.EventHandler(this.nxtButton_Click);
            // 
            // cnlButton
            // 
            this.cnlButton.Image = ((System.Drawing.Image)(resources.GetObject("cnlButton.Image")));
            this.cnlButton.Location = new System.Drawing.Point(9, 436);
            this.cnlButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cnlButton.Name = "cnlButton";
            this.cnlButton.Size = new System.Drawing.Size(42, 41);
            this.cnlButton.TabIndex = 17;
            this.cnlButton.UseVisualStyleBackColor = true;
            this.cnlButton.Click += new System.EventHandler(this.cnlButton_Click);
            // 
            // Booking_Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.extButton);
            this.Controls.Add(this.nxtButton);
            this.Controls.Add(this.cnlButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Booking_Confirmation";
            this.Text = "Booking Confirmation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button extButton;
        private System.Windows.Forms.Button nxtButton;
        private System.Windows.Forms.Button cnlButton;
    }
}