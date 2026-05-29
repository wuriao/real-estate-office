namespace kursova
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            label1.Text = "Реєстрація/Вхід";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login__button_Click(object sender, EventArgs e)
        {
            User__data item = new User__data();
            item.Surname = Surname__box.Text;
            item.UserName = userName__box.Text;
            item.Role = Buyer.Checked ? "Buyer" : "Seller";
            CurrentSession.CurrentUser = item;

            var list = data__manager.user__load();
            list.Add(item);
            data__manager.user__save(list);
            if (Surname__box.Text != string.Empty && userName__box.Text != string.Empty && (Buyer.Checked || Seller.Checked))
            {
                if (Buyer.Checked)
                {
                    this.Hide();
                    Buyer__list buyerForm = new Buyer__list();
                    buyerForm.ShowDialog();
                    this.Close();
                }
                if (Seller.Checked)
                {
                    this.Hide();
                    Seller sellerForm = new Seller();
                    sellerForm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, заповніть всі поля!");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Surname__box_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            bool isAllowed = char.IsControl(l) ||
                             (l >= 'А' && l <= 'Я') ||
                             (l >= 'а' && l <= 'я') ||
                             "іІїЇєЄґҐ '-".Contains(l);

            if (!isAllowed)
            {
                e.Handled = true;
            }
        }
        private void userName__box_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            bool isAllowed = char.IsControl(l) ||
                             (l >= 'А' && l <= 'Я') ||
                             (l >= 'а' && l <= 'я') ||
                             "іІїЇєЄґҐ '-".Contains(l);

            if (!isAllowed)
            {
                e.Handled = true;
            }
        }

        private void Seller_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
