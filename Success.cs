using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadiumProject
{
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private void Success_Load(object sender, EventArgs e)
        {
            timer.Interval = 300;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
