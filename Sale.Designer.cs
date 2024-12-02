namespace CashierApp3
{
    partial class Sale
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
            label1 = new Label();
            label3 = new Label();
            tb_count = new TextBox();
            btn_sale = new Button();
            cb_products = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 64);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 130);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Count";
            // 
            // tb_count
            // 
            tb_count.Location = new Point(87, 148);
            tb_count.Name = "tb_count";
            tb_count.Size = new Size(65, 23);
            tb_count.TabIndex = 6;
            // 
            // btn_sale
            // 
            btn_sale.BackColor = Color.MediumPurple;
            btn_sale.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sale.Location = new Point(106, 211);
            btn_sale.Name = "btn_sale";
            btn_sale.Size = new Size(102, 53);
            btn_sale.TabIndex = 8;
            btn_sale.Text = "Sale";
            btn_sale.UseVisualStyleBackColor = false;
            btn_sale.Click += btn_sale_Click_1;
            // 
            // cb_products
            // 
            cb_products.FormattingEnabled = true;
            cb_products.Location = new Point(87, 82);
            cb_products.Name = "cb_products";
            cb_products.Size = new Size(121, 23);
            cb_products.TabIndex = 9;
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 320);
            Controls.Add(cb_products);
            Controls.Add(btn_sale);
            Controls.Add(label3);
            Controls.Add(tb_count);
            Controls.Add(label1);
            Name = "Sale";
            Text = "Sale";
            Load += Sale_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox tb_count;
        private Button btn_sale;
        private ComboBox cb_products;
    }
}