﻿using Microsoft.EntityFrameworkCore;
using StadiumProject.Models;
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
    public partial class MonthylReportPage : Form
    {
        Stad db = new();
        public MonthylReportPage()
        {
            InitializeComponent();
        }

        private void MonthylReportPage_Load(object sender, EventArgs e)
        {


        }

    }

    
}
