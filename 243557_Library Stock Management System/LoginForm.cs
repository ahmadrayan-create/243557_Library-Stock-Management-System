using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;

namespace _243557_Library_Stock_Management_System
{
    public partial class LoginForm : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-K2S8IVF\\SQLEXPRESS;Initial Catalog=LibraryStockDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string selectQuery = "SELECT COUNT(UserID) FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(selectQuery, conn);

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                // ExecuteScalar is the simplest logic for checking existence
                int userCount = (int)cmd.ExecuteScalar();

                if (userCount == 1)
                {
                    Form1 mainForm = new Form1();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}