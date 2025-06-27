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
    public partial class LoginForm : Form
    {

        private string connectionString = @"Server=DESKTOP-MAI0MDI\SQLEXPRESS01;Database=CarPaymentApp;Trusted_Connection=True;";

        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username=@user AND Password=@pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                conn.Open();
                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    this.Hide();
                    int userId = GetuserIdFromDatabase(txtUsername.Text);
                    var homeForm = new HomeForm(userId, txtUsername.Text);
                    homeForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login: Create an account or Try again");
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var signUpForm = new SignUpForm();
            signUpForm.Show();
        }
        private int GetuserIdFromDatabase(string username)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id FROM Users WHERE Username = @username";
                SqlCommand cmd = new SqlCommand(@query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
