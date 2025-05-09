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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();  // THIS MUST BE HERE
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=;database=shoecollectiondb;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM user WHERE username = '" + txtusername.Text +"' AND password ='"+ txtpassword.Text+ "'";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {


                        cmd.Parameters.AddWithValue("@username", txtusername.Text);
                        cmd.Parameters.AddWithValue("@password", txtpassword.Text); // Note: In real-world, hash passwords!

                        int userExists = Convert.ToInt32(cmd.ExecuteScalar());

                        if (userExists > 0)
                        {
                            frmMain mainForm = new frmMain();

                            mainForm.Show();
                        }
                        else
                        {
                           MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}