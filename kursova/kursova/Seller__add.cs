using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Windows.Forms;

namespace kursova
{
    public partial class Seller__add : Form
    {
        public Seller__add()
        {
            InitializeComponent();
        }

        private void Seller__button_add_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Seller__button_add_add_Click(object sender, EventArgs e)
        {
            string Selected_type = "";
            if (Seller__sector.Checked) Selected_type = "Seller__sector";
            else if (Seller__flat.Checked) Selected_type = "Seller__flat";
            else if (Seller__house.Checked) Selected_type = "Seller__house";

            //string Selected_rent_sell = "";
            //if (Seller__rent.Checked) Selected_rent_sell = Seller__rent.Text;
            //else if (Seller__sell.Checked) Selected_rent_sell = Seller__sell.Text;

            Estate__data characeristic = new Estate__data();
            characeristic.Seller__Name = CurrentSession.CurrentUser.UserName;
            characeristic.Seller__Surname = CurrentSession.CurrentUser.Surname;
            characeristic.Type_estate = Selected_type;
            /*if(Seller__sector.Checked)
            {
                characeristic.Type_estate = "Seller__sector";
            }
            else if(Seller__flat.Checked)
            {
                characeristic.Type_estate = "Seller__flat";
            }
            else if(Seller__house.Checked)
            {
                characeristic.Type_estate = "Seller__house";
            }*/
            characeristic.Rent_sell = Seller__rent.Checked ? "Seller__rent" : "Seller__sell";
            characeristic.Price = double.Parse(Seller_price.Text);
            characeristic.Area = double.Parse(Seller_area.Text);
            characeristic.Rooms = int.Parse(Seller_rooms.Text);

            var list = data__manager.estate__load();
            list.Add(characeristic);
            data__manager.estate__save(list);

            this.Close();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Seller_area_TextChanged(object sender, EventArgs e)
        {

        }

        private void Seller_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Seller_label_rooms_Click(object sender, EventArgs e)
        {

        }

        private void Seller__sell_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
