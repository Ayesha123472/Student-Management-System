namespace Student_System
{
    partial class AttendenceForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblSection;

        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label txtStudentStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label txtDateTimePicker;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveAttendance;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtStudentID;

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

            this.txtID = new System.Windows.Forms.Label();
            this.txtStudentStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtDateTimePicker = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveAttendance = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtStudentID = new System.Windows.Forms.TextBox();

            this.headerPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();

            // 
            // AttendenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "AttendenceForm";
            this.Text = "Attendance | Student Management System";

            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(23, 37, 84);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(850, 125);
            this.headerPanel.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(42, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Student Attendance";

            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblSubtitle.Location = new System.Drawing.Point(47, 76);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Student Management System  |  Attendance Records";

            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);

            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Location = new System.Drawing.Point(42, 150);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(766, 460);
            this.formPanel.TabIndex = 1;

            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font(
                "Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSection.ForeColor = System.Drawing.Color.FromArgb(23, 37, 84);
            this.lblSection.Location = new System.Drawing.Point(38, 22);
            this.lblSection.Name = "lblSection";
            this.lblSection.Text = "Attendance Details";

            // 
            // Common styling
            // 
            System.Drawing.Font labelFont = new System.Drawing.Font(
                "Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);

            System.Drawing.Color labelColor =
                System.Drawing.Color.FromArgb(51, 65, 85);

            System.Drawing.Font inputFont =
                new System.Drawing.Font("Segoe UI", 11F);

            System.Drawing.Color inputBackground =
                System.Drawing.Color.FromArgb(248, 250, 252);

            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = labelFont;
            this.txtID.ForeColor = labelColor;
            this.txtID.Location = new System.Drawing.Point(40, 95);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(0, 25);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "Student ID";

            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = inputFont;
            this.txtStudentID.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtStudentID.BackColor = inputBackground;
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentID.Location = new System.Drawing.Point(255, 91);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(460, 32);
            this.txtStudentID.TabIndex = 1;

            // 
            // txtStudentStatus
            // 
            this.txtStudentStatus.AutoSize = true;
            this.txtStudentStatus.Font = labelFont;
            this.txtStudentStatus.ForeColor = labelColor;
            this.txtStudentStatus.Location = new System.Drawing.Point(40, 165);
            this.txtStudentStatus.Name = "txtStudentStatus";
            this.txtStudentStatus.Size = new System.Drawing.Size(0, 25);
            this.txtStudentStatus.TabIndex = 2;
            this.txtStudentStatus.Text = "Attendance Status";

            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = inputFont;
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cmbStatus.BackColor = inputBackground;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[]
            {
                "Present",
                "Absent",
                "Late"
            });
            this.cmbStatus.Location = new System.Drawing.Point(255, 161);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(460, 33);
            this.cmbStatus.TabIndex = 3;

            // 
            // txtDateTimePicker
            // 
            this.txtDateTimePicker.AutoSize = true;
            this.txtDateTimePicker.Font = labelFont;
            this.txtDateTimePicker.ForeColor = labelColor;
            this.txtDateTimePicker.Location = new System.Drawing.Point(40, 235);
            this.txtDateTimePicker.Name = "txtDateTimePicker";
            this.txtDateTimePicker.Size = new System.Drawing.Size(0, 25);
            this.txtDateTimePicker.TabIndex = 4;
            this.txtDateTimePicker.Text = "Attendance Date";

            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = inputFont;
            this.dtpDate.Font = inputFont;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(255, 231);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(460, 32);
            this.dtpDate.TabIndex = 5;

            // 
            // btnSaveAttendance
            // 
            this.btnSaveAttendance.BackColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSaveAttendance.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAttendance.FlatAppearance.BorderSize = 0;
            this.btnSaveAttendance.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnSaveAttendance.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnSaveAttendance.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSaveAttendance.ForeColor = System.Drawing.Color.White;
            this.btnSaveAttendance.Location = new System.Drawing.Point(365, 365);
            this.btnSaveAttendance.Name = "btnSaveAttendance";
            this.btnSaveAttendance.Size = new System.Drawing.Size(195, 48);
            this.btnSaveAttendance.TabIndex = 6;
            this.btnSaveAttendance.Text = "Save Attendance";
            this.btnSaveAttendance.UseVisualStyleBackColor = false;

            // 
            // btnClear
            // 
            this.btnClear.BackColor =
                System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnClear.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClear.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor =
                System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnClear.Location = new System.Drawing.Point(580, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 48);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click +=
                new System.EventHandler(this.btnClear_Click_1);

            // 
            // Add controls to formPanel
            // 
            this.formPanel.Controls.Add(this.lblSection);
            this.formPanel.Controls.Add(this.txtID);
            this.formPanel.Controls.Add(this.txtStudentID);
            this.formPanel.Controls.Add(this.txtStudentStatus);
            this.formPanel.Controls.Add(this.cmbStatus);
            this.formPanel.Controls.Add(this.txtDateTimePicker);
            this.formPanel.Controls.Add(this.dtpDate);
            this.formPanel.Controls.Add(this.btnSaveAttendance);
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
