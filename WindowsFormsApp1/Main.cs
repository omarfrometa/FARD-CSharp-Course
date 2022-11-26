﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            lblMsg.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact contactForm = new Contact();
            contactForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
