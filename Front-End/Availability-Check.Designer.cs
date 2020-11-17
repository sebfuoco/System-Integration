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
            this.extButton = new System.Windows.Forms.Button();
            this.bckButton = new System.Windows.Forms.Button();
            this.nxtButton = new System.Windows.Forms.Button();
            this.cnlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // extButton
            // 
            this.extButton.BackColor = System.Drawing.Color.Transparent;
            this.extButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extButton.Location = new System.Drawing.Point(770, -1);
            this.extButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(32, 29);
            this.extButton.TabIndex = 16;
            this.extButton.Text = "X";
            this.extButton.UseVisualStyleBackColor = false;
            // 
            // bckButton
            // 
            this.bckButton.Image = ((System.Drawing.Image)(resources.GetObject("bckButton.Image")));
            this.bckButton.Location = new System.Drawing.Point(637, 537);
            this.bckButton.Name = "bckButton";
            this.bckButton.Size = new System.Drawing.Size(66, 51);
            this.bckButton.TabIndex = 15;
            this.bckButton.UseVisualStyleBackColor = true;
            // 
            // nxtButton
            // 
            this.nxtButton.Image = ((System.Drawing.Image)(resources.GetObject("nxtButton.Image")));
            this.nxtButton.Location = new System.Drawing.Point(713, 537);
            this.nxtButton.Name = "nxtButton";
            this.nxtButton.Size = new System.Drawing.Size(66, 51);
            this.nxtButton.TabIndex = 14;
            this.nxtButton.UseVisualStyleBackColor = true;
            // 
            // cnlButton
            // 
            this.cnlButton.Image = ((System.Drawing.Image)(resources.GetObject("cnlButton.Image")));
            this.cnlButton.Location = new System.Drawing.Point(12, 537);
            this.cnlButton.Name = "cnlButton";
            this.cnlButton.Size = new System.Drawing.Size(56, 51);
            this.cnlButton.TabIndex = 13;
            this.cnlButton.UseVisualStyleBackColor = true;
            // 
            // Availability_Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.extButton);
            this.Controls.Add(this.bckButton);
            this.Controls.Add(this.nxtButton);
            this.Controls.Add(this.cnlButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Availability_Check";
            this.Text = "Availability Check";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button extButton;
        private System.Windows.Forms.Button bckButton;
        private System.Windows.Forms.Button nxtButton;
        private System.Windows.Forms.Button cnlButton;
    }
}