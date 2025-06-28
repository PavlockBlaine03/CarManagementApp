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

namespace CarPaymentApp.components
{
    public partial class CarListsForm : Form
    {
        private string _username;
        private bool _isSuccessful;
        private int _userId;
        private string connectionString = @"Server=DESKTOP-MAI0MDI\SQLEXPRESS01;Database=CarPaymentApp;Trusted_Connection=True;";
        public CarListsForm(int userId, string username)
        {
            InitializeComponent();
            _userId = userId;
            _username = username;
            LoadCarList();
        }

        private void LoadCarList()
        {
            dataGridCars.Rows.Clear();
            dataGridCars.Columns.Clear();

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT Id, CarPrice, DownPayment, InterestRate, LoanTerm, MonthlyPayment
                                FROM Transactions
                                WHERE UserId = @userId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", _userId);

                SqlDataReader reader = cmd.ExecuteReader();

                dataGridCars.Columns.Add("Id", "ID");
                dataGridCars.Columns["Id"].Visible = false;
                dataGridCars.Columns.Add("CarPrice", "Car Price");
                dataGridCars.Columns.Add("DownPayment", "Down Payment");
                dataGridCars.Columns.Add("InterestRate", "Interest Rate (%)");
                dataGridCars.Columns.Add("LoanTerm", "LoanTerm");
                dataGridCars.Columns.Add("MonthlyPayment", "Monthly Payment");

                while (reader.Read())
                {
                    dataGridCars.Rows.Add(
                        reader["Id"],
                        reader["CarPrice"],
                        reader["DownPayment"],
                        reader["InterestRate"],
                        reader["LoanTerm"],
                        reader["MonthlyPayment"]
                    );
                }

                int lastColumnIndex = dataGridCars.Columns.Count - 1;
                dataGridCars.Columns[lastColumnIndex].ReadOnly = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var homeForm = new HomeForm(_userId, _username);
            homeForm.Show();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach(DataGridViewRow row in dataGridCars.Rows)
                {
                    if (row.IsNewRow || row.Cells["Id"].Value == null)
                        continue;

                    try
                    {

                        int id = Convert.ToInt32(row.Cells["Id"].Value);
                        decimal carPrice = Convert.ToDecimal(row.Cells["CarPrice"].Value);
                        decimal downPayment = Convert.ToDecimal(row.Cells["DownPayment"].Value);
                        decimal interestRate = Convert.ToDecimal(row.Cells["InterestRate"].Value);
                        interestRate = Math.Round(interestRate, 2);
                        int loanTerm = Convert.ToInt32(row.Cells["LoanTerm"].Value);

                        decimal monthlyRate = interestRate / 100 / 12;
                        decimal loanAmount = carPrice - downPayment;
                        decimal monthlyPayment;

                        if (monthlyRate == 0)
                        {
                            monthlyPayment = loanAmount / loanTerm;
                        }
                        else
                        {
                            monthlyPayment = (loanAmount * monthlyRate) /
                                (1 - (decimal)Math.Pow(1 + (double)monthlyRate, -loanTerm));
                        }

                        monthlyPayment = Math.Round(monthlyPayment, 2);
                        row.Cells["MonthlyPayment"].Value = monthlyPayment;

                        string updateQuery = @"
                        UPDATE Transactions
                        SET CarPrice = @carPrice,
                            DownPayment = @downPayment,
                            InterestRate = @interestRate,
                            LoanTerm = @loanTerm,
                            MonthlyPayment = @monthlyPayment
                        WHERE Id = @id";

                        SqlCommand cmd = new SqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@carPrice", carPrice);
                        cmd.Parameters.AddWithValue("@downPayment", downPayment);
                        cmd.Parameters.AddWithValue("@interestRate", interestRate);
                        cmd.Parameters.AddWithValue("@loanTerm", loanTerm);
                        cmd.Parameters.AddWithValue("@monthlyPayment", monthlyPayment);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                        _isSuccessful = true;
                    }
                    catch (Exception ex) 
                    {
                        _isSuccessful = false;
                        MessageBox.Show($"Error in row with ID {row.Cells["Id"].Value}: {ex.Message}");
                    }
                }
                if(_isSuccessful)
                {
                    MessageBox.Show("Changes saved successfully!");
                }
            }
        }
    }
}
