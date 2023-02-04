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
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.cmb_stadium = new System.Windows.Forms.ComboBox();
            this.cmb_Fullname = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPlayersCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(980, 373);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(170, 96);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(573, 310);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(243, 39);
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
            this.panel2.Size = new System.Drawing.Size(369, 311);
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
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(573, 435);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(255, 40);
            this.cmbTime.TabIndex = 11;
            // 
            // cmb_stadium
            // 
            this.cmb_stadium.FormattingEnabled = true;
            this.cmb_stadium.Location = new System.Drawing.Point(573, 68);
            this.cmb_stadium.Name = "cmb_stadium";
            this.cmb_stadium.Size = new System.Drawing.Size(255, 40);
            this.cmb_stadium.TabIndex = 12;
            // 
            // cmb_Fullname
            // 
            this.cmb_Fullname.FormattingEnabled = true;
            this.cmb_Fullname.Location = new System.Drawing.Point(23, 53);
            this.cmb_Fullname.Name = "cmb_Fullname";
            this.cmb_Fullname.Size = new System.Drawing.Size(255, 40);
            this.cmb_Fullname.TabIndex = 13;
            this.cmb_Fullname.SelectedIndexChanged += new System.EventHandler(this.cmb_Fullname_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(573, 391);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 32);
            this.label17.TabIndex = 7;
            this.label17.Text = "Time";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(573, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 32);
            this.label16.TabIndex = 8;
            this.label16.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(573, 24);
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
            this.dtgReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReservation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgReservation.Location = new System.Drawing.Point(0, 601);
            this.dtgReservation.Name = "dtgReservation";
            this.dtgReservation.RowHeadersWidth = 82;
            this.dtgReservation.RowTemplate.Height = 41;
            this.dtgReservation.Size = new System.Drawing.Size(1835, 478);
            this.dtgReservation.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(980, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Room";
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(980, 68);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(325, 40);
            this.cmbRoom.TabIndex = 12;
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            this.cmbRoom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbRoom_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of players";
            // 
            // nmPlayersCount
            // 
            this.nmPlayersCount.Location = new System.Drawing.Point(573, 196);
            this.nmPlayersCount.Name = "nmPlayersCount";
            this.nmPlayersCount.Size = new System.Drawing.Size(133, 39);
            this.nmPlayersCount.TabIndex = 17;
            this.nmPlayersCount.ValueChanged += new System.EventHandler(this.nmPlayersCount_ValueChanged);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(23, 112);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(254, 66);
            this.btnAddCustomer.TabIndex = 18;
            this.btnAddCustomer.Text = "Create Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // ckRoomList
            // 
            this.ckRoomList.FormattingEnabled = true;
            this.ckRoomList.Items.AddRange(new object[] {
            "cknebilimne"});
            this.ckRoomList.Location = new System.Drawing.Point(983, 128);
            this.ckRoomList.Name = "ckRoomList";
            this.ckRoomList.Size = new System.Drawing.Size(322, 148);
            this.ckRoomList.TabIndex = 19;
            this.ckRoomList.Visible = false;
            this.ckRoomList.SelectedIndexChanged += new System.EventHandler(this.ckRoomList_SelectedIndexChanged);
            // 
            // ReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1835, 1079);
            this.Controls.Add(this.ckRoomList);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.nmPlayersCount);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.cmb_stadium);
            this.Controls.Add(this.cmb_Fullname);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgReservation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPlayersCount)).EndInit();
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
        private ComboBox cmbTime;
        private ComboBox cmb_stadium;
        private ComboBox cmb_Fullname;
        private Label label17;
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
    }
}