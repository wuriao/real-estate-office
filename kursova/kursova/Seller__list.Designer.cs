namespace kursova
{
    partial class Seller__list
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
            Seller_flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // Seller_flowLayoutPanel1
            // 
            Seller_flowLayoutPanel1.Location = new Point(12, 12);
            Seller_flowLayoutPanel1.Name = "Seller_flowLayoutPanel1";
            Seller_flowLayoutPanel1.Size = new Size(876, 426);
            Seller_flowLayoutPanel1.TabIndex = 0;
            // 
            // Seller__list
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(Seller_flowLayoutPanel1);
            Name = "Seller__list";
            Text = "Додані об'єкти нерухомості";
            Load += Seller__list_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Seller_flowLayoutPanel1;
    }
}