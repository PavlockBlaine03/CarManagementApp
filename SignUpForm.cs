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

namespace CarPaymentApp
{
    public partial class SignUpForm : Form
    {
        private string connectionString = @"Server=DESKTOP-MAI0MDI\SQLEXPRESS01;Database=CarPaymentApp;Trusted_Connection=True;";

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnLoginPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtNewUsername.Text.Trim();
            string password = txtNewPassword.Text.Trim();

            if(username == "" || password == "")
            {
                MessageBox.Show("Username and Password cannot be empty!");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);


                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully!");

                    this.Hide();
                    LoginForm login = new LoginForm();
                    login.Show();
                }
                catch (SqlException ex)
                {
                    if(ex.Number == 2627)
                    {
                        MessageBox.Show("Username already exists.");
                    }
                    else
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
