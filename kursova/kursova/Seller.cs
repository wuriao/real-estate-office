using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kursova
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }

        private void Seller__button_add_Click(object sender, EventArgs e)
        {
            Seller__add sellerAddForm = new Seller__add();
            sellerAddForm.ShowDialog();
        }

        private void Seller__button_list_Click_1(object sender, EventArgs e)
        {
            Seller__list sellerListForm = new Seller__list();
            sellerListForm.ShowDialog();
        }
    }
}
