﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWorkoutApp
{
    public partial class WorkoutInfoForm : Form
    {
        public WorkoutInfoForm()
        {
            InitializeComponent();
            headerLabel.Select();
            this.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
