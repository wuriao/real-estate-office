using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kursova
{
    public partial class Seller__list : Form
    {
        public Seller__list()
        {
            InitializeComponent();
        }
        private void Seller__list_Load(object sender, EventArgs e)
        {
            List<Estate__data> estates = data__manager.estate__load();
            Seller_flowLayoutPanel1.Controls.Clear();

            List<Estate__data> User__estates = estates.Where(item => item.Seller__Name == CurrentSession.CurrentUser.UserName && item.Seller__Surname == CurrentSession.CurrentUser.Surname).ToList();

            foreach (var item in User__estates)
            {
                UserControl1 card = new UserControl1();

                card.Set_data_seller(item);

                Seller_flowLayoutPanel1.Controls.Add(card);
            }
        }
    }
}
