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
    public partial class CarPaymentForm : Form
    {
        private int _userId;
        private string _name;
        private string connectionString = @"Server=DESKTOP-MAI0MDI\SQLEXPRESS01;Database=CarPaymentApp;Trusted_Connection=True;";
        public CarPaymentForm(int userId, string username)
        {
            InitializeComponent();
            _userId = userId;
            _name = username;
            LoadTransactions();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            { 
                decimal carPrice = decimal.Parse(txtCarPrice.Text);
                decimal downPayment = decimal.Parse(txtDownPayment.Text);

                if(carPrice < downPayment )
                {
                    throw new Exception("Can't have a higher downpayment than price of vehicle!");
                }

                decimal interestRate = decimal.Parse(txtInterestRate.Text) / 100 / 12;
                string loanTermString = listLoanTerm.Text;
                if(loanTermString == null)
                {
                    throw new Exception("invalid loan term!");
                }
                string[] parts = loanTermString.Split(' ');
                int loanTerm = int.Parse(parts[0]);

                decimal loanAmount = carPrice - downPayment;
                decimal monthlyPayment = (
                        loanAmount * interestRate) / (1 - (decimal)Math.Pow(1 + (double)interestRate, -loanTerm)
                        );

                lblMonthlyPayment.Text = $"Monthly Payment: {monthlyPayment:C2}";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = @"
                    INSERT INTO Transactions (UserId, CarPrice, DownPayment, InterestRate, LoanTerm, MonthlyPayment)
                    VALUES (@userId, @price, @down, @rate, @term, @monthly)";

                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@userId", _userId);
                    cmd.Parameters.AddWithValue("@price", carPrice);
                    cmd.Parameters.AddWithValue("@down", downPayment);
                    cmd.Parameters.AddWithValue("@rate", interestRate * 12 * 100);
                    cmd.Parameters.AddWithValue("@term", loanTerm);
                    cmd.Parameters.AddWithValue("@monthly", monthlyPayment);

                    cmd.ExecuteNonQuery();
                    LoadTransactions();
            }
            }
            catch (FormatException ex) 
            {
                MessageBox.Show("Please enter a valid numeric values: " + ex.Message);   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadTransactions()
        {
            listHistory.Items.Clear();

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT CarPrice, DownPayment, InterestRate, LoanTerm, MonthlyPayment, DateCreated
                    FROM Transactions
                    WHERE UserId = @userId
                    ORDER BY DateCreated DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", _userId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string line = $"[{reader["DateCreated"]}] ${reader["CarPrice"]} | Down: ${reader["DownPayment"]} | Rate: {reader["InterestRate"]}% | Term: {reader["LoanTerm"]} mo | Payment: ${reader["MonthlyPayment"]}";
                    listHistory.Items.Add(line);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var homeForm = new HomeForm(_userId, _name);
            homeForm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCarPrice.Text = string.Empty;
            txtDownPayment.Text = string.Empty;
            txtInterestRate.Text = string.Empty;
            listLoanTerm.SelectedIndex = 0;
        }
    }
}
