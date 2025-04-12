using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Shoe Collection
{
    public partial class Form1 : Form
    {
        // In-memory storage for users (username -> password hash)
        private Dictionary<string, string> users = new Dictionary<string, string>();

        // Track login state
        private bool isLoginView = true;

        public Form1()
        {
            InitializeComponent();
            SetupLoginForm();

            // Add a default test user
            users.Add("admin", HashPassword("admin123"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here
        }

        private void SetupLoginForm()
        {
            this.Text = "User Authentication";
            this.Width = 400;
            this.Height = 350;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Clear existing controls if any
            this.Controls.Clear();

            // Create title label
            Label lblTitle = new Label();
            lblTitle.Text = isLoginView ? "Login" : "Sign Up";
            lblTitle.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(150, 20);
            this.Controls.Add(lblTitle);

            // Create username label
            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(50, 70);
            this.Controls.Add(lblUsername);

            // Create username textbox
            TextBox txtUsername = new TextBox();
            txtUsername.Name = "txtUsername";
            txtUsername.Location = new Point(150, 70);
            txtUsername.Size = new Size(180, 20);
            this.Controls.Add(txtUsername);

            // Create password label
            Label lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(50, 110);
            this.Controls.Add(lblPassword);

            // Create password textbox
            TextBox txtPassword = new TextBox();
            txtPassword.Name = "txtPassword";
            txtPassword.Location = new Point(150, 110);
            txtPassword.Size = new Size(180, 20);
            txtPassword.PasswordChar = '•';
            this.Controls.Add(txtPassword);

            // If in sign up mode, add confirm password field
            if (!isLoginView)
            {
                // Create confirm password label
                Label lblConfirmPassword = new Label();
                lblConfirmPassword.Text = "Confirm Password:";
                lblConfirmPassword.AutoSize = true;
                lblConfirmPassword.Location = new Point(50, 150);
                this.Controls.Add(lblConfirmPassword);

                // Create confirm password textbox
                TextBox txtConfirmPassword = new TextBox();
                txtConfirmPassword.Name = "txtConfirmPassword";
                txtConfirmPassword.Location = new Point(150, 150);
                txtConfirmPassword.Size = new Size(180, 20);
                txtConfirmPassword.PasswordChar = '•';
                this.Controls.Add(txtConfirmPassword);
            }

            // Create status label for error/success messages
            Label lblStatus = new Label();
            lblStatus.Name = "lblStatus";
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(150, isLoginView ? 150 : 190);
            this.Controls.Add(lblStatus);

            // Create submit button
            Button btnSubmit = new Button();
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Text = isLoginView ? "Login" : "Sign Up";
            btnSubmit.Location = new Point(150, isLoginView ? 180 : 220);
            btnSubmit.Size = new Size(100, 30);
            btnSubmit.Click += new EventHandler(btnSubmit_Click);
            this.Controls.Add(btnSubmit);

            // Create toggle button to switch between login and signup
            Button btnToggle = new Button();
            btnToggle.Name = "btnToggle";
            btnToggle.Text = isLoginView ? "Need to Sign Up?" : "Already have an account?";
            btnToggle.Location = new Point(120, isLoginView ? 220 : 260);
            btnToggle.Size = new Size(160, 30);
            btnToggle.Click += new EventHandler(btnToggle_Click);
            this.Controls.Add(btnToggle);
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            // Toggle between login and signup view
            isLoginView = !isLoginView;
            SetupLoginForm();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TextBox txtUsername = GetTextBoxByName("txtUsername");
            TextBox txtPassword = GetTextBoxByName("txtPassword");
            Label lblStatus = (Label)this.Controls.Find("lblStatus", true).FirstOrDefault();

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblStatus.Text = "Username and password are required.";
                return;
            }

            if (isLoginView)
            {
                // Handle login
                if (AuthenticateUser(username, password))
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenMainForm(username);
                }
                else
                {
                    lblStatus.Text = "Invalid username or password.";
                }
            }
            else
            {
                // Handle sign up
                TextBox txtConfirmPassword = GetTextBoxByName("txtConfirmPassword");
                string confirmPassword = txtConfirmPassword.Text;

                if (password != confirmPassword)
                {
                    lblStatus.Text = "Passwords do not match.";
                    return;
                }

                if (password.Length < 6)
                {
                    lblStatus.Text = "Password must be at least 6 characters long.";
                    return;
                }

                if (RegisterUser(username, password))
                {
                    MessageBox.Show("Registration successful! You can now login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isLoginView = true;
                    SetupLoginForm();
                }
                else
                {
                    lblStatus.Text = "Username already exists. Please choose another.";
                }
            }
        }

        private TextBox GetTextBoxByName(string name)
        {
            return (TextBox)this.Controls.Find(name, true).FirstOrDefault();
        }

        private bool RegisterUser(string username, string password)
        {
            // Check if username already exists
            if (users.ContainsKey(username))
            {
                return false;
            }

            // Hash the password and store user
            string hashedPassword = HashPassword(password);
            users.Add(username, hashedPassword);
            return true;
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Check if user exists
            if (!users.ContainsKey(username))
            {
                return false;
            }

            // Verify password
            string storedHash = users[username];
            string inputHash = HashPassword(password);
            return storedHash == inputHash;
        }

        private string HashPassword(string password)
        {
            // A simple hash function for demo purposes
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void OpenMainForm(string username)
        {
            // Create and show the main form after successful login
            MainForm mainForm = new MainForm(username);
            this.Hide();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();
        }
    }

    // Main form that opens after successful login
    public class MainForm : Form
    {
        private string username;

        public MainForm(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Welcome";
            this.Width = 500;
            this.Height = 400;
            this.StartPosition = FormStartPosition.CenterScreen;

            Label welcomeLabel = new Label();
            welcomeLabel.Text = $"Welcome, {username}!";
            welcomeLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(150, 50);
            this.Controls.Add(welcomeLabel);

            Label infoLabel = new Label();
            infoLabel.Text = "You have successfully logged in.";
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(150, 100);
            this.Controls.Add(infoLabel);

            Button logoutButton = new Button();
            logoutButton.Text = "Logout";
            logoutButton.Location = new Point(200, 150);
            logoutButton.Size = new Size(100, 30);
            logoutButton.Click += (s, e) => {
                this.Close();
            };
            this.Controls.Add(logoutButton);
        }
    }
}