
namespace StockManagmentSystem
{
    partial class CategoryModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryModuleForm));
            this.lblCatId = new System.Windows.Forms.Label();
            this.btnClearCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.lblCatName = new System.Windows.Forms.Label();
            this.panelHeading = new System.Windows.Forms.Panel();
            this.LogoPBox = new System.Windows.Forms.PictureBox();
            this.lblCatModule = new System.Windows.Forms.Label();
            this.panelHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCatId
            // 
            this.lblCatId.AutoSize = true;
            this.lblCatId.Location = new System.Drawing.Point(21, 200);
            this.lblCatId.Name = "lblCatId";
            this.lblCatId.Size = new System.Drawing.Size(72, 15);
            this.lblCatId.TabIndex = 28;
            this.lblCatId.Text = "Category ID:";
            // 
            // btnClearCategory
            // 
            this.btnClearCategory.BackColor = System.Drawing.Color.Teal;
            this.btnClearCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearCategory.ForeColor = System.Drawing.Color.White;
            this.btnClearCategory.Location = new System.Drawing.Point(368, 200);
            this.btnClearCategory.Name = "btnClearCategory";
            this.btnClearCategory.Size = new System.Drawing.Size(70, 30);
            this.btnClearCategory.TabIndex = 25;
            this.btnClearCategory.Text = "CLEAR";
            this.btnClearCategory.UseVisualStyleBackColor = false;
            this.btnClearCategory.Click += new System.EventHandler(this.btnClearCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCategory.Location = new System.Drawing.Point(292, 200);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(70, 30);
            this.btnUpdateCategory.TabIndex = 26;
            this.btnUpdateCategory.Text = "UPDATE";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSaveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveCategory.ForeColor = System.Drawing.Color.White;
            this.btnSaveCategory.Location = new System.Drawing.Point(216, 200);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(70, 30);
            this.btnSaveCategory.TabIndex = 27;
            this.btnSaveCategory.Text = "SAVE";
            this.btnSaveCategory.UseVisualStyleBackColor = false;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Location = new System.Drawing.Point(127, 134);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(288, 23);
            this.txtNameCategory.TabIndex = 22;
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCatName.Location = new System.Drawing.Point(46, 136);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(47, 17);
            this.lblCatName.TabIndex = 21;
            this.lblCatName.Text = "Name:";
            // 
            // panelHeading
            // 
            this.panelHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelHeading.Controls.Add(this.LogoPBox);
            this.panelHeading.Controls.Add(this.lblCatModule);
            this.panelHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeading.Location = new System.Drawing.Point(0, 0);
            this.panelHeading.Name = "panelHeading";
            this.panelHeading.Size = new System.Drawing.Size(465, 79);
            this.panelHeading.TabIndex = 20;
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
            // lblCatModule
            // 
            this.lblCatModule.AutoSize = true;
            this.lblCatModule.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCatModule.ForeColor = System.Drawing.Color.White;
            this.lblCatModule.Location = new System.Drawing.Point(12, 20);
            this.lblCatModule.Name = "lblCatModule";
            this.lblCatModule.Size = new System.Drawing.Size(140, 20);
            this.lblCatModule.TabIndex = 0;
            this.lblCatModule.Text = "Category Module";
            // 
            // CategoryModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 275);
            this.Controls.Add(this.lblCatId);
            this.Controls.Add(this.btnClearCategory);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.txtNameCategory);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.panelHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryModuleForm";
            this.panelHeading.ResumeLayout(false);
            this.panelHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblCatId;
        public System.Windows.Forms.Button btnClearCategory;
        public System.Windows.Forms.Button btnUpdateCategory;
        public System.Windows.Forms.Button btnSaveCategory;
        public System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.Panel panelHeading;
        private System.Windows.Forms.PictureBox LogoPBox;
        private System.Windows.Forms.Label lblCatModule;
    }
}