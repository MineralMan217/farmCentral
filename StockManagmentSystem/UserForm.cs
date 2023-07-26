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
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbSMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public UserForm()
        {
            InitializeComponent();
            LoadUser();
        }
        public void LoadUser()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbUser", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUser.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }

            dr.Close();
            con.Close();


        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserModuleForm moduleForm = new UserModuleForm();
            moduleForm.SaveBttn.Enabled = true;
            moduleForm.UpdateBtn.Enabled = false;
            moduleForm.ShowDialog();
            LoadUser();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUser.Columns[e.ColumnIndex].Name;

            if(colName == "Edit")
            {
                UserModuleForm moduleForm = new UserModuleForm();
                moduleForm.txtUsername.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                moduleForm.txtFullname.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                moduleForm.txtPassword.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                moduleForm.txtPhone.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();


                moduleForm.SaveBttn.Enabled = false;
                moduleForm.UpdateBtn.Enabled = true;
                moduleForm.txtUsername.Enabled = false; 
                moduleForm.ShowDialog();
            }
            else if(colName == "Delete")
            {
                if(MessageBox.Show("Are you sure you wish to delete this user?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbUser WHERE username LIKE '" + dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has  been successfuly deleted", "Farm Central", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadUser();
        }
    }
}
