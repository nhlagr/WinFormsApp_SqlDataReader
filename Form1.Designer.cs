namespace WinFormsApp_SqlDataReader
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetCategories = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtCategoriDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(392, 356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // btnGetCategories
            // 
            this.btnGetCategories.Location = new System.Drawing.Point(12, 12);
            this.btnGetCategories.Name = "btnGetCategories";
            this.btnGetCategories.Size = new System.Drawing.Size(147, 56);
            this.btnGetCategories.TabIndex = 1;
            this.btnGetCategories.Text = "Get Categories";
            this.btnGetCategories.UseVisualStyleBackColor = true;
            this.btnGetCategories.Click += new System.EventHandler(this.btnGetCategories_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCategoryId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.txtCategoriDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCategoryName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(431, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 356);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "InsertUpdateDelete";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(0, 86);
            this.txtCategoryId.MaxLength = 15;
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.ReadOnly = true;
            this.txtCategoryId.Size = new System.Drawing.Size(252, 23);
            this.txtCategoryId.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Category Id";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(177, 327);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(6, 327);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtCategoriDescription
            // 
            this.txtCategoriDescription.Location = new System.Drawing.Point(0, 223);
            this.txtCategoriDescription.MaxLength = 1000;
            this.txtCategoriDescription.Multiline = true;
            this.txtCategoriDescription.Name = "txtCategoriDescription";
            this.txtCategoriDescription.Size = new System.Drawing.Size(252, 84);
            this.txtCategoriDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categori Description";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(0, 151);
            this.txtCategoryName.MaxLength = 15;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(252, 23);
            this.txtCategoryName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categori Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 467);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGetCategories);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetCategories;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtCategoriDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label label3;
    }
}
