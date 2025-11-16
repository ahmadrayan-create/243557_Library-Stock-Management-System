using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;

namespace _243557_Library_Stock_Management_System
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-K2S8IVF\\SQLEXPRESS;Initial Catalog=LibraryStockDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBookData();
        }

        private void LoadBookData()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataReader rdr = null;
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                string selectQuery = "SELECT BookID, Title, Author, Category, Quantity, Price, RackNo FROM Books ORDER BY Title";
                SqlCommand cmd = new SqlCommand(selectQuery, conn);

                // Uses SqlDataReader (Connected Architecture)
                rdr = cmd.ExecuteReader();

                dt.Load(rdr);
                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: Could not load data. Check SQL Server connection/schema. " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadBookData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || !int.TryParse(textBox6.Text, out int quantity) || !decimal.TryParse(textBox7.Text, out decimal price))
            {
                MessageBox.Show("Please enter valid Title, Author, numeric Quantity, and Price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string insertQuery = "INSERT INTO Books (Title, Author, Publisher, Category, ISBN, Quantity, Price, RackNo, DateAdded) VALUES (@Title, @Author, @Publisher, @Category, @ISBN, @Quantity, @Price, @RackNo, @DateAdded)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);

                cmd.Parameters.AddWithValue("@Title", textBox1.Text);
                cmd.Parameters.AddWithValue("@Author", textBox2.Text);
                cmd.Parameters.AddWithValue("@Publisher", textBox3.Text);
                cmd.Parameters.AddWithValue("@Category", textBox4.Text);
                cmd.Parameters.AddWithValue("@ISBN", textBox5.Text);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@RackNo", textBox8.Text);
                cmd.Parameters.AddWithValue("@DateAdded", dateTimePicker1.Value.Date);

                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("New book record stored successfully. Rows affected: " + affectedRows, "Success");
                    LoadBookData();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: Could not add book. " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox9.Text, out int bookID) || !int.TryParse(textBox6.Text, out int newQuantity))
            {
                MessageBox.Show("Please enter a valid Book ID (textBox9) and new Quantity (textBox6).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string updateQuery = "UPDATE Books SET Quantity = @Quantity, Price = @Price, Category = @Category, RackNo = @RackNo WHERE BookID = @BookID";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);

                cmd.Parameters.AddWithValue("@Quantity", newQuantity);
                cmd.Parameters.AddWithValue("@Price", decimal.TryParse(textBox7.Text, out decimal p) ? p : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Category", textBox4.Text);
                cmd.Parameters.AddWithValue("@RackNo", textBox8.Text);
                cmd.Parameters.AddWithValue("@BookID", bookID);

                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Book details updated successfully. Rows affected: " + affectedRows, "Success");
                    LoadBookData();
                }
                else if (affectedRows == 0)
                {
                    MessageBox.Show("Book ID not found or no changes were made.", "Info");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: Could not update book. " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox9.Text, out int bookID))
            {
                MessageBox.Show("Please enter a valid Book ID for deletion (textBox9).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Book ID {bookID}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string deleteQuery = "DELETE FROM Books WHERE BookID = @BookID";
                SqlCommand cmd = new SqlCommand(deleteQuery, conn);

                cmd.Parameters.AddWithValue("@BookID", bookID);

                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Book record deleted successfully. Rows affected: " + affectedRows, "Success");
                    LoadBookData();
                }
                else
                {
                    MessageBox.Show("No book found with that ID.", "Info");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error: Could not delete book. " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox10.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                LoadBookData();
                return;
            }

            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string searchQuery = "SELECT BookID, Title, Author, Category, Quantity, Price, RackNo FROM Books WHERE Title LIKE @Search OR Author LIKE @Search OR ISBN LIKE @Search ORDER BY Title";

                SqlCommand cmd = new SqlCommand(searchQuery, conn);
                cmd.Parameters.AddWithValue("@Search", $"%{searchTerm}%");

                // Uses SqlDataAdapter (Disconnected Architecture)
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                MessageBox.Show($"Search complete. Found {dt.Rows.Count} matching records.", "Search Result");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error during search: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}