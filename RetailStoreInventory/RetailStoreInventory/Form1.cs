using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RetailStoreInventory
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RetailStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public Form1()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Products", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Products (Name, Price, Quantity) VALUES (@Name, @Price, @Quantity)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadProducts();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtProductID.Text))
                {
                    MessageBox.Show("Please select a product to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Products SET Name=@Name, Price=@Price, Quantity=@Quantity WHERE ProductID=@ProductID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                    cmd.Parameters.AddWithValue("@ProductID", int.Parse(txtProductID.Text));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadProducts();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtProductID.Text))
                {
                    MessageBox.Show("Please select a product to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Products WHERE ProductID=@ProductID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ProductID", int.Parse(txtProductID.Text));
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    LoadProducts();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txtProductID.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make ProductID textbox read-only
            txtProductID.ReadOnly = true;
        }
    }
}