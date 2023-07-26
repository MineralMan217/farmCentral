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
    public partial class CustomerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbSMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomer();
        }

        public void LoadCustomer()
        {
            int i = 0;
            dgvCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCustomer", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }

            dr.Close();
            con.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerModuleForm moduleForm = new CustomerModuleForm();
            moduleForm.btnSaveCustomer.Enabled = true;
            moduleForm.btnUpdateCustomer.Enabled = false;
            moduleForm.ShowDialog();
            LoadCustomer();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCustomer.Columns[e.ColumnIndex].Name;

            if (colName == "Edit")
            {
                CustomerModuleForm moduleForm = new CustomerModuleForm();
                moduleForm.lblCustId.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                moduleForm.txtNameCustomer.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                moduleForm.txtPhoneCustomer.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
               


                moduleForm.btnSaveCustomer.Enabled = false;
                moduleForm.btnUpdateCustomer.Enabled = true;
                moduleForm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you wish to delete this customer?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbCustomer WHERE cid LIKE '" + dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has  been successfuly deleted", "Farm Central", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadCustomer();
        }
    }
}
