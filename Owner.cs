using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Shoe_Collection
{
    public partial class frmowner : Form
    {
        string connectionString = "server=localhost;user id=root;password=;database=shoecollectiondb;";

        public frmowner()
        {
            InitializeComponent();
        }

        private void frmowner_Load(object sender, EventArgs e)
        {
            LoadOwnerData();
        }

        private void LoadOwnerData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM owners";  // Corrected to 'owners'
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvOwner.DataSource = dt;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtowner_name.Text) || string.IsNullOrWhiteSpace(txtcontact.Text))
            {
                MessageBox.Show("Please enter Fullname and Contact.");
                return;
            }

            if (IsContactExists(txtcontact.Text.Trim()))  // Prevent duplicates
            {
                MessageBox.Show("Contact number already exists.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO owners (owner_name, contact) VALUES (@fullname, @contact)";  // Corrected 'owner_name'
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fullname", txtowner_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@contact", txtcontact.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Owner added successfully.");
                LoadOwnerData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding owner: " + ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string ownerName = txtowner_name.Text.Trim();
            string contact = txtcontact.Text.Trim();

            if (!int.TryParse(txtowner_id.Text, out int ownerId))
            {
                MessageBox.Show("Please select a valid Owner ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(ownerName) || string.IsNullOrWhiteSpace(contact))
            {
                MessageBox.Show("Please fill in both Owner Name and Contact.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsContactExists(contact, ownerId))
            {
                MessageBox.Show("Contact number already exists.", "Duplicate Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE owners SET owner_name = @ownerName, contact = @contact WHERE owner_id = @ownerId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ownerId", ownerId);
                        cmd.Parameters.AddWithValue("@ownerName", ownerName);
                        cmd.Parameters.AddWithValue("@contact", contact);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Owner updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("No owner was updated. Please check the Owner ID.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LoadOwnerData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating owner:\n{ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtowner_id.Text, out int ownerId))
            {
                MessageBox.Show("Please select a valid Owner ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this owner?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM owners WHERE owner_id = @ownerId\r\n";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ownerId", ownerId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Owner deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("No owner was deleted. Please check the Owner ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LoadOwnerData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting owner:\n{ex.Message}", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtowner_id.Clear();
            txtowner_name.Clear();
            txtcontact.Clear();
        }

        private void dgvOwner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOwner.Rows[e.RowIndex];
                txtowner_id.Text = row.Cells["owner_id"].Value.ToString();
                txtowner_name.Text = row.Cells["owner_name"].Value.ToString();  // Corrected 'owner_name'
                txtcontact.Text = row.Cells["contact"].Value.ToString();
            }
        }

        // Method to check if contact number already exists in the table
        private bool IsContactExists(string contact, int? ownerId = null)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM owners WHERE contact=@contact";
                if (ownerId.HasValue)  // Exclude current record if updating
                    query += " AND owner_id != @ownerId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@contact", contact);
                    if (ownerId.HasValue)
                        cmd.Parameters.AddWithValue("@ownerId", ownerId.Value);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
