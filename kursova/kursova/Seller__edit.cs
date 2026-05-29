using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kursova
{
    public partial class Seller__edit : Form
    {
        private Estate__data estate_edit;
        public Seller__edit(Estate__data estate = null)
        {
            InitializeComponent();
            estate_edit = estate;
            Seller__edit_distric.Items.Clear();

            Seller__edit_distric.Items.Add(" ");
            Seller__edit_distric.Items.Add("Індустріальний район");
            Seller__edit_distric.Items.Add("Київський район");
            Seller__edit_distric.Items.Add("Неми́шлянський район");
            Seller__edit_distric.Items.Add("Новобаварський район");
            Seller__edit_distric.Items.Add("Основ'янський район");
            Seller__edit_distric.Items.Add("Салтівський район");
            Seller__edit_distric.Items.Add("Слобідський район");
            Seller__edit_distric.Items.Add("Холодногірський район");
            Seller__edit_distric.Items.Add("Шевченківський район");

            Seller__edit_distric.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            if (estate_edit != null)
            {
                Seller__sector.Checked = estate_edit.Type_estate == "Seller__sector";
                Seller__flat.Checked = estate_edit.Type_estate == "Seller__flat";
                Seller__house.Checked = estate_edit.Type_estate == "Seller__house";
                Seller__rent.Checked = estate_edit.Rent_sell == "Seller__rent";
                Seller__sell.Checked = estate_edit.Rent_sell == "Seller__sell";
                Seller__edit_distric.SelectedItem = estate_edit.Distric;
                Seller__address.Text = estate_edit.Address;
                Seller_price.Text = estate_edit.Price.ToString();
                Seller_area.Text = estate_edit.Area.ToString();
                Seller_rooms.Text = estate_edit.Rooms.ToString();
            }
        }

        private void Seller__button_edit_Click(object sender, EventArgs e)
        {
            if (estate_edit != null)
            {
                estate_edit.Address = Seller__address.Text;
                estate_edit.Price = double.Parse(Seller_price.Text);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
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
    }
}
