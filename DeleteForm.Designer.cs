
namespace Student_System
{
    partial class DeleteForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel formPanel;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblWarning;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentName;

        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentName;

        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.formPanel = new System.Windows.Forms.Panel();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();

            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();

            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();

            this.btnDelete = new System.Windows.Forms.Button();

            this.headerPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Student";

            // Header Panel
            this.headerPanel.BackColor =
                System.Drawing.Color.FromArgb(23, 37, 84);

            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Size = new System.Drawing.Size(900, 125);

            // Title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font =
                new System.Drawing.Font("Segoe UI", 22F,
                System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(35, 20);
            this.lblTitle.Text = "Delete Student";

            // Subtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font =
                new System.Drawing.Font("Segoe UI", 10F);

            this.lblSubtitle.ForeColor =
                System.Drawing.Color.LightGray;

            this.lblSubtitle.Location = new System.Drawing.Point(40, 75);
            this.lblSubtitle.Text =
                "Remove a student record from the database";

            // Header Controls
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);

            // Form Panel
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Location = new System.Drawing.Point(55, 155);
            this.formPanel.Size = new System.Drawing.Size(790, 390);

            // Section Label
            this.lblSection.AutoSize = true;
            this.lblSection.Font =
                new System.Drawing.Font("Segoe UI", 15F,
                System.Drawing.FontStyle.Bold);

            this.lblSection.ForeColor =
                System.Drawing.Color.FromArgb(23, 37, 84);

            this.lblSection.Location = new System.Drawing.Point(40, 20);
            this.lblSection.Text = "Delete Student Record";

            // Warning Label
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font =
                new System.Drawing.Font("Segoe UI", 9F);

            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(43, 65);
            this.lblWarning.Text =
                "Warning: This action will permanently delete the student record.";

            // Student ID Label
            this.label1.AutoSize = true;
            this.label1.Font =
                new System.Drawing.Font("Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);

            this.label1.ForeColor =
                System.Drawing.Color.FromArgb(30, 41, 59);

            this.label1.Location = new System.Drawing.Point(45, 110);
            this.label1.Text = "Student ID";

            // Student ID TextBox
            this.txtStudentID.Font =
                new System.Drawing.Font("Segoe UI", 11F);

            this.txtStudentID.Location =
                new System.Drawing.Point(50, 140);

            this.txtStudentID.Size =
                new System.Drawing.Size(690, 32);

            this.txtStudentID.TextChanged +=
                new System.EventHandler(this.txtStudentID_TextChanged);

            // Student Name Label
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font =
                new System.Drawing.Font("Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);

            this.lblStudentName.ForeColor =
                System.Drawing.Color.FromArgb(30, 41, 59);

            this.lblStudentName.Location =
                new System.Drawing.Point(45, 190);

            this.lblStudentName.Text = "Student Name";

            // Student Name TextBox
            this.txtStudentName.Font =
                new System.Drawing.Font("Segoe UI", 11F);

            this.txtStudentName.Location =
                new System.Drawing.Point(50, 220);

            this.txtStudentName.Size =
                new System.Drawing.Size(690, 32);

            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.BackColor =
                System.Drawing.Color.FromArgb(241, 245, 249);

            // Delete Button
            this.btnDelete.BackColor =
                System.Drawing.Color.FromArgb(220, 38, 38);

            this.btnDelete.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnDelete.FlatAppearance.BorderSize = 0;

            this.btnDelete.Font =
                new System.Drawing.Font("Segoe UI", 11F,
                System.Drawing.FontStyle.Bold);

            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location =
                new System.Drawing.Point(495, 295);

            this.btnDelete.Size =
                new System.Drawing.Size(245, 50);

            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = false;

            this.btnDelete.Click +=
                new System.EventHandler(this.btnDelete_Click);

            // Add Controls to Form Panel
            this.formPanel.Controls.Add(this.lblSection);
            this.formPanel.Controls.Add(this.lblWarning);
            this.formPanel.Controls.Add(this.label1);
            this.formPanel.Controls.Add(this.txtStudentID);
            this.formPanel.Controls.Add(this.lblStudentName);
            this.formPanel.Controls.Add(this.txtStudentName);
            this.formPanel.Controls.Add(this.btnDelete);

            // Form Load Event
            this.Load +=
                new System.EventHandler(this.DeleteForm_Load);

            // Add Panels
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.formPanel);

            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();

            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();

            this.ResumeLayout(false);
        }
    }
}
