namespace Front_End
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.extButton = new System.Windows.Forms.Button();
            this.userSearch = new System.Windows.Forms.Button();
            this.mgrButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // extButton
            // 
            this.extButton.Location = new System.Drawing.Point(734, 0);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(69, 40);
            this.extButton.TabIndex = 0;
            this.extButton.Text = "Exit Application";
            this.extButton.UseVisualStyleBackColor = true;
            this.extButton.Click += new System.EventHandler(this.extButton_Click);
            // 
            // userSearch
            // 
            this.userSearch.Location = new System.Drawing.Point(515, 251);
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(236, 45);
            this.userSearch.TabIndex = 1;
            this.userSearch.Text = "Holiday Search";
            this.userSearch.UseVisualStyleBackColor = true;
            this.userSearch.Click += new System.EventHandler(this.userSearch_Click);
            // 
            // mgrButton
            // 
            this.mgrButton.Location = new System.Drawing.Point(515, 302);
            this.mgrButton.Name = "mgrButton";
            this.mgrButton.Size = new System.Drawing.Size(236, 48);
            this.mgrButton.TabIndex = 2;
            this.mgrButton.Text = "Manager";
            this.mgrButton.UseVisualStyleBackColor = true;
            this.mgrButton.Click += new System.EventHandler(this.mgrButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Holiday Booking System";
            // 
            // main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mgrButton);
            this.Controls.Add(this.userSearch);
            this.Controls.Add(this.extButton);
            this.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.Text = "Holiday Booking System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button extButton;
        private System.Windows.Forms.Button userSearch;
        private System.Windows.Forms.Button mgrButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

