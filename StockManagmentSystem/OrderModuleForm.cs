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

namespace StockManagmentSystem
{
    public partial class OrderModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbSMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        int Qty = 0;
        public OrderModuleForm()
        {
            InitializeComponent();
            LoadCustomer();
            LoadProduct();
        }



        public void LoadCustomer()
        {
            int i = 0;
            dgvCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT cid, cname FROM tbCustomer WHERE CONCAT(cid, cname) LIKE '%" + txtSearchCust.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }

            dr.Close();
            con.Close();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pname,pprice,pdescription,pcategory) LIKE '%" + txtSearchProd.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }

            dr.Close();
            con.Close();

        }

        private void txtSearchCust_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void txtSearchProd_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

     


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            GetQty();
            if (Convert.ToInt16(numericUpDown1.Value) > Qty)
            {
                MessageBox.Show("Not enough stock at the moment !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDown1.Value = numericUpDown1.Value - 1;
                return;
            }
            if ((Convert.ToInt16(numericUpDown1.Value) > 0))
                {
                int total = Convert.ToInt16(txtProdPrice.Text) * Convert.ToInt16(numericUpDown1.Value);
                txtProductTotal.Text = total.ToString();
                }
        }

    

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerID.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCustomerName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductID.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtProductName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtProdPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            //Qty = Convert.ToInt16(dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString());
           
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "")
            {
                MessageBox.Show("Please select a customer !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtProductID.Text == "")
            {
                MessageBox.Show("Please select a product !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                if (MessageBox.Show("Are you sure you want to insert this Order?", " Insert Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbOrder(odate, pid, cid, qty, price, total)VALUES(@odate, @pid, @cid, @qty, @price, @total)", con);
                    cm.Parameters.AddWithValue("@odate", dtpOrderDate.Value);
                    cm.Parameters.AddWithValue("@pid", Convert.ToInt16(txtProductID.Text));
                    cm.Parameters.AddWithValue("@cid", Convert.ToInt16(txtCustomerID.Text));
                    cm.Parameters.AddWithValue("@qty", Convert.ToInt16(numericUpDown1.Value));
                    cm.Parameters.AddWithValue("@price", Convert.ToInt16(txtProdPrice.Text));
                    cm.Parameters.AddWithValue("@total", Convert.ToInt16(txtProductTotal.Text));
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Order has been successfully Inserted", "Farm Central", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

                    cm = new SqlCommand("UPDATE tbProduct SET pqty = (pqty-@pqty) WHERE pid LIKE '" + txtProductID.Text + "'", con);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(numericUpDown1.Text));

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    LoadProduct();

                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

            public void Clear()
            {
            txtProductID.Clear();
            txtProductName.Clear();

            txtCustomerID.Clear();
            txtCustomerName.Clear();

            txtProdPrice.Clear();
            numericUpDown1.Value = 0;
            txtProductTotal.Clear();
            dtpOrderDate.Value = DateTime.Now;
           
            }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

      public void GetQty()
        {
            //int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT pqty FROM tbProduct WHERE pid= '" + txtProductID.Text + "'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Qty = Convert.ToInt32(dr[0].ToString());
            }

            dr.Close();
            con.Close();

        }
    }
    }
    
