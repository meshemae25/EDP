using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Shoe_Collection
{
    public partial class frmownerlist : Form
    {
        public frmownerlist()
        {
            InitializeComponent();
        }

        private void frmownerlist_Load_1(object sender, EventArgs e)
        {
            LoadOwnerData();
        }

        private void LoadOwnerData()
        {
            try
            {
                string connectionString = "server=localhost;user=root;password=;database=shoecollectiondb;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM owners";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvownerlist.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading owners: " + ex.Message);
            }
        }
        private void dgvownerlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmowner frmowner = new frmowner();
            frmowner.ShowDialog();
        }
    }
}