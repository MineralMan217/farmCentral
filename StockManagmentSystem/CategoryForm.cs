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
    public partial class CategoryForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbSMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public CategoryForm()
        {
            InitializeComponent();
            LoadCategory();
        }

        public void LoadCategory()
        {
            int i = 0;
            dgvCategory.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCategory", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCategory.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }

            dr.Close();
            con.Close();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {

            CategoryModuleForm moduleForm = new CategoryModuleForm();
            moduleForm.btnSaveCategory.Enabled = true;
            moduleForm.btnUpdateCategory.Enabled = false;
            moduleForm.ShowDialog();
            LoadCategory();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;

            if (colName == "Edit")
            {
                CategoryModuleForm moduleForm = new CategoryModuleForm();
                moduleForm.lblCatId.Text = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                moduleForm.txtNameCategory.Text = dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString();



                moduleForm.btnSaveCategory.Enabled = false;
                moduleForm.btnUpdateCategory.Enabled = true;
                moduleForm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you wish to delete this category?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbCategory WHERE catid LIKE '" + dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has  been successfuly deleted", "Farm Central", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadCategory();
        }
    }
}
