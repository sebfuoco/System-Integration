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
            this.extButton = new System.Windows.Forms.Button();
            this.userSearch = new System.Windows.Forms.Button();
            this.mgrButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // extButton
            // 
            this.extButton.Location = new System.Drawing.Point(12, 405);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(138, 33);
            this.extButton.TabIndex = 0;
            this.extButton.Text = "X";
            this.extButton.UseVisualStyleBackColor = true;
            this.extButton.Click += new System.EventHandler(this.extButton_Click);
            // 
            // userSearch
            // 
            this.userSearch.Location = new System.Drawing.Point(330, 167);
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(138, 33);
            this.userSearch.TabIndex = 1;
            this.userSearch.Text = "Holiday Search";
            this.userSearch.UseVisualStyleBackColor = true;
            this.userSearch.Click += new System.EventHandler(this.userSearch_Click);
            // 
            // mgrButton
            // 
            this.mgrButton.Location = new System.Drawing.Point(331, 209);
            this.mgrButton.Name = "mgrButton";
            this.mgrButton.Size = new System.Drawing.Size(138, 33);
            this.mgrButton.TabIndex = 2;
            this.mgrButton.Text = "Manager";
            this.mgrButton.UseVisualStyleBackColor = true;
            this.mgrButton.Click += new System.EventHandler(this.mgrButton_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mgrButton);
            this.Controls.Add(this.userSearch);
            this.Controls.Add(this.extButton);
            this.Name = "main";
            this.Text = "Holiday Booking System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button extButton;
        private System.Windows.Forms.Button userSearch;
        private System.Windows.Forms.Button mgrButton;
    }
}

