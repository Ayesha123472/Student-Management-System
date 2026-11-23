namespace Student_System
{
    partial class AddTeacherForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();

            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();

            this.cmbGender = new System.Windows.Forms.ComboBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();

            this.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.formPanel.SuspendLayout();

            // FORM
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor =
                System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(850, 660);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "AddTeacherForm";
            this.Text = "Add Teacher | Student Management System";

            // HEADER PANEL
            this.headerPanel.BackColor =
                System.Drawing.Color.FromArgb(23, 37, 84);
            this.headerPanel.Location =
                new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size =
                new System.Drawing.Size(850, 125);
            this.headerPanel.TabIndex = 0;

            // HEADER TITLE
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI", 22F,
                    System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor =
                System.Drawing.Color.White;
            this.lblTitle.Location =
                new System.Drawing.Point(42, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Add New Teacher";

            // HEADER SUBTITLE
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font =
                new System.Drawing.Font(
                    "Segoe UI", 10F,
                    System.Drawing.FontStyle.Regular);
            this.lblSubtitle.ForeColor =
                System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblSubtitle.Location =
                new System.Drawing.Point(47, 76);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text =
                "Student Management System  |  Teacher Information";

            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);

            // FORM CONTENT PANEL
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Location =
                new System.Drawing.Point(42, 153);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size =
                new System.Drawing.Size(766, 445);
            this.formPanel.TabIndex = 1;

            // COMMON LABEL STYLE
            System.Drawing.Font labelFont =
                new System.Drawing.Font(
                    "Segoe UI", 11F,
                    System.Drawing.FontStyle.Bold);

            System.Drawing.Color labelColor =
                System.Drawing.Color.FromArgb(51, 65, 85);

            // LABEL 1: NAME
            this.label1.AutoSize = true;
            this.label1.Font = labelFont;
            this.label1.ForeColor = labelColor;
            this.label1.Location =
                new System.Drawing.Point(48, 113);
            this.label1.Name = "label1";
            this.label1.Text = "Full Name";

            // LABEL 2: TEACHER ID
            this.label2.AutoSize = true;
            this.label2.Font = labelFont;
            this.label2.ForeColor = labelColor;
            this.label2.Location =
                new System.Drawing.Point(48, 43);
            this.label2.Name = "label2";
            this.label2.Text = "Teacher ID";

            // LABEL 3: PHONE
            this.label3.AutoSize = true;
            this.label3.Font = labelFont;
            this.label3.ForeColor = labelColor;
            this.label3.Location =
                new System.Drawing.Point(48, 183);
            this.label3.Name = "label3";
            this.label3.Text = "Phone Number";

            // LABEL 5: ADDRESS
            this.label5.AutoSize = true;
            this.label5.Font = labelFont;
            this.label5.ForeColor = labelColor;
            this.label5.Location =
                new System.Drawing.Point(48, 253);
            this.label5.Name = "label5";
            this.label5.Text = "Address";

            // LABEL 4: GENDER
            this.label4.AutoSize = true;
            this.label4.Font = labelFont;
            this.label4.ForeColor = labelColor;
            this.label4.Location =
                new System.Drawing.Point(48, 323);
            this.label4.Name = "label4";
            this.label4.Text = "Gender";

            // COMMON TEXTBOX STYLE
            System.Drawing.Font inputFont =
                new System.Drawing.Font("Segoe UI", 11F);

            System.Drawing.Color inputBorder =
                System.Drawing.Color.FromArgb(203, 213, 225);

            // TEACHER ID
            this.txtTeacherID.Font = inputFont;
            this.txtTeacherID.ForeColor =
                System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtTeacherID.BackColor =
                System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtTeacherID.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTeacherID.Location =
                new System.Drawing.Point(260, 39);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size =
                new System.Drawing.Size(435, 32);
            this.txtTeacherID.TabIndex = 0;

            // NAME
            this.txtName.Font = inputFont;
            this.txtName.ForeColor =
                System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtName.BackColor =
                System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtName.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location =
                new System.Drawing.Point(260, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size =
                new System.Drawing.Size(435, 32);
            this.txtName.TabIndex = 1;

            // PHONE NUMBER
            this.txtPhoneNo.Font = inputFont;
            this.txtPhoneNo.ForeColor =
                System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtPhoneNo.BackColor =
                System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtPhoneNo.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNo.Location =
                new System.Drawing.Point(260, 179);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size =
                new System.Drawing.Size(435, 32);
            this.txtPhoneNo.TabIndex = 2;

            // ADDRESS
            this.txtAddress.Font = inputFont;
            this.txtAddress.ForeColor =
                System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtAddress.BackColor =
                System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtAddress.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location =
                new System.Drawing.Point(260, 249);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size =
                new System.Drawing.Size(435, 32);
            this.txtAddress.TabIndex = 3;

            // GENDER COMBOBOX
            this.cmbGender.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = inputFont;
            this.cmbGender.ForeColor =
                System.Drawing.Color.FromArgb(30, 41, 59);
            this.cmbGender.BackColor =
                System.Drawing.Color.FromArgb(248, 250, 252);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location =
                new System.Drawing.Point(260, 319);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size =
                new System.Drawing.Size(435, 33);
            this.cmbGender.TabIndex = 4;

            // SAVE BUTTON
            this.btnSave.BackColor =
                System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSave.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnSave.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font =
                new System.Drawing.Font(
                    "Segoe UI", 11F,
                    System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location =
                new System.Drawing.Point(420, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size =
                new System.Drawing.Size(130, 43);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click +=
                new System.EventHandler(this.btnSave_Click);

            // CLEAR BUTTON
            this.btnClear.BackColor =
                System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnClear.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClear.Cursor =
                System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font =
                new System.Drawing.Font(
                    "Segoe UI", 11F,
                    System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor =
                System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnClear.Location =
                new System.Drawing.Point(565, 382);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size =
                new System.Drawing.Size(130, 43);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click +=
                new System.EventHandler(this.btnClear_Click);

            // ADD CONTROLS TO CONTENT PANEL
            this.formPanel.Controls.Add(this.label1);
            this.formPanel.Controls.Add(this.label2);
            this.formPanel.Controls.Add(this.label3);
            this.formPanel.Controls.Add(this.label4);
            this.formPanel.Controls.Add(this.label5);

            this.formPanel.Controls.Add(this.txtTeacherID);
            this.formPanel.Controls.Add(this.txtName);
            this.formPanel.Controls.Add(this.txtPhoneNo);
            this.formPanel.Controls.Add(this.txtAddress);
            this.formPanel.Controls.Add(this.cmbGender);

            this.formPanel.Controls.Add(this.btnSave);
            this.formPanel.Controls.Add(this.btnClear);

            // ADD PANELS TO FORM
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.headerPanel);

            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtAddress;

        private System.Windows.Forms.ComboBox cmbGender;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel formPanel;
    }
}
