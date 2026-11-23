using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_System
{
    public partial class UpdateTeacherForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True";

        public UpdateTeacherForm()
        {
            InitializeComponent();

            cmbGender1.Items.Add("Male");
            cmbGender1.Items.Add("Female");

            btnSearch.Click += btnSearch_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnClear.Click += btnClear_Click;
        }

        // Search Teacher
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter Teacher ID.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT TeacherName, PhoneNO, TeacherAddress, Gender
                                     FROM Teacher
                                     WHERE TeacherID = @TeacherID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@TeacherID", txtID.Text);

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        textBox5.Text = reader["TeacherName"].ToString();
                        txtPhone.Text = reader["PhoneNO"].ToString();
                        textBox3.Text = reader["TeacherAddress"].ToString();
                        cmbGender1.Text = reader["Gender"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Teacher ID not found.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Update Teacher
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter Teacher ID.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Teacher
                                     SET TeacherName = @TeacherName,
                                         PhoneNO = @PhoneNO,
                                         TeacherAddress = @TeacherAddress,
                                         Gender = @Gender
                                     WHERE TeacherID = @TeacherID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@TeacherID", txtID.Text);
                    cmd.Parameters.AddWithValue("@TeacherName", textBox5.Text);
                    cmd.Parameters.AddWithValue("@PhoneNO", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@TeacherAddress", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender1.Text);

                    con.Open();

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Teacher updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Teacher ID not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            textBox5.Clear();
            txtPhone.Clear();
            textBox3.Clear();
            cmbGender1.SelectedIndex = -1;
        }

        // Existing events
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTeacherForm_Load(object sender, EventArgs e)
        {

        }
    }
}