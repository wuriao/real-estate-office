using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kursova
{
    public partial class Estate__card_seller : UserControl
    {
        public Action Button_delete;
        public Action Button_edit;
        private Estate__data curent_estate;
        public Estate__card_seller()
        {
            InitializeComponent();
        }
        public void Set_data_seller(Estate__data estate)
        {
            curent_estate = estate;
            //Estate__card_price.Text = $"{estate.Price} грн";
            if (estate.Type_estate == "Seller__sector")
            {
                Estate__card_seller_type.Text = "Ділянка";
            }
            else if (estate.Type_estate == "Seller__flat")
            {
                Estate__card_seller_type.Text = "Квартира";
            }
            else if (estate.Type_estate == "Seller__house")
            {
                Estate__card_seller_type.Text = "Будинок";
            }

            Estate__card_seller_area.Text = $"{estate.Area} м\u00B2";
            Estate__card_seller_rooms.Text = $"{estate.Rooms} кімнат/а";

            if (estate.Rent_sell == "Seller__rent")
            {
                Estate__card_seller_rent_sell.Text = "Оренда";
                Estate__card_seller_price.Text = $"{estate.Price} грн/місяць";
            }
            else if (estate.Rent_sell == "Seller__sell")
            {
                Estate__card_seller_rent_sell.Text = "Продаж";
                Estate__card_seller_price.Text = $"{estate.Price} грн";
            }


        }
        private void Estate__card_seller_area_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button_delete?.Invoke();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (curent_estate != null)
            {
                Buyer__estate_more_info Buyer__estate_info = new Buyer__estate_more_info();
                Buyer__estate_info.Set_data_buyer__more_info(curent_estate);
                Buyer__estate_info.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button_edit?.Invoke();
        }
    }
}
