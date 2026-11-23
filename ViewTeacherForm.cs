using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_System
{
    public partial class ViewTeacherForm : Form
    {
        private readonly string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True";

        public ViewTeacherForm()
        {
            InitializeComponent();
            LoadTeacherData();
        }

        // Load teacher records from the database
        private void LoadTeacherData()
        {
            try
            {
                using (SqlConnection con =
                       new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Teacher";

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load teacher records.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Refresh button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTeacherData();
        }

        // Form Load event
        private void ViewTeacherForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        // DataGridView cell click event
        private void dataGridView1_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            // Add cell-click functionality if needed.
        }

        // Search textbox event
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Search functionality can be added here later.
        }
    }
}

