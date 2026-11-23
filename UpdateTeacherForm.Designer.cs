
namespace Student_System
{
    partial class UpdateTeacherForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblSection;

        private System.Windows.Forms.Label txtTeacherID;
        private System.Windows.Forms.Label txtTeacherName;
        private System.Windows.Forms.Label txtPhoneNo;
        private System.Windows.Forms.Label txtTeacherAddress;
        private System.Windows.Forms.Label txtGender;

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox textBox5;

        private System.Windows.Forms.ComboBox cmbGender1;

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;

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

            this.txtTeacherID = new System.Windows.Forms.Label();
            this.txtTeacherName = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.Label();
            this.txtTeacherAddress = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.Label();

            this.txtID = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();

            this.cmbGender1 = new System.Windows.Forms.ComboBox();

            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();

            this.headerPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();

            // FORM
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "UpdateTeacherForm";
            this.Text = "Update Teacher | Student Management System";
            this.Load += new System.EventHandler(this.UpdateTeacherForm_Load);

            // HEADER PANEL
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(23, 37, 84);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Size = new System.Drawing.Size(850, 125);
            this.headerPanel.Name = "headerPanel";

            // TITLE
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(42, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Update Teacher";

            // SUBTITLE
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblSubtitle.Location = new System.Drawing.Point(47, 76);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Student Management System  |  Update Teacher Information";

            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);

            // FORM PANEL
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Location = new System.Drawing.Point(42, 150);
            this.formPanel.Size = new System.Drawing.Size(766, 455);
            this.formPanel.Name = "formPanel";

            // SECTION TITLE
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font(
                "Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSection.ForeColor = System.Drawing.Color.FromArgb(23, 37, 84);
            this.lblSection.Location = new System.Drawing.Point(38, 18);
            this.lblSection.Text = "Teacher Details";

            // COMMON STYLES
            System.Drawing.Font labelFont =
                new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);

            System.Drawing.Font inputFont =
                new System.Drawing.Font("Segoe UI", 10.5F);

            System.Drawing.Color labelColor =
                System.Drawing.Color.FromArgb(51, 65, 85);

            System.Drawing.Color inputColor =
                System.Drawing.Color.FromArgb(248, 250, 252);

            // TEACHER ID
            this.txtTeacherID.AutoSize = true;
            this.txtTeacherID.Font = labelFont;
            this.txtTeacherID.ForeColor = labelColor;
            this.txtTeacherID.Location = new System.Drawing.Point(40, 75);
            this.txtTeacherID.Text = "Teacher ID:";

            this.txtID.Font = inputFont;
            this.txtID.BackColor = inputColor;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(230, 72);
            this.txtID.Size = new System.Drawing.Size(340, 32);
            this.txtID.Name = "txtID";

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

            // TEACHER NAME
            this.txtTeacherName.AutoSize = true;
            this.txtTeacherName.Font = labelFont;
            this.txtTeacherName.ForeColor = labelColor;
            this.txtTeacherName.Location = new System.Drawing.Point(40, 140);
            this.txtTeacherName.Text = "Teacher Name:";

            this.textBox5.Font = inputFont;
            this.textBox5.BackColor = inputColor;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(230, 137);
            this.textBox5.Size = new System.Drawing.Size(485, 32);
            this.textBox5.Name = "textBox5";

            // PHONE NUMBER
            this.txtPhoneNo.AutoSize = true;
            this.txtPhoneNo.Font = labelFont;
            this.txtPhoneNo.ForeColor = labelColor;
            this.txtPhoneNo.Location = new System.Drawing.Point(40, 205);
            this.txtPhoneNo.Text = "Phone No:";

            this.txtPhone.Font = inputFont;
            this.txtPhone.BackColor = inputColor;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(230, 202);
            this.txtPhone.Size = new System.Drawing.Size(485, 32);
            this.txtPhone.Name = "txtPhone";

            // ADDRESS
            this.txtTeacherAddress.AutoSize = true;
            this.txtTeacherAddress.Font = labelFont;
            this.txtTeacherAddress.ForeColor = labelColor;
            this.txtTeacherAddress.Location = new System.Drawing.Point(40, 270);
            this.txtTeacherAddress.Text = "Address:";

            this.textBox3.Font = inputFont;
            this.textBox3.BackColor = inputColor;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(230, 267);
            this.textBox3.Size = new System.Drawing.Size(485, 45);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";

            // GENDER
            this.txtGender.AutoSize = true;
            this.txtGender.Font = labelFont;
            this.txtGender.ForeColor = labelColor;
            this.txtGender.Location = new System.Drawing.Point(40, 345);
            this.txtGender.Text = "Gender:";

            this.cmbGender1.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender1.Font = inputFont;
            this.cmbGender1.BackColor = inputColor;
            this.cmbGender1.Items.AddRange(new object[] {
                "Male", "Female"
            });
            this.cmbGender1.Location = new System.Drawing.Point(230, 342);
            this.cmbGender1.Size = new System.Drawing.Size(485, 32);
            this.cmbGender1.Name = "cmbGender1";

            // UPDATE BUTTON
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(21, 128, 61);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(425, 395);
            this.btnUpdate.Size = new System.Drawing.Size(165, 42);
            this.btnUpdate.Text = "Update Teacher";
            this.btnUpdate.Name = "btnUpdate";

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
            this.btnClear.Location = new System.Drawing.Point(600, 395);
            this.btnClear.Size = new System.Drawing.Size(115, 42);
            this.btnClear.Text = "Clear";
            this.btnClear.Name = "btnClear";

            // ADD CONTROLS
            this.formPanel.Controls.Add(this.lblSection);

            this.formPanel.Controls.Add(this.txtTeacherID);
            this.formPanel.Controls.Add(this.txtID);
            this.formPanel.Controls.Add(this.btnSearch);

            this.formPanel.Controls.Add(this.txtTeacherName);
            this.formPanel.Controls.Add(this.textBox5);

            this.formPanel.Controls.Add(this.txtPhoneNo);
            this.formPanel.Controls.Add(this.txtPhone);

            this.formPanel.Controls.Add(this.txtTeacherAddress);
            this.formPanel.Controls.Add(this.textBox3);

            this.formPanel.Controls.Add(this.txtGender);
            this.formPanel.Controls.Add(this.cmbGender1);

            this.formPanel.Controls.Add(this.btnUpdate);
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
