
namespace StockManagmentSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoPBox = new System.Windows.Forms.PictureBox();
            this.MainLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShowChkBox = new System.Windows.Forms.CheckBox();
            this.ClearLbl = new System.Windows.Forms.Label();
            this.UserLbl = new System.Windows.Forms.Label();
            this.UserTxtbox = new System.Windows.Forms.TextBox();
            this.PassTxtbox = new System.Windows.Forms.TextBox();
            this.PassLbl = new System.Windows.Forms.Label();
            this.LoginButt = new System.Windows.Forms.Button();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.LogoPBox);
            this.panel1.Controls.Add(this.MainLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 60);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LogoPBox
            // 
            this.LogoPBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPBox.Image")));
            this.LogoPBox.Location = new System.Drawing.Point(276, 0);
            this.LogoPBox.Name = "LogoPBox";
            this.LogoPBox.Size = new System.Drawing.Size(37, 38);
            this.LogoPBox.TabIndex = 9;
            this.LogoPBox.TabStop = false;
            this.LogoPBox.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // MainLbl
            // 
            this.MainLbl.AutoSize = true;
            this.MainLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainLbl.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainLbl.ForeColor = System.Drawing.Color.White;
            this.MainLbl.Location = new System.Drawing.Point(12, 41);
            this.MainLbl.Name = "MainLbl";
            this.MainLbl.Size = new System.Drawing.Size(279, 16);
            this.MainLbl.TabIndex = 3;
            this.MainLbl.Text = "FARM CENTRAL MANAGEMENT SYSTEM";
            this.MainLbl.Click += new System.EventHandler(this.mainLbl_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ShowChkBox);
            this.panel2.Controls.Add(this.ClearLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 60);
            this.panel2.TabIndex = 1;
            // 
            // ShowChkBox
            // 
            this.ShowChkBox.AutoSize = true;
            this.ShowChkBox.Location = new System.Drawing.Point(152, 15);
            this.ShowChkBox.Name = "ShowChkBox";
            this.ShowChkBox.Size = new System.Drawing.Size(108, 19);
            this.ShowChkBox.TabIndex = 1;
            this.ShowChkBox.Text = "Show Password";
            this.ShowChkBox.UseVisualStyleBackColor = true;
            this.ShowChkBox.CheckedChanged += new System.EventHandler(this.showChkBox_CheckedChanged);
            // 
            // ClearLbl
            // 
            this.ClearLbl.AutoSize = true;
            this.ClearLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClearLbl.Location = new System.Drawing.Point(57, 16);
            this.ClearLbl.Name = "ClearLbl";
            this.ClearLbl.Size = new System.Drawing.Size(34, 15);
            this.ClearLbl.TabIndex = 0;
            this.ClearLbl.Text = "Clear";
            this.ClearLbl.Click += new System.EventHandler(this.clearLbl_Click);
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserLbl.ForeColor = System.Drawing.Color.Black;
            this.UserLbl.Location = new System.Drawing.Point(25, 184);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(84, 18);
            this.UserLbl.TabIndex = 2;
            this.UserLbl.Text = "Username:";
            this.UserLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserTxtbox
            // 
            this.UserTxtbox.Location = new System.Drawing.Point(25, 205);
            this.UserTxtbox.Name = "UserTxtbox";
            this.UserTxtbox.Size = new System.Drawing.Size(253, 23);
            this.UserTxtbox.TabIndex = 3;
            this.UserTxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PassTxtbox
            // 
            this.PassTxtbox.Location = new System.Drawing.Point(25, 298);
            this.PassTxtbox.Name = "PassTxtbox";
            this.PassTxtbox.Size = new System.Drawing.Size(253, 23);
            this.PassTxtbox.TabIndex = 5;
            this.PassTxtbox.UseSystemPasswordChar = true;
            this.PassTxtbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassLbl.ForeColor = System.Drawing.Color.Black;
            this.PassLbl.Location = new System.Drawing.Point(25, 277);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(80, 18);
            this.PassLbl.TabIndex = 4;
            this.PassLbl.Text = "Password:";
            this.PassLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginButt
            // 
            this.LoginButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LoginButt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginButt.FlatAppearance.BorderSize = 0;
            this.LoginButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginButt.ForeColor = System.Drawing.Color.White;
            this.LoginButt.Location = new System.Drawing.Point(0, 390);
            this.LoginButt.Name = "LoginButt";
            this.LoginButt.Size = new System.Drawing.Size(303, 31);
            this.LoginButt.TabIndex = 6;
            this.LoginButt.Text = "Login";
            this.LoginButt.UseVisualStyleBackColor = false;
            this.LoginButt.Click += new System.EventHandler(this.LoginButt_Click);
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicBox.Image")));
            this.LogoPicBox.Location = new System.Drawing.Point(0, 60);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(303, 35);
            this.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicBox.TabIndex = 7;
            this.LogoPicBox.TabStop = false;
            this.LogoPicBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Label4.Location = new System.Drawing.Point(25, 131);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(235, 16);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Please enter your credentials below";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(303, 481);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.LogoPicBox);
            this.Controls.Add(this.LoginButt);
            this.Controls.Add(this.PassTxtbox);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.UserTxtbox);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.TextBox UserTxtbox;
        private System.Windows.Forms.TextBox PassTxtbox;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.Button LoginButt;
        private System.Windows.Forms.PictureBox LogoPicBox;
        private System.Windows.Forms.Label MainLbl;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label ClearLbl;
        private System.Windows.Forms.CheckBox ShowChkBox;
        private System.Windows.Forms.PictureBox LogoPBox;
    }
}

