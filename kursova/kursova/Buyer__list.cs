using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kursova
{
    public partial class Buyer__list : Form
    {
        private List<Estate__data> estates;
        public Buyer__list()
        {
            InitializeComponent();
        }
        private void Buyer__list_Load(object sender, EventArgs e)
        {
            Buyer__list_distric.Items.Clear();

            Buyer__list_distric.Items.Add(" ");
            Buyer__list_distric.Items.Add("Індустріальний район");
            Buyer__list_distric.Items.Add("Київський район");
            Buyer__list_distric.Items.Add("Неми́шлянський район");
            Buyer__list_distric.Items.Add("Новобаварський район");
            Buyer__list_distric.Items.Add("Основ'янський район");
            Buyer__list_distric.Items.Add("Салтівський район");
            Buyer__list_distric.Items.Add("Слобідський район");
            Buyer__list_distric.Items.Add("Холодногірський район");
            Buyer__list_distric.Items.Add("Шевченківський район");

            Buyer__list_distric.SelectedIndex = 0;
            estates = data__manager.estate__load();
            flowLayoutPanel1.Controls.Clear();

            foreach (var item in estates)
            {
                Estate__card_buyer card = new Estate__card_buyer();

                card.Set_data_buyer(item);

                flowLayoutPanel1.Controls.Add(card);
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Buyer__set_filter()
        {
            var set_filter = new List<Estate__data>(estates);
            if (Buyer__list_sector.Checked)
            {
                set_filter = set_filter.Where(item => item.Type_estate == "Seller__sector").ToList();
            }
            if (Buyer__list_flat.Checked)
            {
                set_filter = set_filter.Where(item => item.Type_estate == "Seller__flat").ToList();
            }
            if (Buyer__list_house.Checked)
            {
                set_filter = set_filter.Where(item => item.Type_estate == "Seller__house").ToList();
            }
            if (Buyer__list_rent.Checked)
            {
                set_filter = set_filter.Where(item => item.Rent_sell == "Seller__rent").ToList();

            }
            if (Buyer__list_sell.Checked)
            {
                set_filter = set_filter.Where(item => item.Rent_sell == "Seller__sell").ToList();

            }

            if (Buyer__list_distric.Text != string.Empty)
            {
                set_filter = set_filter.Where(item => item.Distric == Buyer__list_distric.Text).ToList();
            }

            if (Buyer__list_price_from.Text != string.Empty)
            {
                int min_price;
                set_filter = set_filter.Where(item => int.TryParse(Buyer__list_price_from.Text, out min_price) && item.Price >= min_price).ToList();
            }
            if (Buyer__list_price_to.Text != string.Empty)
            {
                int max_price;
                set_filter = set_filter.Where(item => int.TryParse(Buyer__list_price_to.Text, out max_price) && item.Price <= max_price).ToList();
            }
            if (Buyer__list_area_from.Text != string.Empty)
            {
                int min_price;
                set_filter = set_filter.Where(item => int.TryParse(Buyer__list_area_from.Text, out min_price) && item.Area >= min_price).ToList();
            }
            if (Buyer__list_area_to.Text != string.Empty)
            {
                int max_price;
                set_filter = set_filter.Where(item => int.TryParse(Buyer__list_area_to.Text, out max_price) && item.Area <= max_price).ToList();
            }
            if (Buyer__list_rooms_from.Text != string.Empty)
            {
                int min_price;
                set_filter = set_filter.Where(item => int.TryParse(Buyer__list_rooms_from.Text, out min_price) && item.Rooms >= min_price).ToList();
            }
            if (Buyer__list_rooms_to.Text != string.Empty)
            {
                int max_price;
                set_filter = set_filter.Where(item => int.TryParse(Buyer__list_rooms_to.Text, out max_price) && item.Rooms <= max_price).ToList();
            }

            flowLayoutPanel1.Controls.Clear();

            foreach (var item in set_filter)
            {
                Estate__card_buyer card = new Estate__card_buyer();

                card.Set_data_buyer(item);

                flowLayoutPanel1.Controls.Add(card);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Buyer__set_filter();
            //if (Buyer__list_rent.Checked)
            //{
              //  var Buyer__filter_rent = estates.Where(item => item.Rent_sell == "Seller__rent").ToList();

            //}
            /*if (Buyer__list_rent.Checked)
            {
                var Buyer__filter_rent = estates.Where(item => item.Rent_sell == "Seller__rent").ToList();

                flowLayoutPanel1.Controls.Clear();

                foreach (var item in Buyer__filter_rent)
                {
                    Estate__card_buyer card = new Estate__card_buyer();

                    card.Set_data_buyer(item);

                    flowLayoutPanel1.Controls.Add(card);
                }
            }*/
        }
    }
}
