using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Marxian_Bank
{
    public partial class TransactionForm : Form
    {
        string connectionString;
        SqlConnection con;
        double accBalance = 0;
        double accWithdrawal = 0;
        double accDeposit = 0;
        double newBalance = 0;

        public TransactionForm()
        {
            InitializeComponent();
        }      

        public void stringToDouble()
        {
            accBalance = Convert.ToDouble(txtAccBalance.Text);
            accWithdrawal = Convert.ToDouble(txtCashInput.Text);
            accDeposit = Convert.ToDouble(txtCashInput.Text);
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {        
                if (txtAccNumber.Text == "")
                {
                    string inputNumber = "Please Input number";
                    MessageBox.Show(inputNumber);
                }
                else 
                {
                    connectionString = @"Data Source=WIN-U412I9LKOT5\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True";
                    con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BankTable values (@IdACcNumber,@accName,@accBalance)", con);
                    cmd.Parameters.AddWithValue("@IdACcNumber", int.Parse(txtAccNumber.Text));
                    cmd.Parameters.AddWithValue("@accName", txtAccName.Text);
                    cmd.Parameters.AddWithValue("@accBalance", double.Parse(txtAccNumber.Text));
            
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Succcessfully Saved");
                }
        }
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            connectionString = @"Data Source=WIN-U412I9LKOT5\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update BankTable set accName=@accName, accBalance=@accBalance where IdACcNumber = @IdACcNumber", con);
            cmd.Parameters.AddWithValue("@IdACcNumber", int.Parse(txtAccNumber.Text));
            cmd.Parameters.AddWithValue("@accName", txtAccName.Text);
            cmd.Parameters.AddWithValue("@accBalance", Convert.ToDouble(txtAccBalance.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succcessfully Updated");
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            connectionString = @"Data Source=WIN-U412I9LKOT5\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete BankTable where IdACcNumber = @IdACcNumber", con);
            cmd.Parameters.AddWithValue("@IdACcNumber", int.Parse(txtAccNumber.Text));
            cmd.ExecuteNonQuery();
            con.Close();            
            MessageBox.Show("Succcessfully Deleted");
        }

        private void txtAccNumber_TextChanged(object sender, EventArgs e)
        {
            connectionString = @"Data Source=WIN-U412I9LKOT5\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();

            if (txtAccNumber.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select accName,accBalance from BankTable where IdACcNumber = @IdACcNumber", con);
                cmd.Parameters.AddWithValue("@IdACcNumber", int.Parse(txtAccNumber.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txtAccName.Text = da.GetValue(0).ToString();
                    txtAccBalance.Text = da.GetValue(1).ToString();
                    accBalance = Convert.ToDouble(txtAccBalance.Text);
                    txtAccBalance.Text = String.Format("{0:#,##0.00}", accBalance);
                }
                con.Close();
            }
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {         
            try
            {
                double withdrawCash = Convert.ToDouble(txtCashInput.Text);
                if (accBalance < withdrawCash)
                {
                    MessageBox.Show("Your account balance \nis not enough.");
                    txtCashInput.Clear();
                }
                else
                {
                    connectionString = @"Data Source=WIN-U412I9LKOT5\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True";
                    con = new SqlConnection(connectionString);
                    con.Open();
                    stringToDouble();
                    newBalance = accBalance - accDeposit;
                    txtAccBalance.Text = String.Format("{0:#,##0.00}", newBalance);
                    txtCashInput.Clear();
                    SqlCommand cmd = new SqlCommand("Update BankTable set accName=@accName, accBalance=@accBalance where IdACcNumber = @IdACcNumber", con);
                    cmd.Parameters.AddWithValue("@IdACcNumber", int.Parse(txtAccNumber.Text));
                    cmd.Parameters.AddWithValue("@accName", txtAccName.Text);
                    cmd.Parameters.AddWithValue("@accBalance", Convert.ToDouble(txtAccBalance.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Succcessfully Withdrawal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }
        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                stringToDouble();
                newBalance = accBalance + accDeposit;
                txtAccBalance.Text = String.Format("{0:#,##0.00}", newBalance);
                txtCashInput.Clear();
            }
            catch 
            {
                MessageBox.Show("Please Input amount");
            }
        }
        private void txtAccNumber_KeyPress(object sender, KeyPressEventArgs e)
        {         
         e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtCashInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtCashInput_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
