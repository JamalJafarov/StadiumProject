namespace StadiumProject
{
    partial class ReservationPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationPage));
            this.btn_Add = new System.Windows.Forms.Button();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.cmb_stadium = new System.Windows.Forms.ComboBox();
            this.cmb_Fullname = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgReservation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmPlayersCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.ckRoomList = new System.Windows.Forms.CheckedListBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stadium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPlayersCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(1032, 384);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(170, 96);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = " MMMMdd, yyyy  |  hh:mm:ss";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(530, 310);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(395, 39);
            this.dtDate.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblPhonenumber);
            this.panel2.Controls.Add(this.lblSurname);
            this.panel2.Location = new System.Drawing.Point(23, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 311);
            this.panel2.TabIndex = 14;
            this.panel2.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(77, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 41);
            this.label10.TabIndex = 1;
            this.label10.Text = "Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(77, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(143, 41);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "FullName";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(77, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(220, 41);
            this.label15.TabIndex = 1;
            this.label15.Text = "Phone Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(77, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 41);
            this.label12.TabIndex = 1;
            this.label12.Text = "Surname";
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhonenumber.Location = new System.Drawing.Point(77, 246);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(143, 41);
            this.lblPhonenumber.TabIndex = 1;
            this.lblPhonenumber.Text = "FullName";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(77, 151);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(143, 41);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "FullName";
            // 
            // cmb_stadium
            // 
            this.cmb_stadium.FormattingEnabled = true;
            this.cmb_stadium.Location = new System.Drawing.Point(530, 68);
            this.cmb_stadium.Name = "cmb_stadium";
            this.cmb_stadium.Size = new System.Drawing.Size(255, 40);
            this.cmb_stadium.TabIndex = 12;
            this.cmb_stadium.SelectedIndexChanged += new System.EventHandler(this.cmb_stadium_SelectedIndexChanged);
            // 
            // cmb_Fullname
            // 
            this.cmb_Fullname.FormattingEnabled = true;
            this.cmb_Fullname.Location = new System.Drawing.Point(23, 53);
            this.cmb_Fullname.Name = "cmb_Fullname";
            this.cmb_Fullname.Size = new System.Drawing.Size(418, 40);
            this.cmb_Fullname.TabIndex = 13;
            this.cmb_Fullname.SelectedIndexChanged += new System.EventHandler(this.cmb_Fullname_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(530, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 32);
            this.label16.TabIndex = 8;
            this.label16.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(530, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 32);
            this.label9.TabIndex = 9;
            this.label9.Text = "Stadium";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 32);
            this.label8.TabIndex = 10;
            this.label8.Text = "FullName";
            // 
            // dtgReservation
            // 
            this.dtgReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgReservation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgReservation.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dtgReservation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgReservation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgReservation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Stadium,
            this.Room,
            this.Price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgReservation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgReservation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgReservation.EnableHeadersVisualStyles = false;
            this.dtgReservation.GridColor = System.Drawing.Color.SpringGreen;
            this.dtgReservation.Location = new System.Drawing.Point(0, 601);
            this.dtgReservation.Name = "dtgReservation";
            this.dtgReservation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReservation.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgReservation.RowHeadersWidth = 82;
            this.dtgReservation.RowTemplate.Height = 41;
            this.dtgReservation.Size = new System.Drawing.Size(1835, 478);
            this.dtgReservation.TabIndex = 6;
            this.dtgReservation.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgReservation_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1029, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Room";
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(1029, 53);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(325, 40);
            this.cmbRoom.TabIndex = 12;
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            this.cmbRoom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbRoom_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of players";
            // 
            // nmPlayersCount
            // 
            this.nmPlayersCount.Location = new System.Drawing.Point(530, 196);
            this.nmPlayersCount.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmPlayersCount.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmPlayersCount.Name = "nmPlayersCount";
            this.nmPlayersCount.Size = new System.Drawing.Size(133, 39);
            this.nmPlayersCount.TabIndex = 17;
            this.nmPlayersCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmPlayersCount.ValueChanged += new System.EventHandler(this.nmPlayersCount_ValueChanged);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(23, 112);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(418, 66);
            this.btnAddCustomer.TabIndex = 18;
            this.btnAddCustomer.Text = "Create Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // ckRoomList
            // 
            this.ckRoomList.FormattingEnabled = true;
            this.ckRoomList.Location = new System.Drawing.Point(1032, 113);
            this.ckRoomList.Name = "ckRoomList";
            this.ckRoomList.Size = new System.Drawing.Size(322, 148);
            this.ckRoomList.TabIndex = 19;
            this.ckRoomList.SelectedIndexChanged += new System.EventHandler(this.ckRoomList_SelectedIndexChanged);
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1775, 24);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(48, 44);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 20;
            this.pbExit.TabStop = false;
            this.pbExit.Visible = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrice.Location = new System.Drawing.Point(1032, 310);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(105, 45);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "label3";
            this.lblPrice.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(955, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 570);
            this.panel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(490, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 570);
            this.panel3.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1250, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 96);
            this.button1.TabIndex = 16;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1459, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 96);
            this.button2.TabIndex = 16;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 10;
            this.Name.Name = "Name";
            // 
            // Stadium
            // 
            this.Stadium.HeaderText = "Stadium";
            this.Stadium.MinimumWidth = 10;
            this.Stadium.Name = "Stadium";
            // 
            // Room
            // 
            this.Room.HeaderText = "Room";
            this.Room.MinimumWidth = 10;
            this.Room.Name = "Room";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 10;
            this.Price.Name = "Price";
            // 
            // ReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1835, 1079);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.ckRoomList);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.nmPlayersCount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.cmb_stadium);
            this.Controls.Add(this.cmb_Fullname);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgReservation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPlayersCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Add;
        private DateTimePicker dtDate;
        private Panel panel2;
        private Label label10;
        private Label lblName;
        private Label label15;
        private Label label12;
        private Label lblPhonenumber;
        private Label lblSurname;
        private ComboBox cmb_stadium;
        private ComboBox cmb_Fullname;
        private Label label16;
        private Label label9;
        private Label label8;
        private DataGridView dtgReservation;
        private Label label1;
        private ComboBox cmbRoom;
        private Label label2;
        private NumericUpDown nmPlayersCount;
        private Button btnAddCustomer;
        private CheckedListBox ckRoomList;
        private PictureBox pbExit;
        private Label lblPrice;
        private Panel panel1;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Stadium;
        private DataGridViewTextBoxColumn Room;
        private DataGridViewTextBoxColumn Price;
    }
}