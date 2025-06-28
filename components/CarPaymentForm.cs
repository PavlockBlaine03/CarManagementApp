using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarPaymentApp.Utility;

namespace CarPaymentApp
{
    public partial class CarPaymentForm : Form
    {
        private CarInfo _carInfo = new CarInfo();

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
                _carInfo.price = decimal.Parse(txtCarPrice.Text);
                _carInfo.downPayment = decimal.Parse(txtDownPayment.Text);

                if(_carInfo.price < _carInfo.downPayment )
                {
                    throw new Exception("Can't have a higher downpayment than price of vehicle!");
                }

                _carInfo.interestRate = decimal.Parse(txtInterestRate.Text) / 100 / 12;
                _carInfo.loanTerm = CarInfo.convertLoanTerm(listLoanTerm.Text);

                _carInfo.loanAmount = _carInfo.price - _carInfo.downPayment;

                _carInfo.monthlyPayment = _carInfo.calculateMonthlyPayment();

                lblMonthlyPayment.Text = $"Monthly Payment: {_carInfo.monthlyPayment:C2}";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = @"
                    INSERT INTO Transactions (UserId, CarPrice, DownPayment, InterestRate, LoanTerm, MonthlyPayment)
                    VALUES (@userId, @price, @down, @rate, @term, @monthly)";

                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@userId", _userId);
                    cmd.Parameters.AddWithValue("@price", _carInfo.price);
                    cmd.Parameters.AddWithValue("@down", _carInfo.downPayment);
                    cmd.Parameters.AddWithValue("@rate", _carInfo.interestRate * 12 * 100);
                    cmd.Parameters.AddWithValue("@term", _carInfo.loanTerm);
                    cmd.Parameters.AddWithValue("@monthly", _carInfo.monthlyPayment);

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
