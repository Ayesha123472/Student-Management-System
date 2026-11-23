namespace Student_System
{
    partial class Dashboardform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnViewTeacher = new System.Windows.Forms.Button();
            this.btnUpdateTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();

            this.panel1 = new System.Windows.Forms.Panel();

            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnAttendence = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();

            this.label1 = new System.Windows.Forms.Label();

            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();

            this.panelStudent = new System.Windows.Forms.Panel();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnViewStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();

            this.panelTeacher = new System.Windows.Forms.Panel();

            this.panel1.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.panelTeacher.SuspendLayout();
            this.SuspendLayout();

            // ==============================
            // COLORS
            // ==============================

            System.Drawing.Color background =
                System.Drawing.Color.FromArgb(15, 23, 42);

            System.Drawing.Color sidebar =
                System.Drawing.Color.FromArgb(17, 24, 39);

            System.Drawing.Color sidebarButton =
                System.Drawing.Color.FromArgb(31, 41, 55);

            System.Drawing.Color accent =
                System.Drawing.Color.FromArgb(14, 165, 233);

            System.Drawing.Color accentDark =
                System.Drawing.Color.FromArgb(2, 132, 199);

            System.Drawing.Color card =
                System.Drawing.Color.FromArgb(30, 41, 59);

            System.Drawing.Color cardBorder =
                System.Drawing.Color.FromArgb(51, 65, 85);

            System.Drawing.Color white =
                System.Drawing.Color.White;

            System.Drawing.Color lightText =
                System.Drawing.Color.FromArgb(203, 213, 225);

            System.Drawing.Color mutedText =
                System.Drawing.Color.FromArgb(148, 163, 184);

            System.Drawing.Color danger =
                System.Drawing.Color.FromArgb(185, 28, 28);

            // ==============================
            // btnAddTeacher
            // ==============================

            this.btnAddTeacher.BackColor = sidebarButton;
            this.btnAddTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTeacher.FlatAppearance.BorderColor = cardBorder;
            this.btnAddTeacher.FlatAppearance.BorderSize = 1;
            this.btnAddTeacher.FlatAppearance.MouseOverBackColor = accentDark;
            this.btnAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeacher.Font =
                new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnAddTeacher.ForeColor = white;
            this.btnAddTeacher.Location =
                new System.Drawing.Point(15, 12);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size =
                new System.Drawing.Size(220, 48);
            this.btnAddTeacher.TabIndex = 8;
            this.btnAddTeacher.Text = "＋  Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            this.btnAddTeacher.Click +=
                new System.EventHandler(this.btnAddTeacher_Click);

            // ==============================
            // btnViewTeacher
            // ==============================

            this.btnViewTeacher.BackColor = sidebarButton;
            this.btnViewTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewTeacher.FlatAppearance.BorderColor = cardBorder;
            this.btnViewTeacher.FlatAppearance.BorderSize = 1;
            this.btnViewTeacher.FlatAppearance.MouseOverBackColor = accentDark;
            this.btnViewTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTeacher.Font =
                new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnViewTeacher.ForeColor = white;
            this.btnViewTeacher.Location =
                new System.Drawing.Point(15, 68);
            this.btnViewTeacher.Name = "btnViewTeacher";
            this.btnViewTeacher.Size =
                new System.Drawing.Size(220, 48);
            this.btnViewTeacher.TabIndex = 9;
            this.btnViewTeacher.Text = "▣  View Teachers";
            this.btnViewTeacher.UseVisualStyleBackColor = false;
            this.btnViewTeacher.Click +=
                new System.EventHandler(this.btnViewTeacher_Click_1);

            // ==============================
            // btnUpdateTeacher
            // ==============================

            this.btnUpdateTeacher.BackColor = sidebarButton;
            this.btnUpdateTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateTeacher.FlatAppearance.BorderColor = cardBorder;
            this.btnUpdateTeacher.FlatAppearance.BorderSize = 1;
            this.btnUpdateTeacher.FlatAppearance.MouseOverBackColor = accentDark;
            this.btnUpdateTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTeacher.Font =
                new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnUpdateTeacher.ForeColor = white;
            this.btnUpdateTeacher.Location =
                new System.Drawing.Point(15, 124);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.Size =
                new System.Drawing.Size(220, 48);
            this.btnUpdateTeacher.TabIndex = 10;
            this.btnUpdateTeacher.Text = "✎  Update Teacher";
            this.btnUpdateTeacher.UseVisualStyleBackColor = false;
            this.btnUpdateTeacher.Click +=
                new System.EventHandler(this.btnUpdateTeacher_Click);

            // ==============================
            // btnDeleteTeacher
            // ==============================

            this.btnDeleteTeacher.BackColor = sidebarButton;
            this.btnDeleteTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTeacher.FlatAppearance.BorderColor = cardBorder;
            this.btnDeleteTeacher.FlatAppearance.BorderSize = 1;
            this.btnDeleteTeacher.FlatAppearance.MouseOverBackColor = danger;
            this.btnDeleteTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTeacher.Font =
                new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnDeleteTeacher.ForeColor = white;
            this.btnDeleteTeacher.Location =
                new System.Drawing.Point(15, 180);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size =
                new System.Drawing.Size(220, 48);
            this.btnDeleteTeacher.TabIndex = 11;
            this.btnDeleteTeacher.Text = "✕  Delete Teacher";
            this.btnDeleteTeacher.UseVisualStyleBackColor = false;
            this.btnDeleteTeacher.Click +=
                new System.EventHandler(this.btnDeleteTeacher_Click);

            // ==============================
            // PANEL TEACHER
            // ==============================

            this.panelTeacher.BackColor = card;
            this.panelTeacher.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTeacher.Controls.Add(this.btnAddTeacher);
            this.panelTeacher.Controls.Add(this.btnViewTeacher);
            this.panelTeacher.Controls.Add(this.btnDeleteTeacher);
            this.panelTeacher.Controls.Add(this.btnUpdateTeacher);
            this.panelTeacher.Location =
                new System.Drawing.Point(690, 455);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Size =
                new System.Drawing.Size(250, 245);
            this.panelTeacher.TabIndex = 27;
            this.panelTeacher.Visible = false;

            // ==============================
            // SIDEBAR
            // ==============================

            this.panel1.BackColor = sidebar;
            this.panel1.Controls.Add(this.btnTeachers);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnClass);
            this.panel1.Controls.Add(this.btnAttendence);
            this.panel1.Controls.Add(this.btnStudents);
            this.panel1.Controls.Add(this.btnCourses);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock =
                System.Windows.Forms.DockStyle.Left;
            this.panel1.Location =
                new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size =
                new System.Drawing.Size(235, 744);
            this.panel1.TabIndex = 12;

            // ==============================
            // DASHBOARD BUTTON
            // ==============================

            this.button1.BackColor = accent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = accentDark;
            this.button1.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font =
                new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.button1.ForeColor = white;
            this.button1.Location =
                new System.Drawing.Point(10, 35);
            this.button1.Name = "button1";
            this.button1.Size =
                new System.Drawing.Size(215, 45);
            this.button1.TabIndex = 14;
            this.button1.Text = "⌂   Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click +=
                new System.EventHandler(this.button1_Click_1);

            // ==============================
            // STUDENTS
            // ==============================

            this.btnStudents.BackColor = sidebar;
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(30, 58, 80);
            this.btnStudents.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font =
                new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnStudents.ForeColor = lightText;
            this.btnStudents.Location =
                new System.Drawing.Point(10, 95);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size =
                new System.Drawing.Size(215, 45);
            this.btnStudents.TabIndex = 16;
            this.btnStudents.Text = "♟   Students";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click +=
                new System.EventHandler(this.btnStudents_Click_1);

            // ==============================
            // TEACHERS
            // ==============================

            this.btnTeachers.BackColor = sidebar;
            this.btnTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeachers.FlatAppearance.BorderSize = 0;
            this.btnTeachers.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(30, 58, 80);
            this.btnTeachers.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachers.Font =
                new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnTeachers.ForeColor = lightText;
            this.btnTeachers.Location =
                new System.Drawing.Point(10, 150);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size =
                new System.Drawing.Size(215, 45);
            this.btnTeachers.TabIndex = 20;
            this.btnTeachers.Text = "♙   Teachers";
            this.btnTeachers.UseVisualStyleBackColor = false;
            this.btnTeachers.Click +=
                new System.EventHandler(this.btnTeachers_Click_1);

            // ==============================
            // ATTENDANCE
            // ==============================

            this.btnAttendence.BackColor = sidebar;
            this.btnAttendence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendence.FlatAppearance.BorderSize = 0;
            this.btnAttendence.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(30, 58, 80);
            this.btnAttendence.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendence.Font =
                new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnAttendence.ForeColor = lightText;
            this.btnAttendence.Location =
                new System.Drawing.Point(10, 205);
            this.btnAttendence.Name = "btnAttendence";
            this.btnAttendence.Size =
                new System.Drawing.Size(215, 45);
            this.btnAttendence.TabIndex = 17;
            this.btnAttendence.Text = "✓   Attendance";
            this.btnAttendence.UseVisualStyleBackColor = false;
            this.btnAttendence.Click +=
                new System.EventHandler(this.btnAttendance_Click);

            // ==============================
            // CLASS
            // ==============================

            this.btnClass.BackColor = sidebar;
            this.btnClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(30, 58, 80);
            this.btnClass.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font =
                new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnClass.ForeColor = lightText;
            this.btnClass.Location =
                new System.Drawing.Point(10, 260);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size =
                new System.Drawing.Size(215, 45);
            this.btnClass.TabIndex = 18;
            this.btnClass.Text = "▦   Class";
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click +=
                new System.EventHandler(this.btnClass_Click);

            // ==============================
            // COURSES
            // ==============================

            this.btnCourses.BackColor = sidebar;
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(30, 58, 80);
            this.btnCourses.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font =
                new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnCourses.ForeColor = lightText;
            this.btnCourses.Location =
                new System.Drawing.Point(10, 315);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size =
                new System.Drawing.Size(215, 45);
            this.btnCourses.TabIndex = 15;
            this.btnCourses.Text = "▤   Courses";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click +=
                new System.EventHandler(this.btnCourses_Click);

            // ==============================
            // LOGOUT
            // ==============================

            this.btnLogout.BackColor = danger;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(153, 27, 27);
            this.btnLogout.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font =
                new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnLogout.ForeColor = white;
            this.btnLogout.Location =
                new System.Drawing.Point(10, 650);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size =
                new System.Drawing.Size(215, 45);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "⇥   Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click +=
                new System.EventHandler(this.button6_Click);

            // ==============================
            // TITLE
            // ==============================

            this.label1.AutoSize = true;
            this.label1.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    23F,
                    System.Drawing.FontStyle.Bold);

            this.label1.ForeColor = white;
            this.label1.Location =
                new System.Drawing.Point(285, 35);
            this.label1.Name = "label1";
            this.label1.Size =
                new System.Drawing.Size(500, 42);
            this.label1.TabIndex = 20;
            this.label1.Text =
                "Student Management System";

            // ==============================
            // STUDENT CARD
            // ==============================

            this.button7.BackColor = card;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = accent;
            this.button7.FlatAppearance.BorderSize = 1;
            this.button7.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(37, 55, 78);
            this.button7.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    15F);
            this.button7.ForeColor = white;
            this.button7.Location =
                new System.Drawing.Point(285, 120);
            this.button7.Name = "button7";
            this.button7.Size =
                new System.Drawing.Size(220, 115);
            this.button7.TabIndex = 21;
            this.button7.Text =
                "👨‍🎓\r\n\r\nStudents";
            this.button7.UseVisualStyleBackColor = false;

            // ==============================
            // TEACHER CARD
            // ==============================

            this.button8.BackColor = card;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = accent;
            this.button8.FlatAppearance.BorderSize = 1;
            this.button8.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(37, 55, 78);
            this.button8.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    15F);
            this.button8.ForeColor = white;
            this.button8.Location =
                new System.Drawing.Point(535, 120);
            this.button8.Name = "button8";
            this.button8.Size =
                new System.Drawing.Size(220, 115);
            this.button8.TabIndex = 22;
            this.button8.Text =
                "👨‍🏫\r\n\r\nTeachers";
            this.button8.UseVisualStyleBackColor = false;

            // ==============================
            // COURSES CARD
            // ==============================

            this.button9.BackColor = card;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = accent;
            this.button9.FlatAppearance.BorderSize = 1;
            this.button9.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(37, 55, 78);
            this.button9.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    15F);
            this.button9.ForeColor = white;
            this.button9.Location =
                new System.Drawing.Point(785, 120);
            this.button9.Name = "button9";
            this.button9.Size =
                new System.Drawing.Size(220, 115);
            this.button9.TabIndex = 23;
            this.button9.Text =
                "📚\r\n\r\nCourses";
            this.button9.UseVisualStyleBackColor = false;

            // ==============================
            // ATTENDANCE CARD
            // ==============================

            this.button10.BackColor = card;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderColor = accent;
            this.button10.FlatAppearance.BorderSize = 1;
            this.button10.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(37, 55, 78);
            this.button10.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    15F);
            this.button10.ForeColor = white;
            this.button10.Location =
                new System.Drawing.Point(410, 270);
            this.button10.Name = "button10";
            this.button10.Size =
                new System.Drawing.Size(220, 115);
            this.button10.TabIndex = 24;
            this.button10.Text =
                "✓\r\n\r\nAttendance";
            this.button10.UseVisualStyleBackColor = false;

            // ==============================
            // CLASS CARD
            // ==============================

            this.button11.BackColor = card;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderColor = accent;
            this.button11.FlatAppearance.BorderSize = 1;
            this.button11.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(37, 55, 78);
            this.button11.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    15F);
            this.button11.ForeColor = white;
            this.button11.Location =
                new System.Drawing.Point(660, 270);
            this.button11.Name = "button11";
            this.button11.Size =
                new System.Drawing.Size(220, 115);
            this.button11.TabIndex = 25;
            this.button11.Text =
                "▦\r\n\r\nClass";
            this.button11.UseVisualStyleBackColor = false;

            // ==============================
            // STUDENT PANEL
            // ==============================

            this.panelStudent.BackColor = card;
            this.panelStudent.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.panelStudent.Controls.Add(
                this.btnDeleteStudent);
            this.panelStudent.Controls.Add(
                this.btnUpdateStudent);
            this.panelStudent.Controls.Add(
                this.btnViewStudent);
            this.panelStudent.Controls.Add(
                this.btnAddStudent);

            this.panelStudent.Location =
                new System.Drawing.Point(285, 455);

            this.panelStudent.Name =
                "panelStudent";

            this.panelStudent.Size =
                new System.Drawing.Size(250, 245);

            this.panelStudent.TabIndex = 26;
            this.panelStudent.Visible = false;

            // ==============================
            // ADD STUDENT
            // ==============================

            this.btnAddStudent.BackColor = sidebarButton;
            this.btnAddStudent.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.FlatAppearance.BorderColor =
                cardBorder;
            this.btnAddStudent.FlatAppearance.BorderSize = 1;
            this.btnAddStudent.FlatAppearance.MouseOverBackColor =
                accentDark;
            this.btnAddStudent.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    10F);
            this.btnAddStudent.ForeColor = white;
            this.btnAddStudent.Location =
                new System.Drawing.Point(15, 12);
            this.btnAddStudent.Name =
                "btnAddStudent";
            this.btnAddStudent.Size =
                new System.Drawing.Size(220, 48);
            this.btnAddStudent.TabIndex = 30;
            this.btnAddStudent.Text =
                "＋  Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click +=
                new System.EventHandler(
                    this.btnAddStudent_Click_1);

            // ==============================
            // VIEW STUDENT
            // ==============================

            this.btnViewStudent.BackColor = sidebarButton;
            this.btnViewStudent.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnViewStudent.FlatAppearance.BorderColor =
                cardBorder;
            this.btnViewStudent.FlatAppearance.BorderSize = 1;
            this.btnViewStudent.FlatAppearance.MouseOverBackColor =
                accentDark;
            this.btnViewStudent.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStudent.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    10F);
            this.btnViewStudent.ForeColor = white;
            this.btnViewStudent.Location =
                new System.Drawing.Point(15, 68);
            this.btnViewStudent.Name =
                "btnViewStudent";
            this.btnViewStudent.Size =
                new System.Drawing.Size(220, 48);
            this.btnViewStudent.TabIndex = 29;
            this.btnViewStudent.Text =
                "▣  View Students";
            this.btnViewStudent.UseVisualStyleBackColor = false;
            this.btnViewStudent.Click +=
                new System.EventHandler(
                    this.btnViewStudent_Click);

            // ==============================
            // UPDATE STUDENT
            // ==============================

            this.btnUpdateStudent.BackColor = sidebarButton;
            this.btnUpdateStudent.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStudent.FlatAppearance.BorderColor =
                cardBorder;
            this.btnUpdateStudent.FlatAppearance.BorderSize = 1;
            this.btnUpdateStudent.FlatAppearance.MouseOverBackColor =
                accentDark;
            this.btnUpdateStudent.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    10F);
            this.btnUpdateStudent.ForeColor = white;
            this.btnUpdateStudent.Location =
                new System.Drawing.Point(15, 124);
            this.btnUpdateStudent.Name =
                "btnUpdateStudent";
            this.btnUpdateStudent.Size =
                new System.Drawing.Size(220, 48);
            this.btnUpdateStudent.TabIndex = 28;
            this.btnUpdateStudent.Text =
                "✎  Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click +=
                new System.EventHandler(
                    this.btnUpdateStudent_Click);

            // ==============================
            // DELETE STUDENT
            // ==============================

            this.btnDeleteStudent.BackColor = sidebarButton;
            this.btnDeleteStudent.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStudent.FlatAppearance.BorderColor =
                cardBorder;
            this.btnDeleteStudent.FlatAppearance.BorderSize = 1;
            this.btnDeleteStudent.FlatAppearance.MouseOverBackColor =
                danger;
            this.btnDeleteStudent.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font =
                new System.Drawing.Font(
                    "Segoe UI Semibold",
                    10F);
            this.btnDeleteStudent.ForeColor = white;
            this.btnDeleteStudent.Location =
                new System.Drawing.Point(15, 180);
            this.btnDeleteStudent.Name =
                "btnDeleteStudent";
            this.btnDeleteStudent.Size =
                new System.Drawing.Size(220, 48);
            this.btnDeleteStudent.TabIndex = 27;
            this.btnDeleteStudent.Text =
                "✕  Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click +=
                new System.EventHandler(
                    this.btnDeleteStudent_Click);

            // ==============================
            // DASHBOARD FORM
            // ==============================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(9F, 20F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor = background;

            this.ClientSize =
                new System.Drawing.Size(1078, 744);

            this.Controls.Add(this.panelTeacher);
            this.Controls.Add(this.panelStudent);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);

            this.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F);

            this.Margin =
                new System.Windows.Forms.Padding(
                    3, 4, 3, 4);

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Name =
                "Dashboardform";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Student Management System";

            this.Load +=
                new System.EventHandler(
                    this.Dashboardform_Load);

            this.panel1.ResumeLayout(false);
            this.panelStudent.ResumeLayout(false);
            this.panelTeacher.ResumeLayout(false);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnViewTeacher;
        private System.Windows.Forms.Button btnUpdateTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnAttendence;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnTeachers;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;

        private System.Windows.Forms.Panel panelStudent;

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnViewStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnDeleteStudent;

        private System.Windows.Forms.Panel panelTeacher;
    }
}



