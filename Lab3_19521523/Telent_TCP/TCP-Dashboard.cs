﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP
{
    public partial class TCP_Dashboard : Form
    {
        public TCP_Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Telent_TCP.Server1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Client().Show();
        }
    }
}
