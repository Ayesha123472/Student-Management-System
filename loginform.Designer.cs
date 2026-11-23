namespace Student_System
{
    partial class loginform
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
            this.Cardpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picturelogo = new System.Windows.Forms.PictureBox();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.pnlUserContainer = new System.Windows.Forms.Panel();
            this.lblUserIcon = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlPassContainer = new System.Windows.Forms.Panel();
            this.lblPassIcon = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.Cardpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogo)).BeginInit();
            this.pnlUserContainer.SuspendLayout();
            this.pnlPassContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cardpanel
            // 
            this.Cardpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.Cardpanel.Controls.Add(this.pictureBox1);
            this.Cardpanel.Controls.Add(this.picturelogo);
            this.Cardpanel.Controls.Add(this.lblSystemTitle);
            this.Cardpanel.Controls.Add(this.lblSignIn);
            this.Cardpanel.Controls.Add(this.pnlUserContainer);
            this.Cardpanel.Controls.Add(this.pnlPassContainer);
            this.Cardpanel.Controls.Add(this.btnLogin);
            this.Cardpanel.Location = new System.Drawing.Point(56, 62);
            this.Cardpanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cardpanel.Name = "Cardpanel";
            this.Cardpanel.Size = new System.Drawing.Size(788, 500);
            this.Cardpanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Student_System.Properties.Resources.icons8_graduation_cap_100;
            this.pictureBox1.Location = new System.Drawing.Point(75, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // picturelogo
            // 
            this.picturelogo.BackColor = System.Drawing.Color.Transparent;
            this.picturelogo.Location = new System.Drawing.Point(34, 62);
            this.picturelogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picturelogo.Name = "picturelogo";
            this.picturelogo.Size = new System.Drawing.Size(270, 250);
            this.picturelogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturelogo.TabIndex = 0;
            this.picturelogo.TabStop = false;
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSystemTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblSystemTitle.Location = new System.Drawing.Point(28, 340);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(292, 104);
            this.lblSystemTitle.TabIndex = 1;
            this.lblSystemTitle.Text = "Student Management System";
            this.lblSystemTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSignIn.ForeColor = System.Drawing.Color.White;
            this.lblSignIn.Location = new System.Drawing.Point(394, 50);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(153, 54);
            this.lblSignIn.TabIndex = 2;
            this.lblSignIn.Text = "Sign In";
            // 
            // pnlUserContainer
            // 
            this.pnlUserContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlUserContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserContainer.Controls.Add(this.lblUserIcon);
            this.pnlUserContainer.Controls.Add(this.txtUsername);
            this.pnlUserContainer.Location = new System.Drawing.Point(398, 131);
            this.pnlUserContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlUserContainer.Name = "pnlUserContainer";
            this.pnlUserContainer.Size = new System.Drawing.Size(326, 52);
            this.pnlUserContainer.TabIndex = 3;
            // 
            // lblUserIcon
            // 
            this.lblUserIcon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUserIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblUserIcon.Location = new System.Drawing.Point(6, 8);
            this.lblUserIcon.Name = "lblUserIcon";
            this.lblUserIcon.Size = new System.Drawing.Size(34, 35);
            this.lblUserIcon.TabIndex = 0;
            this.lblUserIcon.Text = "👤";
            this.lblUserIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(45, 10);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(270, 30);
            this.txtUsername.TabIndex = 1;
            // 
            // pnlPassContainer
            // 
            this.pnlPassContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlPassContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPassContainer.Controls.Add(this.lblPassIcon);
            this.pnlPassContainer.Controls.Add(this.txtPassword);
            this.pnlPassContainer.Location = new System.Drawing.Point(398, 206);
            this.pnlPassContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlPassContainer.Name = "pnlPassContainer";
            this.pnlPassContainer.Size = new System.Drawing.Size(326, 52);
            this.pnlPassContainer.TabIndex = 4;
            // 
            // lblPassIcon
            // 
            this.lblPassIcon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPassIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPassIcon.Location = new System.Drawing.Point(6, 8);
            this.lblPassIcon.Name = "lblPassIcon";
            this.lblPassIcon.Size = new System.Drawing.Size(34, 35);
            this.lblPassIcon.TabIndex = 0;
            this.lblPassIcon.Text = "🔒";
            this.lblPassIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(45, 10);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(270, 30);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnLogin.Location = new System.Drawing.Point(403, 300);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(326, 55);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(900, 678);
            this.Controls.Add(this.Cardpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginform";
            this.Cardpanel.ResumeLayout(false);
            this.Cardpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogo)).EndInit();
            this.pnlUserContainer.ResumeLayout(false);
            this.pnlUserContainer.PerformLayout();
            this.pnlPassContainer.ResumeLayout(false);
            this.pnlPassContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Cardpanel;
        private System.Windows.Forms.PictureBox picturelogo;
        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Panel pnlUserContainer;
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlPassContainer;
        private System.Windows.Forms.Label lblPassIcon;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}