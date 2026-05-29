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
        //private List<Estate__data> estates;
        //private List<Estate__data> Current_estate;
        List<Estate__data> estates = data__manager.estate__load();
        public Seller__list()
        {
            InitializeComponent();
            //Current_estate = data__manager.estate__load();

        }
        private void Seller__list_Load(object sender, EventArgs e)
        {
            //List<Estate__data> estates = data__manager.estate__load();
            Seller_flowLayoutPanel1.Controls.Clear();

            List<Estate__data> User__estates = estates.Where(item => item.Seller__Name == CurrentSession.CurrentUser.UserName && item.Seller__Surname == CurrentSession.CurrentUser.Surname).ToList();

            foreach (var item in User__estates)
            {
                Estate__card_seller card = new Estate__card_seller();
                card.Set_data_seller(item);
                Buyer__confirm_box confirm_box = new Buyer__confirm_box();
                confirm_box.Visible = false;
                this.Controls.Add(confirm_box);
                confirm_box.BringToFront();
                card.Button_delete = () => {
                    confirm_box.Visible = true;
                    confirm_box.BringToFront();


                    confirm_box.Yes += (s, e) => {
                        estates.Remove(item);
                        data__manager.estate__save(estates);
                        confirm_box.Visible = false;
                    };
                };
                {
                    estates.Remove(item);
                    data__manager.estate__save(estates);

                };
                card.Button_edit = () =>
                {
                    Seller__edit edit_form = new Seller__edit(item);
                    if (edit_form.ShowDialog() == DialogResult.OK)
                {
                    // После закрытия формы обновляем данные
                    data__manager.estate__save(estates);
                    card.Set_data_seller(item);
                }
                    //edit_form.ShowDialog();
                    //data__manager.estate__save(estates);
                    //card.Set_data_seller(item);
                };

                Seller_flowLayoutPanel1.Controls.Add(card);
            }
        }
    }
}
