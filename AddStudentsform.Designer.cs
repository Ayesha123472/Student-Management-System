namespace Student_System
{
    partial class AddStudentsform
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblSection;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.formPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();

            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();

            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.headerPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(850, 700);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "AddStudentsform";
            this.Text = "Add Student | Student Management System";
            this.Load += new System.EventHandler(this.AddStudentsform_Load);

            // Header panel
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(23, 37, 84);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(850, 125);

            // Header title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(42, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Add New Student";

            // Header subtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblSubtitle.Location = new System.Drawing.Point(47, 76);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Student Management System  |  Student Information";

            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);

            // White content panel
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Location = new System.Drawing.Point(42, 150);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(766, 520);

            // Section title
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSection.ForeColor = System.Drawing.Color.FromArgb(23, 37, 84);
            this.lblSection.Location = new System.Drawing.Point(38, 20);
            this.lblSection.Name = "lblSection";
            this.lblSection.Text = "Student Details";

            // Common styling
            System.Drawing.Font labelFont =
                new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);

            System.Drawing.Color labelColor =
                System.Drawing.Color.FromArgb(51, 65, 85);

            System.Drawing.Font inputFont =
                new System.Drawing.Font("Segoe UI", 11F);

            System.Drawing.Color inputBackground =
                System.Drawing.Color.FromArgb(248, 250, 252);

            // Student Name label
            this.label2.AutoSize = true;
            this.label2.Font = labelFont;
            this.label2.ForeColor = labelColor;
            this.label2.Location = new System.Drawing.Point(40, 76);
            this.label2.Name = "label2";
            this.label2.Text = "Student Name";

            // Father Name label
            this.label3.AutoSize = true;
            this.label3.Font = labelFont;
            this.label3.ForeColor = labelColor;
            this.label3.Location = new System.Drawing.Point(40, 136);
            this.label3.Name = "label3";
            this.label3.Text = "Father Name";

            // Age label
            this.label4.AutoSize = true;
            this.label4.Font = labelFont;
            this.label4.ForeColor = labelColor;
            this.label4.Location = new System.Drawing.Point(40, 196);
            this.label4.Name = "label4";
            this.label4.Text = "Age";

            // Gender label
            this.label5.AutoSize = true;
            this.label5.Font = labelFont;
            this.label5.ForeColor = labelColor;
            this.label5.Location = new System.Drawing.Point(40, 256);
            this.label5.Name = "label5";
            this.label5.Text = "Gender";

            // Phone label
            this.label6.AutoSize = true;
            this.label6.Font = labelFont;
            this.label6.ForeColor = labelColor;
            this.label6.Location = new System.Drawing.Point(40, 316);
            this.label6.Name = "label6";
            this.label6.Text = "Phone Number";

            // Address label
            this.label7.AutoSize = true;
            this.label7.Font = labelFont;
            this.label7.ForeColor = labelColor;
            this.label7.Location = new System.Drawing.Point(40, 376);
            this.label7.Name = "label7";
            this.label7.Text = "Address";

            // Student Name textbox
            this.txtStudentName.Font = inputFont;
            this.txtStudentName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtStudentName.BackColor = inputBackground;
            this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentName.Location = new System.Drawing.Point(255, 72);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(460, 32);
            this.txtStudentName.TabIndex = 0;

            // Father Name textbox
            this.txtFatherName.Font = inputFont;
            this.txtFatherName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtFatherName.BackColor = inputBackground;
            this.txtFatherName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFatherName.Location = new System.Drawing.Point(255, 132);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(460, 32);
            this.txtFatherName.TabIndex = 1;

            // Age textbox
            this.txtAge.Font = inputFont;
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtAge.BackColor = inputBackground;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Location = new System.Drawing.Point(255, 192);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(460, 32);
            this.txtAge.TabIndex = 2;

            // Gender dropdown
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = inputFont;
            this.cmbGender.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cmbGender.BackColor = inputBackground;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            this.cmbGender.Location = new System.Drawing.Point(255, 252);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(460, 33);
            this.cmbGender.TabIndex = 3;

            // Phone textbox
            this.txtPhone.Font = inputFont;
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtPhone.BackColor = inputBackground;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(255, 312);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(460, 32);
            this.txtPhone.TabIndex = 4;

            // Address textbox
            this.txtAddress.Font = inputFont;
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtAddress.BackColor = inputBackground;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(255, 372);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(460, 55);
            this.txtAddress.TabIndex = 5;

            // Save button
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(425, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 42);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Student";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Clear button
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnClear.Location = new System.Drawing.Point(580, 452);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 42);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Add controls to panel
            this.formPanel.Controls.Add(this.lblSection);
            this.formPanel.Controls.Add(this.label2);
            this.formPanel.Controls.Add(this.label3);
            this.formPanel.Controls.Add(this.label4);
            this.formPanel.Controls.Add(this.label5);
            this.formPanel.Controls.Add(this.label6);
            this.formPanel.Controls.Add(this.label7);

            this.formPanel.Controls.Add(this.txtStudentName);
            this.formPanel.Controls.Add(this.txtFatherName);
            this.formPanel.Controls.Add(this.txtAge);
            this.formPanel.Controls.Add(this.cmbGender);
            this.formPanel.Controls.Add(this.txtPhone);
            this.formPanel.Controls.Add(this.txtAddress);

            this.formPanel.Controls.Add(this.btnSave);
            this.formPanel.Controls.Add(this.btnClear);

            // Add panels to form
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.headerPanel);

            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
