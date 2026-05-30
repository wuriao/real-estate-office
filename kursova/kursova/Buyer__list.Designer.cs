namespace kursova
{
    partial class Buyer__list
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
            panel1 = new Panel();
            Buyer__list_distric = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            Buyer__list_rooms_to = new TextBox();
            Buyer__list_rooms_from = new TextBox();
            label4 = new Label();
            Buyer__list_area_to = new TextBox();
            Buyer__list_area_from = new TextBox();
            label3 = new Label();
            Buyer__list_price_to = new TextBox();
            Buyer__list_price_from = new TextBox();
            label2 = new Label();
            Buyer__list_sell = new CheckBox();
            Buyer__list_rent = new CheckBox();
            Buyer__list_house = new CheckBox();
            Buyer__list_flat = new CheckBox();
            Buyer__list_sector = new CheckBox();
            label1 = new Label();
            Buyer__list_set_filter = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Buyer__list_distric);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Buyer__list_rooms_to);
            panel1.Controls.Add(Buyer__list_rooms_from);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Buyer__list_area_to);
            panel1.Controls.Add(Buyer__list_area_from);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Buyer__list_price_to);
            panel1.Controls.Add(Buyer__list_price_from);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Buyer__list_sell);
            panel1.Controls.Add(Buyer__list_rent);
            panel1.Controls.Add(Buyer__list_house);
            panel1.Controls.Add(Buyer__list_flat);
            panel1.Controls.Add(Buyer__list_sector);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Buyer__list_set_filter);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 577);
            panel1.TabIndex = 0;
            // 
            // Buyer__list_distric
            // 
            Buyer__list_distric.FormattingEnabled = true;
            Buyer__list_distric.Location = new Point(3, 229);
            Buyer__list_distric.Name = "Buyer__list_distric";
            Buyer__list_distric.Size = new Size(230, 28);
            Buyer__list_distric.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 206);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 20;
            label9.Text = "Район";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(152, 428);
            label8.Name = "label8";
            label8.Size = new Size(26, 20);
            label8.TabIndex = 19;
            label8.Text = "м²";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(152, 395);
            label7.Name = "label7";
            label7.Size = new Size(26, 20);
            label7.TabIndex = 18;
            label7.Text = "м²";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 329);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 17;
            label6.Text = "грн";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 296);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 16;
            label5.Text = "грн";
            // 
            // Buyer__list_rooms_to
            // 
            Buyer__list_rooms_to.Location = new Point(21, 515);
            Buyer__list_rooms_to.Name = "Buyer__list_rooms_to";
            Buyer__list_rooms_to.PlaceholderText = "до";
            Buyer__list_rooms_to.Size = new Size(125, 27);
            Buyer__list_rooms_to.TabIndex = 15;
            Buyer__list_rooms_to.KeyPress += Seller_price_KeyPress;
            // 
            // Buyer__list_rooms_from
            // 
            Buyer__list_rooms_from.Location = new Point(21, 482);
            Buyer__list_rooms_from.Name = "Buyer__list_rooms_from";
            Buyer__list_rooms_from.PlaceholderText = "від";
            Buyer__list_rooms_from.Size = new Size(125, 27);
            Buyer__list_rooms_from.TabIndex = 14;
            Buyer__list_rooms_from.KeyPress += Seller_price_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 459);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 13;
            label4.Text = "Кількість кімнат";
            // 
            // Buyer__list_area_to
            // 
            Buyer__list_area_to.Location = new Point(21, 425);
            Buyer__list_area_to.Name = "Buyer__list_area_to";
            Buyer__list_area_to.PlaceholderText = "до";
            Buyer__list_area_to.Size = new Size(125, 27);
            Buyer__list_area_to.TabIndex = 12;
            Buyer__list_area_to.KeyPress += Seller_price_KeyPress;
            // 
            // Buyer__list_area_from
            // 
            Buyer__list_area_from.Location = new Point(21, 392);
            Buyer__list_area_from.Name = "Buyer__list_area_from";
            Buyer__list_area_from.PlaceholderText = "від";
            Buyer__list_area_from.Size = new Size(125, 27);
            Buyer__list_area_from.TabIndex = 11;
            Buyer__list_area_from.KeyPress += Seller_price_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 369);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 10;
            label3.Text = "Площа";
            // 
            // Buyer__list_price_to
            // 
            Buyer__list_price_to.Location = new Point(21, 326);
            Buyer__list_price_to.Name = "Buyer__list_price_to";
            Buyer__list_price_to.PlaceholderText = "до";
            Buyer__list_price_to.Size = new Size(125, 27);
            Buyer__list_price_to.TabIndex = 9;
            Buyer__list_price_to.KeyPress += Seller_price_KeyPress;
            // 
            // Buyer__list_price_from
            // 
            Buyer__list_price_from.Location = new Point(21, 293);
            Buyer__list_price_from.Name = "Buyer__list_price_from";
            Buyer__list_price_from.PlaceholderText = "від";
            Buyer__list_price_from.Size = new Size(125, 27);
            Buyer__list_price_from.TabIndex = 8;
            Buyer__list_price_from.KeyPress += Seller_price_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 270);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 7;
            label2.Text = "Ціна";
            // 
            // Buyer__list_sell
            // 
            Buyer__list_sell.AutoSize = true;
            Buyer__list_sell.Location = new Point(129, 179);
            Buyer__list_sell.Name = "Buyer__list_sell";
            Buyer__list_sell.Size = new Size(84, 24);
            Buyer__list_sell.TabIndex = 6;
            Buyer__list_sell.Text = "Купівля";
            Buyer__list_sell.UseVisualStyleBackColor = true;
            // 
            // Buyer__list_rent
            // 
            Buyer__list_rent.AutoSize = true;
            Buyer__list_rent.Location = new Point(21, 179);
            Buyer__list_rent.Name = "Buyer__list_rent";
            Buyer__list_rent.Size = new Size(84, 24);
            Buyer__list_rent.TabIndex = 5;
            Buyer__list_rent.Text = "Оренда";
            Buyer__list_rent.UseVisualStyleBackColor = true;
            // 
            // Buyer__list_house
            // 
            Buyer__list_house.AutoSize = true;
            Buyer__list_house.Location = new Point(21, 133);
            Buyer__list_house.Name = "Buyer__list_house";
            Buyer__list_house.Size = new Size(89, 24);
            Buyer__list_house.TabIndex = 4;
            Buyer__list_house.Text = "Будинок";
            Buyer__list_house.UseVisualStyleBackColor = true;
            // 
            // Buyer__list_flat
            // 
            Buyer__list_flat.AutoSize = true;
            Buyer__list_flat.Location = new Point(21, 103);
            Buyer__list_flat.Name = "Buyer__list_flat";
            Buyer__list_flat.Size = new Size(97, 24);
            Buyer__list_flat.TabIndex = 3;
            Buyer__list_flat.Text = "Квартира";
            Buyer__list_flat.UseVisualStyleBackColor = true;
            // 
            // Buyer__list_sector
            // 
            Buyer__list_sector.AutoSize = true;
            Buyer__list_sector.Location = new Point(21, 73);
            Buyer__list_sector.Name = "Buyer__list_sector";
            Buyer__list_sector.Size = new Size(85, 24);
            Buyer__list_sector.TabIndex = 2;
            Buyer__list_sector.Text = "Ділянка";
            Buyer__list_sector.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 50);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "Вид об'єкта";
            // 
            // Buyer__list_set_filter
            // 
            Buyer__list_set_filter.Location = new Point(21, 17);
            Buyer__list_set_filter.Name = "Buyer__list_set_filter";
            Buyer__list_set_filter.Size = new Size(192, 29);
            Buyer__list_set_filter.TabIndex = 0;
            Buyer__list_set_filter.Text = "Застосувати фільтр";
            Buyer__list_set_filter.UseVisualStyleBackColor = true;
            Buyer__list_set_filter.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(256, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(734, 577);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Buyer__list
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 600);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "Buyer__list";
            Text = "Список нерухомості";
            Load += Buyer__list_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Buyer__list_set_filter;
        private Label label2;
        private CheckBox Buyer__list_sell;
        private CheckBox Buyer__list_rent;
        private CheckBox Buyer__list_house;
        private CheckBox Buyer__list_flat;
        private CheckBox Buyer__list_sector;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox Buyer__list_rooms_to;
        private TextBox Buyer__list_rooms_from;
        private Label label4;
        private TextBox Buyer__list_area_to;
        private TextBox Buyer__list_area_from;
        private Label label3;
        private TextBox Buyer__list_price_to;
        private TextBox Buyer__list_price_from;
        private ComboBox Buyer__list_distric;
        private Label label9;
    }
}