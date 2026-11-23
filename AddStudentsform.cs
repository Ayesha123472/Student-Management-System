using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_System
{
    public partial class AddStudentsform : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True";

        public AddStudentsform()
        {
            InitializeComponent();
        }

        private void Addform_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        // Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtFatherName.Clear();
            txtAge.Clear();
            txtPhone.Clear();
            txtAddress.Clear();

            cmbGender.SelectedIndex = -1;
        }

        // Add Student Form Load
        private void AddStudentsform_Load(object sender, EventArgs e)
        {
        }

        // Save Button
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtStudentName.Text;
            string fatherName = txtFatherName.Text;
            int age;
            string gender = cmbGender.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            if (name == "" || fatherName == "" || txtAge.Text == "" ||
                gender == "" || phone == "" || address == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            string query = @"INSERT INTO Students
                     (Name, FatherName, Age, Gender, Phone, Address)
                     VALUES
                     (@Name, @FatherName, @Age, @Gender, @Phone, @Address)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@FatherName", fatherName);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Address", address);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Student information saved successfully!");

                    txtStudentName.Clear();
                    txtFatherName.Clear();
                    txtAge.Clear();
                    txtPhone.Clear();
                    txtAddress.Clear();
                    cmbGender.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}