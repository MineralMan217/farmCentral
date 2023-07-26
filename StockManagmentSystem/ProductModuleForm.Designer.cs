
namespace StockManagmentSystem
{
    partial class ProductModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModuleForm));
            this.cboxPcategory = new System.Windows.Forms.ComboBox();
            this.btnClearProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.lblPcategory = new System.Windows.Forms.Label();
            this.txtPdescription = new System.Windows.Forms.TextBox();
            this.lblPdescription = new System.Windows.Forms.Label();
            this.txtPprice = new System.Windows.Forms.TextBox();
            this.lblPprice = new System.Windows.Forms.Label();
            this.txtPqty = new System.Windows.Forms.TextBox();
            this.lblPqty = new System.Windows.Forms.Label();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.lblPname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoPBox = new System.Windows.Forms.PictureBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxPcategory
            // 
            this.cboxPcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPcategory.FormattingEnabled = true;
            this.cboxPcategory.Location = new System.Drawing.Point(167, 279);
            this.cboxPcategory.Name = "cboxPcategory";
            this.cboxPcategory.Size = new System.Drawing.Size(288, 23);
            this.cboxPcategory.TabIndex = 34;
            // 
            // btnClearProduct
            // 
            this.btnClearProduct.BackColor = System.Drawing.Color.Teal;
            this.btnClearProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearProduct.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearProduct.ForeColor = System.Drawing.Color.White;
            this.btnClearProduct.Location = new System.Drawing.Point(377, 336);
            this.btnClearProduct.Name = "btnClearProduct";
            this.btnClearProduct.Size = new System.Drawing.Size(70, 30);
            this.btnClearProduct.TabIndex = 31;
            this.btnClearProduct.Text = "CLEAR";
            this.btnClearProduct.UseVisualStyleBackColor = false;
            this.btnClearProduct.Click += new System.EventHandler(this.btnClearProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProduct.Location = new System.Drawing.Point(300, 336);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(70, 30);
            this.btnUpdateProduct.TabIndex = 32;
            this.btnUpdateProduct.Text = "UPDATE";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProduct.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveProduct.ForeColor = System.Drawing.Color.White;
            this.btnSaveProduct.Location = new System.Drawing.Point(224, 336);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(70, 30);
            this.btnSaveProduct.TabIndex = 33;
            this.btnSaveProduct.Text = "SAVE";
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // lblPcategory
            // 
            this.lblPcategory.AutoSize = true;
            this.lblPcategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPcategory.Location = new System.Drawing.Point(29, 279);
            this.lblPcategory.Name = "lblPcategory";
            this.lblPcategory.Size = new System.Drawing.Size(67, 17);
            this.lblPcategory.TabIndex = 24;
            this.lblPcategory.Text = "Category:";
            // 
            // txtPdescription
            // 
            this.txtPdescription.Location = new System.Drawing.Point(167, 237);
            this.txtPdescription.Name = "txtPdescription";
            this.txtPdescription.Size = new System.Drawing.Size(288, 23);
            this.txtPdescription.TabIndex = 28;
            // 
            // lblPdescription
            // 
            this.lblPdescription.AutoSize = true;
            this.lblPdescription.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPdescription.Location = new System.Drawing.Point(29, 239);
            this.lblPdescription.Name = "lblPdescription";
            this.lblPdescription.Size = new System.Drawing.Size(79, 17);
            this.lblPdescription.TabIndex = 25;
            this.lblPdescription.Text = "Description:";
            // 
            // txtPprice
            // 
            this.txtPprice.Location = new System.Drawing.Point(167, 197);
            this.txtPprice.Name = "txtPprice";
            this.txtPprice.Size = new System.Drawing.Size(288, 23);
            this.txtPprice.TabIndex = 29;
            // 
            // lblPprice
            // 
            this.lblPprice.AutoSize = true;
            this.lblPprice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPprice.Location = new System.Drawing.Point(29, 200);
            this.lblPprice.Name = "lblPprice";
            this.lblPprice.Size = new System.Drawing.Size(41, 17);
            this.lblPprice.TabIndex = 26;
            this.lblPprice.Text = "Price:";
            // 
            // txtPqty
            // 
            this.txtPqty.Location = new System.Drawing.Point(167, 157);
            this.txtPqty.Name = "txtPqty";
            this.txtPqty.Size = new System.Drawing.Size(288, 23);
            this.txtPqty.TabIndex = 30;
            // 
            // lblPqty
            // 
            this.lblPqty.AutoSize = true;
            this.lblPqty.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPqty.Location = new System.Drawing.Point(29, 157);
            this.lblPqty.Name = "lblPqty";
            this.lblPqty.Size = new System.Drawing.Size(32, 17);
            this.lblPqty.TabIndex = 27;
            this.lblPqty.Text = "Qty:";
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(167, 117);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(288, 23);
            this.txtPname.TabIndex = 23;
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPname.Location = new System.Drawing.Point(29, 119);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(97, 17);
            this.lblPname.TabIndex = 22;
            this.lblPname.Text = "Product Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.LogoPBox);
            this.panel1.Controls.Add(this.lblProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 79);
            this.panel1.TabIndex = 21;
            // 
            // LogoPBox
            // 
            this.LogoPBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPBox.Image")));
            this.LogoPBox.Location = new System.Drawing.Point(439, 2);
            this.LogoPBox.Name = "LogoPBox";
            this.LogoPBox.Size = new System.Drawing.Size(37, 38);
            this.LogoPBox.TabIndex = 10;
            this.LogoPBox.TabStop = false;
            this.LogoPBox.Click += new System.EventHandler(this.LogoPBox_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(12, 20);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(128, 20);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Product Module";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(32, 361);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(66, 15);
            this.lblProductId.TabIndex = 35;
            this.lblProductId.Text = "Product ID:";
            // 
            // ProductModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 421);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.cboxPcategory);
            this.Controls.Add(this.btnClearProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.lblPcategory);
            this.Controls.Add(this.txtPdescription);
            this.Controls.Add(this.lblPdescription);
            this.Controls.Add(this.txtPprice);
            this.Controls.Add(this.lblPprice);
            this.Controls.Add(this.txtPqty);
            this.Controls.Add(this.lblPqty);
            this.Controls.Add(this.txtPname);
            this.Controls.Add(this.lblPname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductModuleForm";
            this.Load += new System.EventHandler(this.ProductModuleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnClearProduct;
        public System.Windows.Forms.Button btnUpdateProduct;
        public System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.Label lblPcategory;
        public System.Windows.Forms.TextBox txtPdescription;
        private System.Windows.Forms.Label lblPdescription;
        public System.Windows.Forms.TextBox txtPprice;
        private System.Windows.Forms.Label lblPprice;
        public System.Windows.Forms.TextBox txtPqty;
        private System.Windows.Forms.Label lblPqty;
        public System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.Label lblPname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox LogoPBox;
        private System.Windows.Forms.Label lblProduct;
        public System.Windows.Forms.Label lblProductId;
        public System.Windows.Forms.ComboBox cboxPcategory;
    }
}