﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            Form2 frm = new Form2();
            frm.myDelegateInstance = ComingData;
            frm.ShowDialog();
        }
        public void ComingData( int result )
        {
            lblresult.Text = result.ToString();
        }
    }
}
