namespace Student_System
{
    partial class ClassForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblSection;

        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Button btnSaveClass;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label txtRoom;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label Section;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Button btnClear;

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
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.btnSaveClass = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.Label();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.Section = new System.Windows.Forms.Label();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();

            this.headerPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();

            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "ClassForm";
            this.Text = "Manage Classes | Student Management System";

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
            this.lblTitle.Text = "Class Management";

            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblSubtitle.Location = new System.Drawing.Point(47, 76);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Student Management System  |  Class Information";

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
            this.lblSection.Location = new System.Drawing.Point(38, 20);
            this.lblSection.Name = "lblSection";
            this.lblSection.Text = "Class Details";

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
            this.txtID.Location = new System.Drawing.Point(40, 91);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(0, 25);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "Class ID";

            // 
            // txtClassID
            // 
            this.txtClassID.Font = inputFont;
            this.txtClassID.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtClassID.BackColor = inputBackground;
            this.txtClassID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassID.Location = new System.Drawing.Point(255, 87);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(460, 32);
            this.txtClassID.TabIndex = 1;

            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = labelFont;
            this.txtName.ForeColor = labelColor;
            this.txtName.Location = new System.Drawing.Point(40, 161);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(0, 25);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Class Name";

            // 
            // txtClassName
            // 
            this.txtClassName.Font = inputFont;
            this.txtClassName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtClassName.BackColor = inputBackground;
            this.txtClassName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassName.Location = new System.Drawing.Point(255, 157);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(460, 32);
            this.txtClassName.TabIndex = 3;

            // 
            // txtRoom
            // 
            this.txtRoom.AutoSize = true;
            this.txtRoom.Font = labelFont;
            this.txtRoom.ForeColor = labelColor;
            this.txtRoom.Location = new System.Drawing.Point(40, 231);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(0, 25);
            this.txtRoom.TabIndex = 4;
            this.txtRoom.Text = "Room Number";

            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Font = inputFont;
            this.txtRoomNo.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtRoomNo.BackColor = inputBackground;
            this.txtRoomNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomNo.Location = new System.Drawing.Point(255, 227);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(460, 32);
            this.txtRoomNo.TabIndex = 5;

            // 
            // Section
            // 
            this.Section.AutoSize = true;
            this.Section.Font = labelFont;
            this.Section.ForeColor = labelColor;
            this.Section.Location = new System.Drawing.Point(40, 301);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(0, 25);
            this.Section.TabIndex = 6;
            this.Section.Text = "Section";

            // 
            // txtSection
            // 
            this.txtSection.Font = inputFont;
            this.txtSection.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtSection.BackColor = inputBackground;
            this.txtSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSection.Location = new System.Drawing.Point(255, 297);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(460, 32);
            this.txtSection.TabIndex = 7;

            // 
            // btnSaveClass
            // 
            this.btnSaveClass.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSaveClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveClass.FlatAppearance.BorderSize = 0;
            this.btnSaveClass.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(29, 78, 216);
            this.btnSaveClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveClass.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSaveClass.ForeColor = System.Drawing.Color.White;
            this.btnSaveClass.Location = new System.Drawing.Point(425, 375);
            this.btnSaveClass.Name = "btnSaveClass";
            this.btnSaveClass.Size = new System.Drawing.Size(155, 48);
            this.btnSaveClass.TabIndex = 8;
            this.btnSaveClass.Text = "Save Class";
            this.btnSaveClass.UseVisualStyleBackColor = false;
            this.btnSaveClass.Click +=
                new System.EventHandler(this.btnSaveClass_Click);

            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnClear.Location = new System.Drawing.Point(590, 375);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 48);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click +=
                new System.EventHandler(this.btnClear_Click);

            // 
            // Add controls to formPanel
            // 
            this.formPanel.Controls.Add(this.lblSection);
            this.formPanel.Controls.Add(this.txtID);
            this.formPanel.Controls.Add(this.txtClassID);
            this.formPanel.Controls.Add(this.txtName);
            this.formPanel.Controls.Add(this.txtClassName);
            this.formPanel.Controls.Add(this.txtRoom);
            this.formPanel.Controls.Add(this.txtRoomNo);
            this.formPanel.Controls.Add(this.Section);
            this.formPanel.Controls.Add(this.txtSection);
            this.formPanel.Controls.Add(this.btnSaveClass);
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
