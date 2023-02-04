namespace StadiumProject
{
    partial class StadiumCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StadiumCRUD));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgStadium = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomername = new System.Windows.Forms.Label();
            this.txtStadiumName = new System.Windows.Forms.TextBox();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStadium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(668, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Search";
            this.textBox1.Size = new System.Drawing.Size(443, 50);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(431, 584);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 125);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(243, 584);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 125);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(56, 584);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 125);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // dtgStadium
            // 
            this.dtgStadium.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgStadium.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgStadium.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgStadium.ColumnHeadersHeight = 46;
            this.dtgStadium.Location = new System.Drawing.Point(668, 189);
            this.dtgStadium.Name = "dtgStadium";
            this.dtgStadium.RowHeadersWidth = 82;
            this.dtgStadium.RowTemplate.Height = 41;
            this.dtgStadium.Size = new System.Drawing.Size(1117, 628);
            this.dtgStadium.TabIndex = 12;
            this.dtgStadium.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgStadium_RowHeaderMouseClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 51);
            this.label1.TabIndex = 9;
            this.label1.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(177, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 51);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stadium Details";
            // 
            // lblCustomername
            // 
            this.lblCustomername.AutoSize = true;
            this.lblCustomername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomername.Location = new System.Drawing.Point(56, 177);
            this.lblCustomername.Name = "lblCustomername";
            this.lblCustomername.Size = new System.Drawing.Size(269, 51);
            this.lblCustomername.TabIndex = 11;
            this.lblCustomername.Text = "Stadium Name";
            // 
            // txtStadiumName
            // 
            this.txtStadiumName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStadiumName.Location = new System.Drawing.Point(56, 231);
            this.txtStadiumName.Name = "txtStadiumName";
            this.txtStadiumName.Size = new System.Drawing.Size(322, 54);
            this.txtStadiumName.TabIndex = 7;
            this.txtStadiumName.TextChanged += new System.EventHandler(this.txtStadiumName_TextChanged);
            // 
            // nmPrice
            // 
            this.nmPrice.Location = new System.Drawing.Point(66, 375);
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.Size = new System.Drawing.Size(141, 39);
            this.nmPrice.TabIndex = 17;
            // 
            // StadiumCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1790, 1088);
            this.Controls.Add(this.nmPrice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgStadium);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCustomername);
            this.Controls.Add(this.txtStadiumName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StadiumCRUD";
            this.Text = "StadiumCRUD";
            this.Load += new System.EventHandler(this.StadiumCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStadium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dtgStadium;
        private Label label1;
        private Label label3;
        private Label lblCustomername;
        private TextBox txtStadiumName;
        private NumericUpDown nmPrice;
    }
}