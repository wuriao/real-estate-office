using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kursova
{
    public partial class Estate__card_buyer : UserControl
    {
        private Estate__data curent_estate;
        public Estate__card_buyer()
        {
            InitializeComponent();

        }
        public void Set_data_buyer(Estate__data estate)
        {
            curent_estate = estate;
            //Estate__card_price.Text = $"{estate.Price} грн";
            if (estate.Type_estate == "Seller__sector")
            {
                Estate__card_buyer_type.Text = "Ділянка";
            }
            else if (estate.Type_estate == "Seller__flat")
            {
                Estate__card_buyer_type.Text = "Квартира";
            }
            else if (estate.Type_estate == "Seller__house")
            {
                Estate__card_buyer_type.Text = "Будинок";
            }

            Estate__card_buyer_area.Text = $"{estate.Area} м\u00B2";
            Estate__card_buyer_rooms.Text = $"{estate.Rooms} кімнат/а";

            if (estate.Rent_sell == "Seller__rent")
            {
                Estate__card_buyer_rent_sell.Text = "Оренда";
                Estate__card_buyer_price.Text = $"{estate.Price} грн/місяць";
            }
            else if (estate.Rent_sell == "Seller__sell")
            {
                Estate__card_buyer_rent_sell.Text = "Продаж";
                Estate__card_buyer_price.Text = $"{estate.Price} грн";
            }
        }
        public void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Estate__card_more_info_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (curent_estate != null)
            {
                Buyer__estate_more_info Buyer__estate_info = new Buyer__estate_more_info();
                Buyer__estate_info.Set_data_buyer__more_info(curent_estate);
                Buyer__estate_info.ShowDialog();
            }
            //Buyer__estate_more_info Buyer__estate_info = new Buyer__estate_more_info();
            //Buyer__estate_info.Set_data_buyer__more_info(estate); // Assuming 'estate' is accessible in this context
            //Buyer__estate_info.ShowDialog();
        }
    }
}
