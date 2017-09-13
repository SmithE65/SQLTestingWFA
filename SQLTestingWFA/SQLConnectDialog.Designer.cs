namespace SQLTestingWFA
{
    partial class SQLConnectDialog
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
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.TrustedConnLabel = new System.Windows.Forms.Label();
            this.TrustedConnectionCheck = new System.Windows.Forms.CheckBox();
            this.Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(69, 15);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(46, 13);
            this.UserIdLabel.TabIndex = 0;
            this.UserIdLabel.Text = "User ID:";
            this.UserIdLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(62, 41);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(121, 12);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(155, 20);
            this.UserIdTextBox.TabIndex = 2;
            this.UserIdTextBox.Text = "STUDENT05\\Max-Student";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(121, 38);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(155, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(121, 64);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(155, 20);
            this.ServerTextBox.TabIndex = 4;
            this.ServerTextBox.Text = "localhost";
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(74, 67);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(41, 13);
            this.ServerLabel.TabIndex = 5;
            this.ServerLabel.Text = "Server:";
            this.ServerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TrustedConnLabel
            // 
            this.TrustedConnLabel.AutoSize = true;
            this.TrustedConnLabel.Location = new System.Drawing.Point(15, 91);
            this.TrustedConnLabel.Name = "TrustedConnLabel";
            this.TrustedConnLabel.Size = new System.Drawing.Size(103, 13);
            this.TrustedConnLabel.TabIndex = 6;
            this.TrustedConnLabel.Text = "Trusted Connection:";
            this.TrustedConnLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TrustedConnectionCheck
            // 
            this.TrustedConnectionCheck.AutoSize = true;
            this.TrustedConnectionCheck.Checked = true;
            this.TrustedConnectionCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TrustedConnectionCheck.Location = new System.Drawing.Point(124, 90);
            this.TrustedConnectionCheck.Name = "TrustedConnectionCheck";
            this.TrustedConnectionCheck.Size = new System.Drawing.Size(15, 14);
            this.TrustedConnectionCheck.TabIndex = 7;
            this.TrustedConnectionCheck.UseVisualStyleBackColor = true;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(301, 81);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 8;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // SQLConnectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 116);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.TrustedConnectionCheck);
            this.Controls.Add(this.TrustedConnLabel);
            this.Controls.Add(this.ServerLabel);
            this.Controls.Add(this.ServerTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserIdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SQLConnectDialog";
            this.Text = "Connect to SQL Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.Label TrustedConnLabel;
        private System.Windows.Forms.CheckBox TrustedConnectionCheck;
        private System.Windows.Forms.Button Connect;
    }
}