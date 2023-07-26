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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbSMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void showChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowChkBox.Checked == false)
                PassTxtbox.UseSystemPasswordChar = true;
            else

                PassTxtbox.UseSystemPasswordChar = false;           
        }

        private void clearLbl_Click(object sender, EventArgs e)
        {
            PassTxtbox.Clear();
            UserTxtbox.Clear();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Farm Central", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mainLbl_Click(object sender, EventArgs e)
        {

        }

        private void LoginButt_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM tbUser WHERE username=@username AND password=@password", con);
                cm.Parameters.AddWithValue("@username", UserTxtbox.Text);
                cm.Parameters.AddWithValue("@password", PassTxtbox.Text);
                con.Open();
                dr = cm.ExecuteReader();
                dr.Read();
                if(dr.HasRows)
                {
                    MessageBox.Show("Welcome, " + dr["fullname"].ToString() + "", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm form = new MainForm();
                    this.Hide();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("INVALID USERNAME OR PASSWORD !", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                con.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
