
namespace Student_System
{
    partial class Update_form
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblSection;

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.formPanel = new System.Windows.Forms.Panel();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();

            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();

            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();

            this.label5 = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();

            this.label7 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();

            this.label10 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();

            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();

            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();

            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();

            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.headerPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();

            // FORM
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(850, 720);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Update_form";
            this.Text = "Update Student | Student Management System";
            this.Load += new System.EventHandler(this.Update_form_Load);

            // HEADER PANEL
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(23, 37, 84);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Size = new System.Drawing.Size(850, 125);
            this.headerPanel.Name = "headerPanel";

            // TITLE
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(42, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Update Student";

            // SUBTITLE
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblSubtitle.Location = new System.Drawing.Point(47, 76);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Student Management System  |  Update Student Information";

            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);

            // FORM PANEL
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Location = new System.Drawing.Point(42, 150);
            this.formPanel.Size = new System.Drawing.Size(766, 530);
            this.formPanel.Name = "formPanel";

            // SECTION TITLE
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font(
                "Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSection.ForeColor = System.Drawing.Color.FromArgb(23, 37, 84);
            this.lblSection.Location = new System.Drawing.Point(38, 18);
            this.lblSection.Text = "Student Details";

            // COMMON STYLES
            System.Drawing.Font labelFont =
                new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);

            System.Drawing.Font inputFont =
                new System.Drawing.Font("Segoe UI", 10.5F);

            System.Drawing.Color labelColor =
                System.Drawing.Color.FromArgb(51, 65, 85);

            System.Drawing.Color inputColor =
                System.Drawing.Color.FromArgb(248, 250, 252);

            // STUDENT ID
            this.label1.AutoSize = true;
            this.label1.Font = labelFont;
            this.label1.ForeColor = labelColor;
            this.label1.Location = new System.Drawing.Point(40, 75);
            this.label1.Text = "Student ID:";

            this.txtStudentID.Font = inputFont;
            this.txtStudentID.BackColor = inputColor;
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentID.Location = new System.Drawing.Point(230, 72);
            this.txtStudentID.Size = new System.Drawing.Size(340, 32);
            this.txtStudentID.Name = "txtStudentID";

            // SEARCH BUTTON
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(585, 68);
            this.btnSearch.Size = new System.Drawing.Size(130, 42);
            this.btnSearch.Text = "Search";
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Click +=
                new System.EventHandler(this.btnSearch_Click);

            // STUDENT NAME
            this.label3.AutoSize = true;
            this.label3.Font = labelFont;
            this.label3.ForeColor = labelColor;
            this.label3.Location = new System.Drawing.Point(40, 140);
            this.label3.Text = "Student Name:";

            this.txtStudentName.Font = inputFont;
            this.txtStudentName.BackColor = inputColor;
            this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentName.Location = new System.Drawing.Point(230, 137);
            this.txtStudentName.Size = new System.Drawing.Size(485, 32);
            this.txtStudentName.Name = "txtStudentName";

            // FATHER NAME
            this.label5.AutoSize = true;
            this.label5.Font = labelFont;
            this.label5.ForeColor = labelColor;
            this.label5.Location = new System.Drawing.Point(40, 198);
            this.label5.Text = "Father Name:";

            this.txtFatherName.Font = inputFont;
            this.txtFatherName.BackColor = inputColor;
            this.txtFatherName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFatherName.Location = new System.Drawing.Point(230, 195);
            this.txtFatherName.Size = new System.Drawing.Size(485, 32);
            this.txtFatherName.Name = "txtFatherName";

            // AGE
            this.label7.AutoSize = true;
            this.label7.Font = labelFont;
            this.label7.ForeColor = labelColor;
            this.label7.Location = new System.Drawing.Point(40, 256);
            this.label7.Text = "Age:";

            this.txtAge.Font = inputFont;
            this.txtAge.BackColor = inputColor;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Location = new System.Drawing.Point(230, 253);
            this.txtAge.Size = new System.Drawing.Size(485, 32);
            this.txtAge.Name = "txtAge";

            // GENDER
            this.label10.AutoSize = true;
            this.label10.Font = labelFont;
            this.label10.ForeColor = labelColor;
            this.label10.Location = new System.Drawing.Point(40, 314);
            this.label10.Text = "Gender:";

            this.cmbGender.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = inputFont;
            this.cmbGender.BackColor = inputColor;
            this.cmbGender.Items.AddRange(new object[] {
                "Male", "Female"
            });
            this.cmbGender.Location = new System.Drawing.Point(230, 311);
            this.cmbGender.Size = new System.Drawing.Size(485, 32);
            this.cmbGender.Name = "cmbGender";

            // PHONE
            this.label8.AutoSize = true;
            this.label8.Font = labelFont;
            this.label8.ForeColor = labelColor;
            this.label8.Location = new System.Drawing.Point(40, 372);
            this.label8.Text = "Phone:";

            this.txtPhone.Font = inputFont;
            this.txtPhone.BackColor = inputColor;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(230, 369);
            this.txtPhone.Size = new System.Drawing.Size(485, 32);
            this.txtPhone.Name = "txtPhone";

            // ADDRESS
            this.label9.AutoSize = true;
            this.label9.Font = labelFont;
            this.label9.ForeColor = labelColor;
            this.label9.Location = new System.Drawing.Point(40, 430);
            this.label9.Text = "Address:";

            this.txtAddress.Font = inputFont;
            this.txtAddress.BackColor = inputColor;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(230, 427);
            this.txtAddress.Size = new System.Drawing.Size(485, 38);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";

            // UNUSED LABELS - KEPT FOR COMPATIBILITY
            this.label4.AutoSize = true;
            this.label4.Name = "label4";

            this.label6.AutoSize = true;
            this.label6.Name = "label6";

            // UPDATE BUTTON
            this.btnUpdateStudent.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.FlatAppearance.BorderSize = 0;
            this.btnUpdateStudent.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(21, 128, 61);
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStudent.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStudent.Location = new System.Drawing.Point(425, 475);
            this.btnUpdateStudent.Size = new System.Drawing.Size(165, 42);
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Click +=
                new System.EventHandler(this.btnUpdate_Click_1);

            // CLEAR BUTTON
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnClear.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(600, 475);
            this.btnClear.Size = new System.Drawing.Size(115, 42);
            this.btnClear.Text = "Clear";
            this.btnClear.Name = "btnClear";
            this.btnClear.Click +=
                new System.EventHandler(this.btnClear_Click);

            // ADD CONTROLS TO PANEL
            this.formPanel.Controls.Add(this.lblSection);
            this.formPanel.Controls.Add(this.label1);
            this.formPanel.Controls.Add(this.txtStudentID);
            this.formPanel.Controls.Add(this.btnSearch);
            this.formPanel.Controls.Add(this.label3);
            this.formPanel.Controls.Add(this.txtStudentName);
            this.formPanel.Controls.Add(this.label5);
            this.formPanel.Controls.Add(this.txtFatherName);
            this.formPanel.Controls.Add(this.label7);
            this.formPanel.Controls.Add(this.txtAge);
            this.formPanel.Controls.Add(this.label10);
            this.formPanel.Controls.Add(this.cmbGender);
            this.formPanel.Controls.Add(this.label8);
            this.formPanel.Controls.Add(this.txtPhone);
            this.formPanel.Controls.Add(this.label9);
            this.formPanel.Controls.Add(this.txtAddress);
            this.formPanel.Controls.Add(this.btnUpdateStudent);
            this.formPanel.Controls.Add(this.btnClear);

            // ADD PANELS
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.headerPanel);

            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();

            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();

            this.ResumeLayout(false);
        }
    }
}
