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
    public partial class CustomerModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbSMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public CustomerModuleForm()
        {
            InitializeComponent();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Are you sure you want to save this customer?", "Customer Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbCustomer(cname,cphone)VALUES(@cname,@cphone)", con);
                    cm.Parameters.AddWithValue("@cname", txtNameCustomer.Text);
                    cm.Parameters.AddWithValue("@cphone", txtPhoneCustomer.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer has been successfully saved", "Farm Central", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        public void Clear()
        {
            txtNameCustomer.Clear();
            txtPhoneCustomer.Clear();
           

        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            Clear();
            btnSaveCustomer.Enabled = true;
            btnUpdateCustomer.Enabled = false;
        }

        private void LogoPBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this user?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbCustomer SET cname=@cname, cphone=@cphone WHERE cid LIKE '" + lblCustId.Text + "'", con);
                    cm.Parameters.AddWithValue("@cname", txtNameCustomer.Text);
                    cm.Parameters.AddWithValue("@cphone", txtPhoneCustomer.Text);
                   
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer has been successfully updated", "Farm Central", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

      
    }
    }
 

