using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace The_Guards
{
    public partial class frm_pauseMessage : Form
    {
        public frm_pauseMessage()
        {
            InitializeComponent();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
