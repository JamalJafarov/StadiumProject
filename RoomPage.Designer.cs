namespace StadiumProject
{
    partial class RoomPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomPage));
            this.nmCapacity = new System.Windows.Forms.NumericUpDown();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgRoom = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomername = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // nmCapacity
            // 
            this.nmCapacity.Location = new System.Drawing.Point(32, 430);
            this.nmCapacity.Name = "nmCapacity";
            this.nmCapacity.Size = new System.Drawing.Size(141, 39);
            this.nmCapacity.TabIndex = 27;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(644, 188);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.Size = new System.Drawing.Size(443, 50);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(397, 639);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 125);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(209, 639);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 125);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 639);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 125);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgRoom
            // 
            this.dtgRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRoom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgRoom.ColumnHeadersHeight = 46;
            this.dtgRoom.Location = new System.Drawing.Point(644, 244);
            this.dtgRoom.Name = "dtgRoom";
            this.dtgRoom.RowHeadersWidth = 82;
            this.dtgRoom.RowTemplate.Height = 41;
            this.dtgRoom.Size = new System.Drawing.Size(602, 520);
            this.dtgRoom.TabIndex = 22;
            this.dtgRoom.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgRoom_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 51);
            this.label1.TabIndex = 19;
            this.label1.Text = "Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(143, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 51);
            this.label3.TabIndex = 20;
            this.label3.Text = "Room Details";
            // 
            // lblCustomername
            // 
            this.lblCustomername.AutoSize = true;
            this.lblCustomername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomername.Location = new System.Drawing.Point(22, 232);
            this.lblCustomername.Name = "lblCustomername";
            this.lblCustomername.Size = new System.Drawing.Size(231, 51);
            this.lblCustomername.TabIndex = 21;
            this.lblCustomername.Text = "Room Name";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRoomName.Location = new System.Drawing.Point(22, 286);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(322, 54);
            this.txtRoomName.TabIndex = 18;
            // 
            // RoomPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1717, 1101);
            this.Controls.Add(this.nmCapacity);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCustomername);
            this.Controls.Add(this.txtRoomName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomPage";
            this.Text = "RoomPage";
            this.Load += new System.EventHandler(this.RoomPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nmCapacity;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dtgRoom;
        private Label label1;
        private Label label3;
        private Label lblCustomername;
        private TextBox txtRoomName;
    }
}