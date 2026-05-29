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
            Seller_label_area = new Label();
            Seller_price = new TextBox();
            Seller_area = new TextBox();
            Seller_rooms = new TextBox();
            Seller__button_add_object = new Button();
            Seller_label_distric = new Label();
            Seller__distric = new ComboBox();
            Seller_label_address = new Label();
            Seller__address = new TextBox();
            Seller__sector = new RadioButton();
            Seller__flat = new RadioButton();
            Seller__house = new RadioButton();
            Seller__rent = new RadioButton();
            Seller__sell = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Seller_label_rooms
            // 
            Seller_label_rooms.AutoSize = true;
            Seller_label_rooms.Location = new Point(34, 291);
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
            Seller_label_price.Location = new Point(34, 191);
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
            // Seller_label_area
            // 
            Seller_label_area.AutoSize = true;
            Seller_label_area.ImeMode = ImeMode.NoControl;
            Seller_label_area.Location = new Point(34, 246);
            Seller_label_area.Name = "Seller_label_area";
            Seller_label_area.Size = new Size(57, 20);
            Seller_label_area.TabIndex = 7;
            Seller_label_area.Text = "Площа";
            // 
            // Seller_price
            // 
            Seller_price.Location = new Point(133, 191);
            Seller_price.Name = "Seller_price";
            Seller_price.Size = new Size(125, 27);
            Seller_price.TabIndex = 10;
            Seller_price.TextChanged += Seller_price_TextChanged;
            Seller_price.KeyPress += Seller_price_KeyPress;
            // 
            // Seller_area
            // 
            Seller_area.Location = new Point(133, 243);
            Seller_area.Name = "Seller_area";
            Seller_area.Size = new Size(125, 27);
            Seller_area.TabIndex = 11;
            Seller_area.TextChanged += Seller_area_TextChanged;
            Seller_area.KeyPress += Seller_price_KeyPress;
            // 
            // Seller_rooms
            // 
            Seller_rooms.Location = new Point(201, 291);
            Seller_rooms.Name = "Seller_rooms";
            Seller_rooms.Size = new Size(125, 27);
            Seller_rooms.TabIndex = 12;
            Seller_rooms.KeyPress += Seller_price_KeyPress;
            // 
            // Seller__button_add_object
            // 
            Seller__button_add_object.Location = new Point(367, 402);
            Seller__button_add_object.Name = "Seller__button_add_object";
            Seller__button_add_object.Size = new Size(94, 29);
            Seller__button_add_object.TabIndex = 13;
            Seller__button_add_object.Text = "Додати";
            Seller__button_add_object.UseVisualStyleBackColor = true;
            Seller__button_add_object.Click += Seller__button_add_add_Click;
            // 
            // Seller_label_distric
            // 
            Seller_label_distric.AutoSize = true;
            Seller_label_distric.ImeMode = ImeMode.NoControl;
            Seller_label_distric.Location = new Point(34, 150);
            Seller_label_distric.Name = "Seller_label_distric";
            Seller_label_distric.Size = new Size(52, 20);
            Seller_label_distric.TabIndex = 15;
            Seller_label_distric.Text = "Район";
            // 
            // Seller__distric
            // 
            Seller__distric.DropDownStyle = ComboBoxStyle.DropDownList;
            Seller__distric.FormattingEnabled = true;
            Seller__distric.Location = new Point(107, 147);
            Seller__distric.Name = "Seller__distric";
            Seller__distric.Size = new Size(178, 28);
            Seller__distric.TabIndex = 16;
            Seller__distric.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Seller_label_address
            // 
            Seller_label_address.AutoSize = true;
            Seller_label_address.ImeMode = ImeMode.NoControl;
            Seller_label_address.Location = new Point(393, 150);
            Seller_label_address.Name = "Seller_label_address";
            Seller_label_address.Size = new Size(59, 20);
            Seller_label_address.TabIndex = 17;
            Seller_label_address.Text = "Адреса";
            // 
            // Seller__address
            // 
            Seller__address.Location = new Point(458, 148);
            Seller__address.Name = "Seller__address";
            Seller__address.Size = new Size(191, 27);
            Seller__address.TabIndex = 18;
            Seller__address.KeyPress += Seller__address_KeyPress;
            // 
            // Seller__sector
            // 
            Seller__sector.AutoSize = true;
            Seller__sector.Location = new Point(6, 16);
            Seller__sector.Name = "Seller__sector";
            Seller__sector.Size = new Size(84, 24);
            Seller__sector.TabIndex = 19;
            Seller__sector.TabStop = true;
            Seller__sector.Text = "Ділянка";
            Seller__sector.UseVisualStyleBackColor = true;
            // 
            // Seller__flat
            // 
            Seller__flat.AutoSize = true;
            Seller__flat.Location = new Point(128, 16);
            Seller__flat.Name = "Seller__flat";
            Seller__flat.Size = new Size(96, 24);
            Seller__flat.TabIndex = 20;
            Seller__flat.TabStop = true;
            Seller__flat.Text = "Квартира";
            Seller__flat.UseVisualStyleBackColor = true;
            Seller__flat.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // Seller__house
            // 
            Seller__house.AutoSize = true;
            Seller__house.Location = new Point(250, 16);
            Seller__house.Name = "Seller__house";
            Seller__house.Size = new Size(88, 24);
            Seller__house.TabIndex = 21;
            Seller__house.TabStop = true;
            Seller__house.Text = "Будинок";
            Seller__house.UseVisualStyleBackColor = true;
            Seller__house.CheckedChanged += Seller__house_CheckedChanged;
            // 
            // Seller__rent
            // 
            Seller__rent.AutoSize = true;
            Seller__rent.Location = new Point(17, 18);
            Seller__rent.Name = "Seller__rent";
            Seller__rent.Size = new Size(83, 24);
            Seller__rent.TabIndex = 22;
            Seller__rent.TabStop = true;
            Seller__rent.Text = "Оренда";
            Seller__rent.UseVisualStyleBackColor = true;
            Seller__rent.CheckedChanged += Seller__rent_CheckedChanged;
            // 
            // Seller__sell
            // 
            Seller__sell.AutoSize = true;
            Seller__sell.Location = new Point(170, 16);
            Seller__sell.Name = "Seller__sell";
            Seller__sell.Size = new Size(86, 24);
            Seller__sell.TabIndex = 23;
            Seller__sell.TabStop = true;
            Seller__sell.Text = "Продаж";
            Seller__sell.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Seller__sector);
            groupBox1.Controls.Add(Seller__flat);
            groupBox1.Controls.Add(Seller__house);
            groupBox1.Location = new Point(133, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 49);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Seller__sell);
            groupBox2.Controls.Add(Seller__rent);
            groupBox2.Location = new Point(171, 91);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 51);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = " ";
            // 
            // Seller__add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Seller__address);
            Controls.Add(Seller_label_address);
            Controls.Add(Seller__distric);
            Controls.Add(Seller_label_distric);
            Controls.Add(Seller__button_add_object);
            Controls.Add(Seller_rooms);
            Controls.Add(Seller_area);
            Controls.Add(Seller_price);
            Controls.Add(Seller_label_area);
            Controls.Add(Seller_label_rent_sell);
            Controls.Add(Seller_label_object);
            Controls.Add(Seller_label_price);
            Controls.Add(Seller_label_rooms);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Seller__add";
            Text = "Додати об'єкт нерухомості";
            Load += Seller__add_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Seller_label_rooms;
        private Label Seller_label_price;
        private Label Seller_label_object;
        private Label Seller_label_rent_sell;
        //private CheckBox Seller__flat;
       //private CheckBox Seller__house;
        private Label Seller_label_area;
        private TextBox Seller_price;
        private TextBox Seller_area;
        private TextBox Seller_rooms;
        private Button Seller__button_add_object;
        private Label Seller_label_distric;
        private ComboBox Seller__distric;
        private Label Seller_label_address;
        private TextBox Seller__address;
        private RadioButton Seller__sector;
        private RadioButton Seller__flat;
        private RadioButton Seller__house;
        private RadioButton Seller__rent;
        private RadioButton Seller__sell;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}