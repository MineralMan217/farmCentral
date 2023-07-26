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
    public partial class CategoryModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbSMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public CategoryModuleForm()
        {
            InitializeComponent();
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this category?", "Category Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbCategory(catname)VALUES(@catname)", con);
                    cm.Parameters.AddWithValue("@catname", txtNameCategory.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category has been successfully saved", "Farm Central", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtNameCategory.Clear();


        }

        private void btnClearCategory_Click(object sender, EventArgs e)
        {
            Clear();
            btnSaveCategory.Enabled = true;
            btnUpdateCategory.Enabled = false;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this category?", "Category Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbCategory SET catname=@catname WHERE catid LIKE '" + lblCatId.Text + "'", con);
                    cm.Parameters.AddWithValue("@catname", txtNameCategory.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Category has been successfully updated", "Farm Central", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void LogoPBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
