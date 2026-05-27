namespace kursova
{
    partial class Seller__add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Seller_label_rooms = new Label();
            Seller_label_price = new Label();
            Seller_label_object = new Label();
            Seller_label_rent_sell = new Label();
            Seller__sector = new CheckBox();
            Seller__flat = new CheckBox();
            Seller__house = new CheckBox();
            Seller_label_area = new Label();
            Seller__rent = new CheckBox();
            Seller__sell = new CheckBox();
            Seller_price = new TextBox();
            Seller_area = new TextBox();
            Seller_rooms = new TextBox();
            Seller__button_add_object = new Button();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // Seller_label_rooms
            // 
            Seller_label_rooms.AutoSize = true;
            Seller_label_rooms.Location = new Point(34, 262);
            Seller_label_rooms.Name = "Seller_label_rooms";
            Seller_label_rooms.Size = new Size(119, 20);
            Seller_label_rooms.TabIndex = 0;
            Seller_label_rooms.Text = "Кількість кімнат";
            Seller_label_rooms.Click += Seller_label_rooms_Click;
            // 
            // Seller_label_price
            // 
            Seller_label_price.AutoSize = true;
            Seller_label_price.ImeMode = ImeMode.NoControl;
            Seller_label_price.Location = new Point(34, 162);
            Seller_label_price.Name = "Seller_label_price";
            Seller_label_price.Size = new Size(41, 20);
            Seller_label_price.TabIndex = 1;
            Seller_label_price.Text = "Ціна";
            // 
            // Seller_label_object
            // 
            Seller_label_object.AutoSize = true;
            Seller_label_object.ImeMode = ImeMode.NoControl;
            Seller_label_object.Location = new Point(34, 62);
            Seller_label_object.Name = "Seller_label_object";
            Seller_label_object.Size = new Size(88, 20);
            Seller_label_object.TabIndex = 2;
            Seller_label_object.Text = "Вид об'єкта";
            // 
            // Seller_label_rent_sell
            // 
            Seller_label_rent_sell.AutoSize = true;
            Seller_label_rent_sell.ImeMode = ImeMode.NoControl;
            Seller_label_rent_sell.Location = new Point(34, 111);
            Seller_label_rent_sell.Name = "Seller_label_rent_sell";
            Seller_label_rent_sell.Size = new Size(117, 20);
            Seller_label_rent_sell.TabIndex = 3;
            Seller_label_rent_sell.Text = "Вид пропозиції";
            // 
            // Seller__sector
            // 
            Seller__sector.AutoSize = true;
            Seller__sector.Location = new Point(142, 62);
            Seller__sector.Name = "Seller__sector";
            Seller__sector.Size = new Size(85, 24);
            Seller__sector.TabIndex = 4;
            Seller__sector.Text = "Ділянка";
            Seller__sector.UseVisualStyleBackColor = true;
            // 
            // Seller__flat
            // 
            Seller__flat.AutoSize = true;
            Seller__flat.ImeMode = ImeMode.NoControl;
            Seller__flat.Location = new Point(258, 62);
            Seller__flat.Name = "Seller__flat";
            Seller__flat.Size = new Size(97, 24);
            Seller__flat.TabIndex = 5;
            Seller__flat.Text = "Квартира";
            Seller__flat.UseVisualStyleBackColor = true;
            // 
            // Seller__house
            // 
            Seller__house.AutoSize = true;
            Seller__house.ImeMode = ImeMode.NoControl;
            Seller__house.Location = new Point(393, 62);
            Seller__house.Name = "Seller__house";
            Seller__house.Size = new Size(89, 24);
            Seller__house.TabIndex = 6;
            Seller__house.Text = "Будинок";
            Seller__house.UseVisualStyleBackColor = true;
            // 
            // Seller_label_area
            // 
            Seller_label_area.AutoSize = true;
            Seller_label_area.ImeMode = ImeMode.NoControl;
            Seller_label_area.Location = new Point(34, 217);
            Seller_label_area.Name = "Seller_label_area";
            Seller_label_area.Size = new Size(57, 20);
            Seller_label_area.TabIndex = 7;
            Seller_label_area.Text = "Площа";
            // 
            // Seller__rent
            // 
            Seller__rent.AutoSize = true;
            Seller__rent.ImeMode = ImeMode.NoControl;
            Seller__rent.Location = new Point(201, 110);
            Seller__rent.Name = "Seller__rent";
            Seller__rent.Size = new Size(84, 24);
            Seller__rent.TabIndex = 8;
            Seller__rent.Text = "Оренда";
            Seller__rent.UseVisualStyleBackColor = true;
            // 
            // Seller__sell
            // 
            Seller__sell.AutoSize = true;
            Seller__sell.ImeMode = ImeMode.NoControl;
            Seller__sell.Location = new Point(343, 111);
            Seller__sell.Name = "Seller__sell";
            Seller__sell.Size = new Size(84, 24);
            Seller__sell.TabIndex = 9;
            Seller__sell.Text = "Купівля";
            Seller__sell.UseVisualStyleBackColor = true;
            Seller__sell.CheckedChanged += Seller__sell_CheckedChanged;
            // 
            // Seller_price
            // 
            Seller_price.Location = new Point(133, 162);
            Seller_price.Name = "Seller_price";
            Seller_price.Size = new Size(125, 27);
            Seller_price.TabIndex = 10;
            Seller_price.TextChanged += Seller_price_TextChanged;
            // 
            // Seller_area
            // 
            Seller_area.Location = new Point(133, 214);
            Seller_area.Name = "Seller_area";
            Seller_area.Size = new Size(125, 27);
            Seller_area.TabIndex = 11;
            Seller_area.TextChanged += Seller_area_TextChanged;
            // 
            // Seller_rooms
            // 
            Seller_rooms.Location = new Point(201, 262);
            Seller_rooms.Name = "Seller_rooms";
            Seller_rooms.Size = new Size(125, 27);
            Seller_rooms.TabIndex = 12;
            // 
            // Seller__button_add_object
            // 
            Seller__button_add_object.Location = new Point(367, 345);
            Seller__button_add_object.Name = "Seller__button_add_object";
            Seller__button_add_object.Size = new Size(94, 29);
            Seller__button_add_object.TabIndex = 13;
            Seller__button_add_object.Text = "Додати";
            Seller__button_add_object.UseVisualStyleBackColor = true;
            Seller__button_add_object.Click += Seller__button_add_add_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(516, 95);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Seller__add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton1);
            Controls.Add(Seller__button_add_object);
            Controls.Add(Seller_rooms);
            Controls.Add(Seller_area);
            Controls.Add(Seller_price);
            Controls.Add(Seller__sell);
            Controls.Add(Seller__rent);
            Controls.Add(Seller_label_area);
            Controls.Add(Seller__house);
            Controls.Add(Seller__flat);
            Controls.Add(Seller__sector);
            Controls.Add(Seller_label_rent_sell);
            Controls.Add(Seller_label_object);
            Controls.Add(Seller_label_price);
            Controls.Add(Seller_label_rooms);
            Name = "Seller__add";
            Text = "Додати об'єкт нерухомості";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Seller_label_rooms;
        private Label Seller_label_price;
        private Label Seller_label_object;
        private Label Seller_label_rent_sell;
        private CheckBox Seller__sector;
        private CheckBox Seller__flat;
        private CheckBox Seller__house;
        private Label Seller_label_area;
        private CheckBox Seller__rent;
        private CheckBox Seller__sell;
        private TextBox Seller_price;
        private TextBox Seller_area;
        private TextBox Seller_rooms;
        private Button Seller__button_add_object;
        private RadioButton radioButton1;
    }
}