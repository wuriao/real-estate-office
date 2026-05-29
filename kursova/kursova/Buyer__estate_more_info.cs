using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kursova
{
    public partial class Buyer__estate_more_info : Form
    {
        public Buyer__estate_more_info()
        {
            InitializeComponent();

        }
        public void Set_data_buyer__more_info(Estate__data estate)
        {
            if (estate.Type_estate == "Seller__sector")
            {
                label1.Text = "Ділянка";
            }
            else if (estate.Type_estate == "Seller__flat")
            {
                label1.Text = "Квартира";
            }
            else if (estate.Type_estate == "Seller__house")
            {
                label1.Text = "Будинок";
            }

            if (estate.Distric != null)
            {
                label3.Text = estate.Distric;

            }
            if (estate.Address != null)
            {
                label4.Text = estate.Address;
            }

            label6.Text = $"{estate.Area} м\u00B2";
            label7.Text = $"{estate.Rooms} кімнат/а";

            if (estate.Rent_sell == "Seller__rent")
            {
                label2.Text = "Оренда";
                label5.Text = $"{estate.Price} грн/місяць";
            }
            else if (estate.Rent_sell == "Seller__sell")
            {
                label2.Text = "Продаж";
                label5.Text = $"{estate.Price} грн";
            }


        }
        private void Buyer__estate_more_info_Load_1(object sender, EventArgs e)
        {

        }
    }
}
