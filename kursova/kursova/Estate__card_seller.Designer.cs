namespace kursova
{
    partial class Estate__card_seller
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Estate__card_seller_type = new Label();
            Estate__card_seller_rent_sell = new Label();
            Estate__card_seller_rooms = new Label();
            Estate__card_seller_area = new Label();
            Estate__card_seller_price = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Estate__card_seller_type
            // 
            Estate__card_seller_type.AutoSize = true;
            Estate__card_seller_type.Location = new Point(494, 21);
            Estate__card_seller_type.Name = "Estate__card_seller_type";
            Estate__card_seller_type.Size = new Size(100, 20);
            Estate__card_seller_type.TabIndex = 17;
            Estate__card_seller_type.Text = "что єто такое";
            // 
            // Estate__card_seller_rent_sell
            // 
            Estate__card_seller_rent_sell.AutoSize = true;
            Estate__card_seller_rent_sell.Location = new Point(494, 82);
            Estate__card_seller_rent_sell.Name = "Estate__card_seller_rent_sell";
            Estate__card_seller_rent_sell.Size = new Size(107, 20);
            Estate__card_seller_rent_sell.TabIndex = 15;
            Estate__card_seller_rent_sell.Text = "оренда да нет";
            // 
            // Estate__card_seller_rooms
            // 
            Estate__card_seller_rooms.AutoSize = true;
            Estate__card_seller_rooms.Location = new Point(246, 82);
            Estate__card_seller_rooms.Name = "Estate__card_seller_rooms";
            Estate__card_seller_rooms.Size = new Size(68, 20);
            Estate__card_seller_rooms.TabIndex = 14;
            Estate__card_seller_rooms.Text = "комнати";
            // 
            // Estate__card_seller_area
            // 
            Estate__card_seller_area.AutoSize = true;
            Estate__card_seller_area.Location = new Point(246, 148);
            Estate__card_seller_area.Name = "Estate__card_seller_area";
            Estate__card_seller_area.Size = new Size(59, 20);
            Estate__card_seller_area.TabIndex = 13;
            Estate__card_seller_area.Text = " площа";
            // 
            // Estate__card_seller_price
            // 
            Estate__card_seller_price.AutoSize = true;
            Estate__card_seller_price.Location = new Point(246, 21);
            Estate__card_seller_price.Name = "Estate__card_seller_price";
            Estate__card_seller_price.Size = new Size(51, 20);
            Estate__card_seller_price.TabIndex = 12;
            Estate__card_seller_price.Text = "прайс";
            // 
            // button1
            // 
            button1.Location = new Point(627, 21);
            button1.Name = "button1";
            button1.Size = new Size(111, 29);
            button1.TabIndex = 18;
            button1.Text = "Видалити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(627, 82);
            button2.Name = "button2";
            button2.Size = new Size(111, 29);
            button2.TabIndex = 19;
            button2.Text = "Редагувати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(627, 144);
            button3.Name = "button3";
            button3.Size = new Size(111, 29);
            button3.TabIndex = 20;
            button3.Text = "Детальніше";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Estate__card_seller_type);
            Controls.Add(Estate__card_seller_rent_sell);
            Controls.Add(Estate__card_seller_rooms);
            Controls.Add(Estate__card_seller_area);
            Controls.Add(Estate__card_seller_price);
            Name = "UserControl1";
            Size = new Size(798, 214);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label Estate__card_seller_price;
        public Label Estate__card_seller_type;
        public Label Estate__card_seller_rent_sell;
        public Label Estate__card_seller_rooms;
        public Label Estate__card_seller_area;
        public Button button1;
        public Button button2;
        public Button button3;
    }
}
