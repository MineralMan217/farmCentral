
namespace StockManagmentSystem
{
    partial class CustomerModuleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerModuleForm));
            this.panelHeading = new System.Windows.Forms.Panel();
            this.LogoPBox = new System.Windows.Forms.PictureBox();
            this.lblCustModule = new System.Windows.Forms.Label();
            this.btnClearCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.txtPhoneCustomer = new System.Windows.Forms.TextBox();
            this.lblCustPhone = new System.Windows.Forms.Label();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustId = new System.Windows.Forms.Label();
            this.panelHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeading
            // 
            this.panelHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelHeading.Controls.Add(this.LogoPBox);
            this.panelHeading.Controls.Add(this.lblCustModule);
            this.panelHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeading.Location = new System.Drawing.Point(0, 0);
            this.panelHeading.Name = "panelHeading";
            this.panelHeading.Size = new System.Drawing.Size(465, 79);
            this.panelHeading.TabIndex = 1;
            // 
            // LogoPBox
            // 
            this.LogoPBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPBox.Image")));
            this.LogoPBox.Location = new System.Drawing.Point(428, 2);
            this.LogoPBox.Name = "LogoPBox";
            this.LogoPBox.Size = new System.Drawing.Size(37, 38);
            this.LogoPBox.TabIndex = 10;
            this.LogoPBox.TabStop = false;
            this.LogoPBox.Click += new System.EventHandler(this.LogoPBox_Click);
            // 
            // lblCustModule
            // 
            this.lblCustModule.AutoSize = true;
            this.lblCustModule.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustModule.ForeColor = System.Drawing.Color.White;
            this.lblCustModule.Location = new System.Drawing.Point(12, 20);
            this.lblCustModule.Name = "lblCustModule";
            this.lblCustModule.Size = new System.Drawing.Size(140, 20);
            this.lblCustModule.TabIndex = 0;
            this.lblCustModule.Text = "Customer Module";
            // 
            // btnClearCustomer
            // 
            this.btnClearCustomer.BackColor = System.Drawing.Color.Teal;
            this.btnClearCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCustomer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearCustomer.ForeColor = System.Drawing.Color.White;
            this.btnClearCustomer.Location = new System.Drawing.Point(354, 208);
            this.btnClearCustomer.Name = "btnClearCustomer";
            this.btnClearCustomer.Size = new System.Drawing.Size(70, 30);
            this.btnClearCustomer.TabIndex = 16;
            this.btnClearCustomer.Text = "CLEAR";
            this.btnClearCustomer.UseVisualStyleBackColor = false;
            this.btnClearCustomer.Click += new System.EventHandler(this.btnClearCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(278, 208);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(70, 30);
            this.btnUpdateCustomer.TabIndex = 17;
            this.btnUpdateCustomer.Text = "UPDATE";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSaveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCustomer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSaveCustomer.Location = new System.Drawing.Point(202, 208);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(70, 30);
            this.btnSaveCustomer.TabIndex = 18;
            this.btnSaveCustomer.Text = "SAVE";
            this.btnSaveCustomer.UseVisualStyleBackColor = false;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // txtPhoneCustomer
            // 
            this.txtPhoneCustomer.Location = new System.Drawing.Point(127, 156);
            this.txtPhoneCustomer.Name = "txtPhoneCustomer";
            this.txtPhoneCustomer.Size = new System.Drawing.Size(288, 23);
            this.txtPhoneCustomer.TabIndex = 12;
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustPhone.Location = new System.Drawing.Point(46, 158);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(48, 17);
            this.lblCustPhone.TabIndex = 8;
            this.lblCustPhone.Text = "Phone:";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(127, 116);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(288, 23);
            this.txtNameCustomer.TabIndex = 7;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustName.Location = new System.Drawing.Point(46, 118);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(47, 17);
            this.lblCustName.TabIndex = 6;
            this.lblCustName.Text = "Name:";
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Location = new System.Drawing.Point(12, 223);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(76, 15);
            this.lblCustId.TabIndex = 19;
            this.lblCustId.Text = "Customer ID:";
            // 
            // CustomerModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 275);
            this.Controls.Add(this.lblCustId);
            this.Controls.Add(this.btnClearCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnSaveCustomer);
            this.Controls.Add(this.txtPhoneCustomer);
            this.Controls.Add(this.lblCustPhone);
            this.Controls.Add(this.txtNameCustomer);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.panelHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerModuleForm";
            this.panelHeading.ResumeLayout(false);
            this.panelHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeading;
        private System.Windows.Forms.PictureBox LogoPBox;
        private System.Windows.Forms.Label lblCustModule;
        public System.Windows.Forms.Button btnClearCustomer;
        public System.Windows.Forms.Button btnUpdateCustomer;
        public System.Windows.Forms.Button btnSaveCustomer;
        public System.Windows.Forms.TextBox txtPhoneCustomer;
        private System.Windows.Forms.Label lblCustPhone;
        public System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.Label lblCustName;
        public System.Windows.Forms.Label lblCustId;
    }
}