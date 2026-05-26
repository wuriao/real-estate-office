namespace kursova
{
    partial class Seller
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
            Seller__button_add = new Button();
            Seller__button_list = new Button();
            SuspendLayout();
            // 
            // Seller__button_add
            // 
            Seller__button_add.ImeMode = ImeMode.NoControl;
            Seller__button_add.Location = new Point(234, 115);
            Seller__button_add.Name = "Seller__button_add";
            Seller__button_add.Size = new Size(310, 29);
            Seller__button_add.TabIndex = 2;
            Seller__button_add.Text = "Додати об'єкт нерухомості";
            Seller__button_add.UseVisualStyleBackColor = true;
            Seller__button_add.Click += Seller__button_add_Click;
            // 
            // Seller__button_list
            // 
            Seller__button_list.Location = new Point(234, 185);
            Seller__button_list.Name = "Seller__button_list";
            Seller__button_list.Size = new Size(310, 29);
            Seller__button_list.TabIndex = 3;
            Seller__button_list.Text = "Список об'єктів нерухомості\r\n";
            Seller__button_list.UseVisualStyleBackColor = true;
            Seller__button_list.Click += Seller__button_list_Click_1;
            // 
            // Seller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Seller__button_list);
            Controls.Add(Seller__button_add);
            Name = "Seller";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Seller__button_add;
        private Button Seller__button_list;
    }
}