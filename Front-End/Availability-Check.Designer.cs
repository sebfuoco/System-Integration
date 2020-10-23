namespace Front_End
{
    partial class Availability_Check
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Availability_Check));
            this.cnlButton = new System.Windows.Forms.Button();
            this.nxtButton = new System.Windows.Forms.Button();
            this.extButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cnlButton
            // 
            this.cnlButton.BackColor = System.Drawing.Color.Transparent;
            this.cnlButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cnlButton.BackgroundImage")));
            this.cnlButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cnlButton.FlatAppearance.BorderSize = 0;
            this.cnlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cnlButton.Location = new System.Drawing.Point(12, 528);
            this.cnlButton.Name = "cnlButton";
            this.cnlButton.Size = new System.Drawing.Size(93, 60);
            this.cnlButton.TabIndex = 1;
            this.cnlButton.UseVisualStyleBackColor = false;
            this.cnlButton.Click += new System.EventHandler(this.cnlButton_Click);
            // 
            // nxtButton
            // 
            this.nxtButton.BackColor = System.Drawing.Color.Transparent;
            this.nxtButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nxtButton.BackgroundImage")));
            this.nxtButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nxtButton.FlatAppearance.BorderSize = 0;
            this.nxtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nxtButton.Location = new System.Drawing.Point(695, 528);
            this.nxtButton.Name = "nxtButton";
            this.nxtButton.Size = new System.Drawing.Size(93, 60);
            this.nxtButton.TabIndex = 2;
            this.nxtButton.UseVisualStyleBackColor = false;
            this.nxtButton.Click += new System.EventHandler(this.nxtButton_Click);
            // 
            // extButton
            // 
            this.extButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("extButton.BackgroundImage")));
            this.extButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.extButton.FlatAppearance.BorderSize = 0;
            this.extButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extButton.Location = new System.Drawing.Point(751, -1);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(49, 41);
            this.extButton.TabIndex = 3;
            this.extButton.UseVisualStyleBackColor = true;
            this.extButton.Click += new System.EventHandler(this.extButton_Click);
            // 
            // Availability_Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.extButton);
            this.Controls.Add(this.nxtButton);
            this.Controls.Add(this.cnlButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Availability_Check";
            this.Text = "Availability Check";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cnlButton;
        private System.Windows.Forms.Button nxtButton;
        private System.Windows.Forms.Button extButton;
    }
}