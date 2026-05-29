using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kursova
{
    public partial class Buyer__confirm_box : UserControl
    {
        public event EventHandler Yes;
        public event EventHandler No;
        public Buyer__confirm_box()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yes?.Invoke(this, EventArgs.Empty);
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            No?.Invoke(this, EventArgs.Empty);
            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
