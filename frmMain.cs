using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Shoe_Collection
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadShoesData();
            LoadOrderItemsData();
            LoadOwnerSalesData();
        }

        private void LoadShoesData()
        {
            try
            {
                string connectionString = "server=localhost;user=root;password=;database=shoecollectiondb;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM shoes";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvrecentlyact.AutoGenerateColumns = true;
                    dgvrecentlyact.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading shoes data: " + ex.Message);
            }
        }

        private void LoadOrderItemsData()
        {
            try
            {
                string connectionString = "server=localhost;user=root;password=;database=shoecollectiondb;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM recentorders"; 
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvorderitems.AutoGenerateColumns = true;
                    dgvorderitems.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order items: " + ex.Message);
            }
        }

        private void LoadOwnerSalesData()
        {
            try
            {
                string connectionString = "server=localhost;user=root;password=;database=shoecollectiondb;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT owner_id, calculate_owner_sales(owner_id) AS total_sales FROM shoeowners";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvrecentlyact.DataSource = table; // Or create a new DataGridView for owner sales
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading owner sales data: " + ex.Message);
            }
        }



        // Menu + Button event handlers
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnshoes_Click(object sender, EventArgs e)
        {
            frmshoeslist frm = new frmshoeslist();
            frm.ShowDialog();
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            frmsupplier frm = new frmsupplier();
            frm.ShowDialog();
        }

        private void btnowner_Click(object sender, EventArgs e)
        {
            frmownerlist frm = new frmownerlist();
            frm.ShowDialog();
        }

        private void btnshoesupplier_Click(object sender, EventArgs e)
        {
            frmshoesupplier frm = new frmshoesupplier();
            frm.ShowDialog();
        }

        private void btnshoeowner_Click(object sender, EventArgs e)
        {
            frmshoeowner frm = new frmshoeowner();
            frm.ShowDialog();
        }

        private void btnorderitems_Click(object sender, EventArgs e)
        {
            frmorderitems frm = new frmorderitems();
            frm.ShowDialog();
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            frmorders frm = new frmorders();
            frm.ShowDialog();
        }

        private void dgvrecentlyact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmShoes frm = new frmShoes();
            frm.ShowDialog();
        }

        private void recentlyactivity_Paint(object sender, PaintEventArgs e)
        {
            LoadShoesData();
        }

        private void orderitems_Paint(object sender, PaintEventArgs e)
        {
            LoadOrderItemsData();
        }
    }
}
