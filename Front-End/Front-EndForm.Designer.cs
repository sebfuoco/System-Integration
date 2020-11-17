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
            this.userSearch = new System.Windows.Forms.Button();
            this.mgrButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.extButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userSearch
            // 
            this.userSearch.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSearch.Location = new System.Drawing.Point(475, 191);
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(248, 48);
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
            this.mgrButton.Size = new System.Drawing.Size(248, 48);
            this.mgrButton.TabIndex = 2;
            this.mgrButton.Text = "Admin Log in";
            this.mgrButton.UseVisualStyleBackColor = true;
            this.mgrButton.Click += new System.EventHandler(this.mgrButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // extButton
            // 
            this.extButton.BackColor = System.Drawing.Color.Transparent;
            this.extButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extButton.Location = new System.Drawing.Point(770, -1);
            this.extButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(32, 29);
            this.extButton.TabIndex = 8;
            this.extButton.Text = "X";
            this.extButton.UseVisualStyleBackColor = false;
            this.extButton.Click += new System.EventHandler(this.extButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 17.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "Holiday Booking System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 47);
            this.label1.TabIndex = 10;
            this.label1.Text = "Perfect Get Away";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.extButton);
            this.Controls.Add(this.mgrButton);
            this.Controls.Add(this.userSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Holiday Booking System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button userSearch;
        private System.Windows.Forms.Button mgrButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button extButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

