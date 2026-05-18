namespace kursova
{
    partial class Buyer
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
            Buyer__button_add = new Button();
            Buyer__button_list = new Button();
            SuspendLayout();
            // 
            // Buyer__button_add
            // 
            Buyer__button_add.Location = new Point(249, 127);
            Buyer__button_add.Name = "Buyer__button_add";
            Buyer__button_add.Size = new Size(310, 29);
            Buyer__button_add.TabIndex = 0;
            Buyer__button_add.Text = "Додати об'єкт нерухомості";
            Buyer__button_add.UseVisualStyleBackColor = true;
            Buyer__button_add.Click += button1_Click;
            // 
            // Buyer__button_list
            // 
            Buyer__button_list.Location = new Point(249, 184);
            Buyer__button_list.Name = "Buyer__button_list";
            Buyer__button_list.Size = new Size(310, 29);
            Buyer__button_list.TabIndex = 1;
            Buyer__button_list.Text = "Список об'єктів нерухомості\r\n";
            Buyer__button_list.UseVisualStyleBackColor = true;
            // 
            // Buyer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Buyer__button_list);
            Controls.Add(Buyer__button_add);
            Name = "Buyer";
            Text = "Buyer";
            ResumeLayout(false);
        }

        #endregion

        private Button Buyer__button_add;
        private Button Buyer__button_list;
    }
}