namespace StadiumProject
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_CustomerCRUD_Click(object sender, EventArgs e)
        {
            OpenInside(new CustomerCRUD());

        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            OpenInside(new ReservationPage());

        }

        private void btnStadium_Click(object sender, EventArgs e)
        {
            OpenInside(new StadiumCRUD());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenInside(new MonthylReportPage());
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            OpenInside(new RoomPage());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbQuit_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            
            pbMaximize.Visible = false;
            pbResize.Visible = true;
        }

        private void pbResize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbResize.Visible = false;
            pbMaximize.Visible = true;
        }

        private void OpenInside(object formobject)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form frm = formobject as Form;
            frm.TopLevel= false;
            frm.Dock= DockStyle.Fill;
            this.panelMain.Controls.Add(frm);
            this.panelMain.Tag = frm;
            frm.Show();


        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}