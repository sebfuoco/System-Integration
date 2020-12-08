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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.cnlButton = new System.Windows.Forms.Button();
            this.lgnButton = new System.Windows.Forms.Button();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cnlButton
            // 
            this.cnlButton.BackColor = System.Drawing.Color.Transparent;
            this.cnlButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cnlButton.BackgroundImage")));
            this.cnlButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cnlButton.FlatAppearance.BorderSize = 0;
            this.cnlButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnlButton.Location = new System.Drawing.Point(47, 457);
            this.cnlButton.Margin = new System.Windows.Forms.Padding(2);
            this.cnlButton.Name = "cnlButton";
            this.cnlButton.Size = new System.Drawing.Size(97, 33);
            this.cnlButton.TabIndex = 2;
            this.cnlButton.Text = "Cancel";
            this.cnlButton.UseVisualStyleBackColor = false;
            this.cnlButton.Click += new System.EventHandler(this.cnlButton_Click);
            // 
            // lgnButton
            // 
            this.lgnButton.BackColor = System.Drawing.Color.LightSalmon;
            this.lgnButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lgnButton.BackgroundImage")));
            this.lgnButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon;
            this.lgnButton.FlatAppearance.BorderSize = 3;
            this.lgnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgnButton.Font = new System.Drawing.Font("Century Gothic", 18.8F, System.Drawing.FontStyle.Bold);
            this.lgnButton.Location = new System.Drawing.Point(354, 284);
            this.lgnButton.Margin = new System.Windows.Forms.Padding(2);
            this.lgnButton.Name = "lgnButton";
            this.lgnButton.Size = new System.Drawing.Size(167, 45);
            this.lgnButton.TabIndex = 1;
            this.lgnButton.Text = "Login";
            this.lgnButton.UseVisualStyleBackColor = false;
            this.lgnButton.Click += new System.EventHandler(this.lgnButton_Click);
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(355, 196);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(168, 20);
            this.usernametxt.TabIndex = 4;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(354, 245);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(168, 20);
            this.passwordtxt.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 107);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Manager Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(351, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(351, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 514);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.lgnButton);
            this.Controls.Add(this.cnlButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manager";
            this.Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cnlButton;
        private System.Windows.Forms.Button lgnButton;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}