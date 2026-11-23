
namespace Student_System
{
    partial class DeleteTeacherForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel formPanel;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblWarning;

        private System.Windows.Forms.Label txtTeacherID;
        private System.Windows.Forms.Label lblTeacherName;

        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox txtTeacherName;

        private System.Windows.Forms.Button btnDelete;

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
            this.lblWarning = new System.Windows.Forms.Label();

            this.txtTeacherID = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();

            this.textId = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();

            this.btnDelete = new System.Windows.Forms.Button();

            this.headerPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();

            // DeleteTeacherForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(900, 600);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Name = "DeleteTeacherForm";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Delete Teacher";

            this.Load += new System.EventHandler(
                this.DeleteTeacherForm_Load);

            // Header Panel
            this.headerPanel.BackColor =
                System.Drawing.Color.FromArgb(23, 37, 84);

            this.headerPanel.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(900, 125);

            // Title
            this.lblTitle.AutoSize = true;

            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 22F, System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(42, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Delete Teacher";

            // Subtitle
            this.lblSubtitle.AutoSize = true;

            this.lblSubtitle.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Regular);

            this.lblSubtitle.ForeColor =
                System.Drawing.Color.FromArgb(203, 213, 225);

            this.lblSubtitle.Location = new System.Drawing.Point(47, 76);
            this.lblSubtitle.Name = "lblSubtitle";

            this.lblSubtitle.Text =
                "Student Management System  |  Teacher Records";

            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);

            // Form Panel
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Location = new System.Drawing.Point(55, 155);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(790, 390);

            // Section Label
            this.lblSection.AutoSize = true;

            this.lblSection.Font = new System.Drawing.Font(
                "Segoe UI", 15F, System.Drawing.FontStyle.Bold);

            this.lblSection.ForeColor =
                System.Drawing.Color.FromArgb(23, 37, 84);

            this.lblSection.Location = new System.Drawing.Point(40, 25);
            this.lblSection.Name = "lblSection";
            this.lblSection.Text = "Remove Teacher Record";

            // Warning Label
            this.lblWarning.AutoSize = true;

            this.lblWarning.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Regular);

            this.lblWarning.ForeColor =
                System.Drawing.Color.FromArgb(185, 28, 28);

            this.lblWarning.Location = new System.Drawing.Point(43, 75);
            this.lblWarning.Name = "lblWarning";

            this.lblWarning.Text =
                "Enter Teacher ID to find the teacher you want to delete.";

            // Teacher ID Label
            this.txtTeacherID.AutoSize = true;

            this.txtTeacherID.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            this.txtTeacherID.ForeColor =
                System.Drawing.Color.FromArgb(51, 65, 85);

            this.txtTeacherID.Location = new System.Drawing.Point(45, 125);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Text = "Teacher ID";

            // Teacher ID TextBox
            this.textId.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Regular);

            this.textId.ForeColor =
                System.Drawing.Color.FromArgb(30, 41, 59);

            this.textId.BackColor =
                System.Drawing.Color.FromArgb(248, 250, 252);

            this.textId.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.textId.Location = new System.Drawing.Point(50, 155);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(690, 39);

            this.textId.TextChanged += new System.EventHandler(
                this.textId_TextChanged);

            // Teacher Name Label
            this.lblTeacherName.AutoSize = true;

            this.lblTeacherName.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            this.lblTeacherName.ForeColor =
                System.Drawing.Color.FromArgb(51, 65, 85);

            this.lblTeacherName.Location =
                new System.Drawing.Point(45, 205);

            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Text = "Teacher Name";

            // Teacher Name TextBox
            this.txtTeacherName.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Regular);

            this.txtTeacherName.ForeColor =
                System.Drawing.Color.FromArgb(30, 41, 59);

            this.txtTeacherName.BackColor =
                System.Drawing.Color.FromArgb(241, 245, 249);

            this.txtTeacherName.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.txtTeacherName.Location =
                new System.Drawing.Point(50, 235);

            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(690, 39);
            this.txtTeacherName.ReadOnly = true;

            // Delete Button
            this.btnDelete.BackColor =
                System.Drawing.Color.FromArgb(220, 38, 38);

            this.btnDelete.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnDelete.FlatAppearance.BorderSize = 0;

            this.btnDelete.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(185, 28, 28);

            this.btnDelete.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnDelete.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            this.btnDelete.ForeColor = System.Drawing.Color.White;

            this.btnDelete.Location =
                new System.Drawing.Point(495, 305);

            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(245, 55);
            this.btnDelete.Text = "Delete Teacher";
            this.btnDelete.UseVisualStyleBackColor = false;

            this.btnDelete.Click += new System.EventHandler(
                this.btnDelete_Click);

            // Add controls to formPanel
            this.formPanel.Controls.Add(this.lblSection);
            this.formPanel.Controls.Add(this.lblWarning);
            this.formPanel.Controls.Add(this.txtTeacherID);
            this.formPanel.Controls.Add(this.textId);
            this.formPanel.Controls.Add(this.lblTeacherName);
            this.formPanel.Controls.Add(this.txtTeacherName);
            this.formPanel.Controls.Add(this.btnDelete);

            // Add panels to form
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.headerPanel);

            // Finish layout
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();

            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion
    }
}
