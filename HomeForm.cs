using CarPaymentApp.components;
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
    public partial class HomeForm : Form
    {
        private CarPaymentForm _calculatorForm;
        private string _username;
        private int _userId;
        public HomeForm(int userId, string username)
        {
            InitializeComponent();
            _username = username;
            _userId = userId;
            lblWelcome.Text = "Welcome " + _username;
            _calculatorForm = new CarPaymentForm(userId, _username);
        }

        private void btnToCalculatorForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            _calculatorForm.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnListVehicles_Click(object sender, EventArgs e)
        {
            this.Hide();
            var carListsForm = new CarListsForm(_userId, _username);
            carListsForm.Show();
        }
    }
}
