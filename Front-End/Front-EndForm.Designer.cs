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
            this.extButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extButton.Location = new System.Drawing.Point(732, -1);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(51, 40);
            this.extButton.TabIndex = 0;
            this.extButton.Text = "X";
            this.extButton.UseVisualStyleBackColor = true;
            this.extButton.Click += new System.EventHandler(this.extButton_Click);
            // 
            // userSearch
            // 
            this.userSearch.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSearch.Location = new System.Drawing.Point(475, 191);
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(248, 61);
            this.userSearch.TabIndex = 1;
            this.userSearch.Text = "Holiday Search";
            this.userSearch.UseVisualStyleBackColor = true;
            this.userSearch.Click += new System.EventHandler(this.userSearch_Click);
            // 
            // mgrButton
            // 
            this.mgrButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mgrButton.Location = new System.Drawing.Point(475, 281);
            this.mgrButton.Name = "mgrButton";
            this.mgrButton.Size = new System.Drawing.Size(248, 61);
            this.mgrButton.TabIndex = 2;
            this.mgrButton.Text = "Manager";
            this.mgrButton.UseVisualStyleBackColor = true;
            this.mgrButton.Click += new System.EventHandler(this.mgrButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Holiday Booking System";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mgrButton);
            this.Controls.Add(this.userSearch);
            this.Controls.Add(this.extButton);
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

