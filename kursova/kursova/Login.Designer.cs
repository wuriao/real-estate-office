namespace kursova
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Surname = new Label();
            userName = new Label();
            label4 = new Label();
            Surname__box = new TextBox();
            userName__box = new TextBox();
            Login__button = new Button();
            Buyer = new RadioButton();
            Seller = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(386, 69);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Реєстрація/Вхід";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Surname
            // 
            Surname.AutoSize = true;
            Surname.Location = new Point(278, 126);
            Surname.Name = "Surname";
            Surname.Size = new Size(77, 20);
            Surname.TabIndex = 1;
            Surname.Text = "Призвіще";
            Surname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(278, 185);
            userName.Name = "userName";
            userName.Size = new Size(35, 20);
            userName.TabIndex = 2;
            userName.Text = "Ім'я";
            userName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 243);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 3;
            label4.Text = "Ціль";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Surname__box
            // 
            Surname__box.Location = new Point(386, 126);
            Surname__box.Name = "Surname__box";
            Surname__box.Size = new Size(165, 27);
            Surname__box.TabIndex = 4;
            Surname__box.KeyPress += Surname__box_KeyPress;
            // 
            // userName__box
            // 
            userName__box.Location = new Point(386, 185);
            userName__box.Name = "userName__box";
            userName__box.Size = new Size(165, 27);
            userName__box.TabIndex = 5;
            // 
            // Login__button
            // 
            Login__button.Location = new Point(386, 327);
            Login__button.Name = "Login__button";
            Login__button.Size = new Size(165, 29);
            Login__button.TabIndex = 8;
            Login__button.Text = "Реєстрація/Вхід";
            Login__button.UseVisualStyleBackColor = true;
            Login__button.Click += Login__button_Click;
            // 
            // Buyer
            // 
            Buyer.AutoSize = true;
            Buyer.Location = new Point(386, 243);
            Buyer.Name = "Buyer";
            Buyer.Size = new Size(98, 24);
            Buyer.TabIndex = 9;
            Buyer.TabStop = true;
            Buyer.Text = "Покупець";
            Buyer.UseVisualStyleBackColor = true;
            // 
            // Seller
            // 
            Seller.AutoSize = true;
            Seller.Location = new Point(386, 273);
            Seller.Name = "Seller";
            Seller.Size = new Size(108, 24);
            Seller.TabIndex = 10;
            Seller.TabStop = true;
            Seller.Text = "Продавець";
            Seller.UseVisualStyleBackColor = true;
            Seller.CheckedChanged += Seller_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 656);
            Controls.Add(Seller);
            Controls.Add(Buyer);
            Controls.Add(Login__button);
            Controls.Add(userName__box);
            Controls.Add(Surname__box);
            Controls.Add(label4);
            Controls.Add(userName);
            Controls.Add(Surname);
            Controls.Add(label1);
            Name = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Surname;
        private Label userName;
        private Label label4;
        private TextBox Surname__box;
        private TextBox userName__box;
        //private CheckBox Buyer;
        //private CheckBox Seller;
        private Button Login__button;
        private RadioButton Buyer;
        private RadioButton Seller;
    }
}