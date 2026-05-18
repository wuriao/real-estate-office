namespace kursova
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            label1.Text = "Hello, World!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login__button_Click(object sender, EventArgs e)
        {
            if (Surname__box.Text != string.Empty && userName__box.Text != string.Empty && (Buyer.Checked || Seller.Checked))
            {
                if(Buyer.Checked && Seller.Checked)
                {
                    MessageBox.Show("Помилка: Виберіть лише одну ціль!");
                }
                if (Buyer.Checked)
                {
                    this.Hide();
                    Buyer buyerForm = new Buyer();
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
    }
}
