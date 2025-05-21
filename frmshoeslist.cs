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
using MySql.Data.MySqlClient;

namespace Shoe_Collection
{
    public partial class frmshoeslist : Form
    {
        public frmshoeslist()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmshoeslist_Load(object sender, EventArgs e)
        {
            LoadShoeData();
        }


        private void LoadShoeData()
        {
            string connectionString = "server=localhost;user=root;password=;database=shoecollectiondb;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM shoes";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvshoeslist.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void dgvshoeslist_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            frmShoes frmShoes = new frmShoes();
            frmShoes.ShowDialog();
        }

        private void dgvshoeslist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
