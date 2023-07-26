using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace StockManagmentSystem
{
    public partial class ProductModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbSMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ProductModuleForm()
        {
            InitializeComponent();
            LoadCategory();
        }

      public void LoadCategory()
        {
            cboxPcategory.Items.Clear();
            cm = new SqlCommand("SELECT * FROM tbCategory", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cboxPcategory.Items.Add(dr[1].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void LogoPBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try 
            { 

                if (MessageBox.Show("Are you sure you want to save this product?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbProduct(pname,pqty,pprice,pdescription,pcategory)VALUES(@pname,@pqty,@pprice,@pdescription,@pcategory)", con);
                    cm.Parameters.AddWithValue("@pname", txtPname.Text);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(txtPqty.Text));
                    cm.Parameters.AddWithValue("@pprice", Convert.ToInt16(txtPprice.Text));
                    cm.Parameters.AddWithValue("@pdescription", txtPdescription.Text);
                    cm.Parameters.AddWithValue("@pcategory", cboxPcategory.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been successfully saved", "Farm Central", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }


        }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
}

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this Product?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbProduct SET pname=@pname,pqty=@pqty,pprice=@pprice,pdescription=@pdescription,pcategory=@pcategory WHERE pid LIKE '" + lblProductId.Text + "'", con);
                    cm.Parameters.AddWithValue("@pname", txtPname.Text);
                    cm.Parameters.AddWithValue("@pqty", Convert.ToInt16(txtPqty.Text));
                    cm.Parameters.AddWithValue("@pprice", Convert.ToInt16(txtPprice.Text));
                    cm.Parameters.AddWithValue("@pdescription", txtPdescription.Text);
                    cm.Parameters.AddWithValue("@pcategory", cboxPcategory.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Product has been successfully updated", "Farm Central", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
            public void Clear()
            {
            txtPname.Clear();
            txtPqty.Clear();
            txtPprice.Clear();
            txtPdescription.Clear();
            cboxPcategory.Text= "";


            }

        private void btnClearProduct_Click(object sender, EventArgs e)
        {
            Clear();
            btnSaveProduct.Enabled = true;
            btnUpdateProduct.Enabled = false;
        }

        private void ProductModuleForm_Load(object sender, EventArgs e)
        {

        }
    }
    }

