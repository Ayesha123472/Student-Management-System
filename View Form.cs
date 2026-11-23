using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Windows.Forms;

namespace Student_System
{
    public partial class ViewStudentForm : Form
    {
        private readonly string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True";

        private DataTable studentTable;

        public ViewStudentForm()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            string query = "SELECT * FROM Students";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(query, con))
                    {
                        studentTable = new DataTable();
                        adapter.Fill(studentTable);
                        dataGridView1.DataSource = studentTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Unable to load student records.\n\n" + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void ViewStudentForm_Load(object sender, EventArgs e)
        {
            // Records are loaded by the constructor.
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadStudents();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (studentTable == null)
                return;

            string searchText = txtSearch.Text.Trim()
                .Replace("'", "''")
                .Replace("[", "[[]")
                .Replace("%", "[%]")
                .Replace("*", "[*]");

            if (string.IsNullOrWhiteSpace(searchText))
            {
                studentTable.DefaultView.RowFilter = string.Empty;
                return;
            }

            string filter = "";

            foreach (DataColumn column in studentTable.Columns)
            {
                if (column.DataType == typeof(string))
                {
                    if (filter != "")
                        filter += " OR ";

                    filter += "CONVERT([" + column.ColumnName.Replace("]", "]]")
                        + "], 'System.String') LIKE '%"
                        + searchText + "%'";
                }
            }

            if (filter != "")
            {
                try
                {
                    studentTable.DefaultView.RowFilter = filter;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Search error: " + ex.Message,
                        "Search Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }
    }
}
