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
using ClosedXML.Excel;
using System.IO;

namespace Shoe_Collection
{
    public partial class frmShoes : Form
    {
        string connectionString = "server=localhost;user id=root;password=;database=shoecollectiondb;";

        public frmShoes()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM shoes";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvShoes.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate required text fields
            if (string.IsNullOrWhiteSpace(txtbrand.Text) ||
                string.IsNullOrWhiteSpace(txtmodel.Text) ||
                string.IsNullOrWhiteSpace(txtcolor.Text))
            {
                MessageBox.Show("Please fill in all required text fields: Brand, Model, and Color.");
                return;
            }

            // Validate numeric inputs
            if (!double.TryParse(txtsize.Text, out double size) ||
                !decimal.TryParse(txtprice.Text, out decimal price) ||
                !int.TryParse(txtstock.Text, out int stock))
            {
                MessageBox.Show("Please enter valid numeric values for Size, Price, and Stock.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // INSERT query
                    string insertQuery = @"INSERT INTO shoes 
                                   (brand, model, size, color, price, stock) 
                                   VALUES (@brand, @model, @size, @color, @price, @stock)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@brand", txtbrand.Text.Trim());
                        cmd.Parameters.AddWithValue("@model", txtmodel.Text.Trim());
                        cmd.Parameters.AddWithValue("@size", size);
                        cmd.Parameters.AddWithValue("@color", txtcolor.Text.Trim());
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.ExecuteNonQuery();
                    }

                    // Get last inserted ID
                    long lastInsertedId = 0;
                    using (MySqlCommand cmdId = new MySqlCommand("SELECT LAST_INSERT_ID();", conn))
                    {
                        lastInsertedId = Convert.ToInt64(cmdId.ExecuteScalar());
                    }

                    // Retrieve the last inserted record
                    string selectQuery = "SELECT * FROM shoes WHERE shoe_id = @id";
                    using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@id", lastInsertedId);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectCmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                // If dgvshoes has no data source yet, create a new DataTable
                                if (dgvShoes.DataSource == null || !(dgvShoes.DataSource is DataTable))
                                {
                                    dgvShoes.DataSource = dt;
                                }
                                else
                                {
                                    // Append to existing DataTable
                                    DataTable currentData = dgvShoes.DataSource as DataTable;
                                    foreach (DataRow row in dt.Rows)
                                    {
                                        currentData.ImportRow(row);
                                    }
                                }
                            }
                        }
                    }

                    MessageBox.Show("Shoe added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the shoe: " + ex.Message);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtShoeid.Clear();
            txtbrand.Clear();
            txtmodel.Clear();
            txtsize.Clear();
            txtcolor.Clear();
            txtprice.Clear();
            txtstock.Clear();
        }

        private void frmShoes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            if (dgvShoes.DataSource is DataTable dt && dt.Rows.Count > 0)
            {
                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "Excel Workbook|*.xlsx",
                    Title = "Save Excel Report",
                    FileName = "Shoe_Collection_Report.xlsx"
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                wb.Worksheets.Add(dt, "Shoes Report");
                                wb.SaveAs(sfd.FileName);
                            }
                            MessageBox.Show("Excel report exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while exporting: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no data to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}