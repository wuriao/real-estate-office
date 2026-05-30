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

            //var set_filter = new List<Estate__data>(estates);
            IEnumerable<Estate__data> set_filter = estates;
            //int count = set_filter.Count;
            if (Buyer__list_sector.Checked || Buyer__list_flat.Checked || Buyer__list_house.Checked)
            {
                set_filter = set_filter.Where(item =>
                    (Buyer__list_sector.Checked && item.Type_estate == "Seller__sector") ||
                    (Buyer__list_flat.Checked && item.Type_estate == "Seller__flat") ||
                    (Buyer__list_house.Checked && item.Type_estate == "Seller__house")
                );
            }
            /*if (Buyer__list_sector.Checked)
                set_filter = set_filter.Where(item => item.Type_estate == "Seller__sector");

            if (Buyer__list_flat.Checked)
                set_filter = set_filter.Where(item => item.Type_estate == "Seller__flat");
            
            if (Buyer__list_house.Checked)
                set_filter = set_filter.Where(item => item.Type_estate == "Seller__house");
            */
            if (Buyer__list_rent.Checked || Buyer__list_sell.Checked)
            {
                set_filter = set_filter.Where(item =>
                    (Buyer__list_rent.Checked && item.Rent_sell == "Seller__rent") ||
                    (Buyer__list_sell.Checked && item.Rent_sell == "Seller__sell")
                );
            }
            /*if (Buyer__list_rent.Checked)
                set_filter = set_filter.Where(item => item.Rent_sell == "Seller__rent");

            if (Buyer__list_sell.Checked)
                set_filter = set_filter.Where(item => item.Rent_sell == "Seller__sell");
            */

            if (Buyer__list_distric.Text != string.Empty && Buyer__list_distric.Text != " ")
            {
                set_filter = set_filter.Where(item => item.Distric == Buyer__list_distric.Text);
            }

            if (int.TryParse(Buyer__list_price_from.Text, out int min_price)) set_filter = set_filter.Where(item => item.Price >= min_price);
            if (int.TryParse(Buyer__list_price_to.Text, out int max_price)) set_filter = set_filter.Where(item => item.Price <= max_price);

            if (int.TryParse(Buyer__list_area_from.Text, out int min_area)) set_filter = set_filter.Where(item => item.Area >= min_area);
            if (int.TryParse(Buyer__list_area_to.Text, out int max_area)) set_filter = set_filter.Where(item => item.Area <= max_area);

            if (int.TryParse(Buyer__list_rooms_from.Text, out int min_rooms)) set_filter = set_filter.Where(item => item.Rooms >= min_rooms);
            if (int.TryParse(Buyer__list_rooms_to.Text, out int max_rooms)) set_filter = set_filter.Where(item => item.Rooms <= max_rooms   );
            /*if (Buyer__list_price_from.Text != string.Empty)
            }
                int min_price;
                set_filter = set_filter.Where(item => int.TryParse(Buyer__list_price_from.Text, out min_price) && item.Price >= min_price);
            }
            if (Buyer__list_price_to.Text != string.Empty)
            {
                int max_price;
                set_filter = set_filter.Where(item => int.TryParse(Buyer__list_price_to.Text, out max_price) && item.Price <= max_price);
            }
            if (Buyer__list_area_from.Text != string.Empty)
            {
                int min_price;
                set_filter = set_filter.Where(item => int.TryParse(Buyer__list_area_from.Text, out min_price) && item.Area >= min_price);
            }
            if (Buyer__list_area_to.Text != string.Empty)
            {
                int max_price;
                set_filter = set_filter.Where(item => int.TryParse(Buyer__list_area_to.Text, out max_price) && item.Area <= max_price);
            }
            if (Buyer__list_rooms_from.Text != string.Empty)
            {
                int min_price;
                set_filter = set_filter.Where(item => int.TryParse(Buyer__list_rooms_from.Text, out min_price) && item.Rooms >= min_price);
            }
            if (Buyer__list_rooms_to.Text != string.Empty)
            {
                int max_price;
                set_filter = set_filter.Where(item => int.TryParse(Buyer__list_rooms_to.Text, out max_price) && item.Rooms <= max_price);
            }*/

            var result = set_filter.ToList();
            if (result.Count == 0)
            {
                MessageBox.Show("Об’єктів не знайдено", "Пропонується скинути фільтр та ввести інші умови");
            }

            //if (result.Count == estates.Count)
            //    result = result.Where(item => item.Rooms <= 100000).ToList();


            flowLayoutPanel1.Controls.Clear();

            foreach (var item in result)
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
        private void Seller_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            bool isAllowed = char.IsControl(l) ||
                             "12304567890,".Contains(l);

            if (!isAllowed)
            {
                e.Handled = true;
            }
        }
    }
}
