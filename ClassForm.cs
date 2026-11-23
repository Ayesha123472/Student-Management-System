using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_System
{
    public partial class ClassForm : Form
    {
        string connectionString =
    @"Data Source=.\SQLEXPRESS;Initial Catalog=StudentManagementDB;Integrated Security=True";

        public ClassForm()
        {
            InitializeComponent();
        }
            private void btnSaveClass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClassID.Text))
            {
                MessageBox.Show("Please enter Class ID.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtClassName.Text))
            {
                MessageBox.Show("Please enter Class Name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRoomNo.Text))
            {
                MessageBox.Show("Please enter Room No.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSection.Text))
            {
                MessageBox.Show("Please enter Section.");
                return;
            }

            int classID;
            int roomNo;

            // Convert Class ID
            if (!int.TryParse(txtClassID.Text.Trim(), out classID))
            {
                MessageBox.Show("Class ID must be a number.");
                return;
            }

            // Convert Room No
            if (!int.TryParse(txtRoomNo.Text.Trim(), out roomNo))
            {
                MessageBox.Show("Room No must be a number.");
                return;
            }

            try
            {
                using (SqlConnection con =
                    new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                INSERT INTO [Class]
                (ClassID, ClassName, RoomNo, Section)
                VALUES
                (@ClassID, @ClassName, @RoomNo, @Section)";

                    using (SqlCommand cmd =
                        new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@ClassID", System.Data.SqlDbType.Int)
                            .Value = classID;

                        cmd.Parameters.Add("@ClassName", System.Data.SqlDbType.VarChar, 50)
                            .Value = txtClassName.Text.Trim();

                        cmd.Parameters.Add("@RoomNo", System.Data.SqlDbType.Int)
                            .Value = roomNo;

                        cmd.Parameters.Add("@Section", System.Data.SqlDbType.VarChar, 50)
                            .Value = txtSection.Text.Trim();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Class saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
       

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassID.Clear();
            txtClassName.Clear();
            txtRoomNo.Clear();
            txtSection.Clear();
        }
    
        
    }
}
