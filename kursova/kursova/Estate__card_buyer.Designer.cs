namespace kursova
{
    partial class Estate__card_buyer
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
            Estate__card_buyer_type = new Label();
            Estate__card_buyer_rent_sell = new Label();
            Estate__card_buyer_rooms = new Label();
            Estate__card_buyer_area = new Label();
            Estate__card_buyer_price = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Estate__card_buyer_type
            // 
            Estate__card_buyer_type.AutoSize = true;
            Estate__card_buyer_type.Location = new Point(519, 25);
            Estate__card_buyer_type.Name = "Estate__card_buyer_type";
            Estate__card_buyer_type.Size = new Size(100, 20);
            Estate__card_buyer_type.TabIndex = 11;
            Estate__card_buyer_type.Text = "что єто такое";
            // 
            // Estate__card_buyer_rent_sell
            // 
            Estate__card_buyer_rent_sell.AutoSize = true;
            Estate__card_buyer_rent_sell.Location = new Point(519, 86);
            Estate__card_buyer_rent_sell.Name = "Estate__card_buyer_rent_sell";
            Estate__card_buyer_rent_sell.Size = new Size(107, 20);
            Estate__card_buyer_rent_sell.TabIndex = 9;
            Estate__card_buyer_rent_sell.Text = "оренда да нет";
            // 
            // Estate__card_buyer_rooms
            // 
            Estate__card_buyer_rooms.AutoSize = true;
            Estate__card_buyer_rooms.Location = new Point(271, 86);
            Estate__card_buyer_rooms.Name = "Estate__card_buyer_rooms";
            Estate__card_buyer_rooms.Size = new Size(68, 20);
            Estate__card_buyer_rooms.TabIndex = 8;
            Estate__card_buyer_rooms.Text = "комнати";
            // 
            // Estate__card_buyer_area
            // 
            Estate__card_buyer_area.AutoSize = true;
            Estate__card_buyer_area.Location = new Point(271, 152);
            Estate__card_buyer_area.Name = "Estate__card_buyer_area";
            Estate__card_buyer_area.Size = new Size(59, 20);
            Estate__card_buyer_area.TabIndex = 7;
            Estate__card_buyer_area.Text = " площа";
            // 
            // Estate__card_buyer_price
            // 
            Estate__card_buyer_price.AutoSize = true;
            Estate__card_buyer_price.Location = new Point(271, 25);
            Estate__card_buyer_price.Name = "Estate__card_buyer_price";
            Estate__card_buyer_price.Size = new Size(51, 20);
            Estate__card_buyer_price.TabIndex = 6;
            Estate__card_buyer_price.Text = "прайс";
            // 
            // button1
            // 
            button1.Location = new Point(519, 152);
            button1.Name = "button1";
            button1.Size = new Size(118, 29);
            button1.TabIndex = 12;
            button1.Text = "Детальніше";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Estate__card_buyer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button1);
            Controls.Add(Estate__card_buyer_type);
            Controls.Add(Estate__card_buyer_rent_sell);
            Controls.Add(Estate__card_buyer_rooms);
            Controls.Add(Estate__card_buyer_area);
            Controls.Add(Estate__card_buyer_price);
            Cursor = Cursors.IBeam;
            Name = "Estate__card_buyer";
            Size = new Size(700, 209);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Estate__card_buyer_type;
        private Label Estate__card_buyer_rent_sell;
        private Label Estate__card_buyer_rooms;
        private Label Estate__card_buyer_area;
        private Label Estate__card_buyer_price;
        private Button button1;
    }
}
