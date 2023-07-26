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
    public partial class UserModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbSMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public UserModuleForm()
        {
            InitializeComponent();
        }

       

        private void LogoPBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
            SaveBttn.Enabled = true;
            UpdateBtn.Enabled = false; 

        }

        

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (txtRetypePassword.Text != txtPassword.Text)
            {
                MessageBox.Show("PASSWORDS DO NOT MATCH !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (MessageBox.Show("Are you sure you want to update this user?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbUser SET fullname=@fullname, password=@password, phone=@phone WHERE username LIKE '"+ txtUsername.Text + "'", con);
                    cm.Parameters.AddWithValue("@fullname", txtFullname.Text);
                    cm.Parameters.AddWithValue("@password", txtPassword.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully updated", "Farm Central", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtUsername.Clear();
            txtFullname.Clear();
            txtPassword.Clear();
            txtRetypePassword.Clear();
            txtPhone.Clear();
        }

        private void SaveBttn_Click_1(object sender, EventArgs e)
        {
           
            
            try
            {
                if (txtRetypePassword.Text != txtPassword.Text)
                {
                    MessageBox.Show("PASSWORDS DO NOT MATCH !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                if (MessageBox.Show("Are you sure you want to save this user?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbUser(username,fullname,password,phone)VALUES(@username,@fullname,@password,@phone)", con);
                    cm.Parameters.AddWithValue("@username", txtUsername.Text);
                    cm.Parameters.AddWithValue("@fullname", txtFullname.Text);
                    cm.Parameters.AddWithValue("@password", txtPassword.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been successfully saved", "Farm Central",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Clear();
                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
