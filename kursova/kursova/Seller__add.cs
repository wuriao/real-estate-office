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
            characeristic.Distric = Seller__distric.SelectedItem.ToString();
            characeristic.Address = Seller__address.Text;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Seller__add_Load(object sender, EventArgs e)
        {
            Seller__distric.Items.Clear();

            Seller__distric.Items.Add(" ");
            Seller__distric.Items.Add("Індустріальний район");
            Seller__distric.Items.Add("Київський район");
            Seller__distric.Items.Add("Неми́шлянський район");
            Seller__distric.Items.Add("Новобаварський район");
            Seller__distric.Items.Add("Основ'янський район");
            Seller__distric.Items.Add("Салтівський район");
            Seller__distric.Items.Add("Слобідський район");
            Seller__distric.Items.Add("Холодногірський район");
            Seller__distric.Items.Add("Шевченківський район");

            Seller__distric.SelectedIndex = 0;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Seller__house_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Seller__rent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Seller__address_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            bool isAllowed = char.IsControl(l) ||
                             (l >= 'А' && l <= 'Я') ||
                             (l >= 'а' && l <= 'я') ||
                             "іІїЇєЄґҐ .,'-1234567890".Contains(l);

            if (!isAllowed)
            {
                e.Handled = true;
            }
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
        /*private void Seller_area_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            bool isAllowed = char.IsControl(l) ||
                             "12304567890,".Contains(l);

            if (!isAllowed)
            {
                e.Handled = true;
            }
        }*/
    }
}
