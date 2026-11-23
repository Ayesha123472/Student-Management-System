namespace Student_System
{
    partial class CoursesForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblSection;

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseFee;
        private System.Windows.Forms.Label txtFee;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label txtTeacher;
        private System.Windows.Forms.TextBox txtTeacherID;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

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

            this.btnClear = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseFee = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTeacher = new System.Windows.Forms.Label();
            this.txtTeacherID = new System.Windows.Forms.TextBox();

            this.headerPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();

            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "CoursesForm";
            this.Text = "Course Management";
            this.Load += new System.EventHandler(this.CoursesForm_Load);

            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(23, 37, 84);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(900, 125);
            this.headerPanel.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(42, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Course Management";

            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor =
                System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblSubtitle.Location = new System.Drawing.Point(47, 76);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text =
                "Student Management System  |  Course Information";

            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);

            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Location = new System.Drawing.Point(40, 150);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(820, 460);
            this.formPanel.TabIndex = 1;

            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font(
                "Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSection.ForeColor =
                System.Drawing.Color.FromArgb(23, 37, 84);
            this.lblSection.Location = new System.Drawing.Point(35, 20);
            this.lblSection.Name = "lblSection";
            this.lblSection.Text = "Course Details";

            // 
            // Common control styling
            // 
            System.Drawing.Font labelFont = new System.Drawing.Font(
                "Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);

            System.Drawing.Font inputFont =
                new System.Drawing.Font("Segoe UI", 11F);

            System.Drawing.Color labelColor =
                System.Drawing.Color.FromArgb(51, 65, 85);

            System.Drawing.Color inputColor =
                System.Drawing.Color.FromArgb(248, 250, 252);

            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = labelFont;
            this.txtID.ForeColor = labelColor;
            this.txtID.Location = new System.Drawing.Point(40, 88);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 25);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "Course ID";

            // 
            // txtCourseID
            // 
            this.txtCourseID.Font = inputFont;
            this.txtCourseID.ForeColor =
                System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtCourseID.BackColor = inputColor;
            this.txtCourseID.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCourseID.Location = new System.Drawing.Point(260, 84);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(500, 32);
            this.txtCourseID.TabIndex = 2;

            // 
            // txtTeacher
            // 
            this.txtTeacher.AutoSize = true;
            this.txtTeacher.Font = labelFont;
            this.txtTeacher.ForeColor = labelColor;
            this.txtTeacher.Location = new System.Drawing.Point(40, 158);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(100, 25);
            this.txtTeacher.TabIndex = 3;
            this.txtTeacher.Text = "Teacher ID";

            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Font = inputFont;
            this.txtTeacherID.ForeColor =
                System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtTeacherID.BackColor = inputColor;
            this.txtTeacherID.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTeacherID.Location = new System.Drawing.Point(260, 154);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(500, 32);
            this.txtTeacherID.TabIndex = 4;

            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = labelFont;
            this.c.ForeColor = labelColor;
            this.c.Location = new System.Drawing.Point(40, 228);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(120, 25);
            this.c.TabIndex = 5;
            this.c.Text = "Course Name";

            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = inputFont;
            this.txtCourseName.ForeColor =
                System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtCourseName.BackColor = inputColor;
            this.txtCourseName.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCourseName.Location = new System.Drawing.Point(260, 224);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(500, 32);
            this.txtCourseName.TabIndex = 6;
            this.txtCourseName.TextChanged +=
                new System.EventHandler(this.textBox1_TextChanged);

            // 
            // txtFee
            // 
            this.txtFee.AutoSize = true;
            this.txtFee.Font = labelFont;
            this.txtFee.ForeColor = labelColor;
            this.txtFee.Location = new System.Drawing.Point(40, 298);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(110, 25);
            this.txtFee.TabIndex = 7;
            this.txtFee.Text = "Course Fee";

            // 
            // txtCourseFee
            // 
            this.txtCourseFee.Font = inputFont;
            this.txtCourseFee.ForeColor =
                System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtCourseFee.BackColor = inputColor;
            this.txtCourseFee.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCourseFee.Location = new System.Drawing.Point(260, 294);
            this.txtCourseFee.Name = "txtCourseFee";
            this.txtCourseFee.Size = new System.Drawing.Size(500, 32);
            this.txtCourseFee.TabIndex = 8;
            this.txtCourseFee.TextChanged +=
                new System.EventHandler(this.txtCourseFee_TextChanged);

            // 
            // btnSave
            // 
            this.btnSave.BackColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(430, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 48);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save Course";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click +=
                new System.EventHandler(this.btnSave_Click);

            // 
            // btnClear
            // 
            this.btnClear.BackColor =
                System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor =
                System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnClear.Location = new System.Drawing.Point(600, 375);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 48);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click +=
                new System.EventHandler(this.btnClear_Click);

            // 
            // Add controls to formPanel
            // 
            this.formPanel.Controls.Add(this.lblSection);
            this.formPanel.Controls.Add(this.txtID);
            this.formPanel.Controls.Add(this.txtCourseID);
            this.formPanel.Controls.Add(this.txtTeacher);
            this.formPanel.Controls.Add(this.txtTeacherID);
            this.formPanel.Controls.Add(this.c);
            this.formPanel.Controls.Add(this.txtCourseName);
            this.formPanel.Controls.Add(this.txtFee);
            this.formPanel.Controls.Add(this.txtCourseFee);
            this.formPanel.Controls.Add(this.btnSave);
            this.formPanel.Controls.Add(this.btnClear);

            // 
            // Add panels to form
            // 
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.headerPanel);

            // 
            // Finish layout
            // 
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
