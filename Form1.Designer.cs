namespace CashierApp3
{
    partial class Form1
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
            btn_products = new Button();
            btn_sale = new Button();
            btn_history = new Button();
            SuspendLayout();
            // 
            // btn_products
            // 
            btn_products.BackColor = Color.Orange;
            btn_products.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_products.Location = new Point(76, 85);
            btn_products.Name = "btn_products";
            btn_products.Size = new Size(182, 79);
            btn_products.TabIndex = 0;
            btn_products.Text = "Products";
            btn_products.UseVisualStyleBackColor = false;
            btn_products.Click += btn_products_Click;
            // 
            // btn_sale
            // 
            btn_sale.BackColor = Color.LimeGreen;
            btn_sale.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sale.Location = new Point(291, 85);
            btn_sale.Name = "btn_sale";
            btn_sale.Size = new Size(182, 79);
            btn_sale.TabIndex = 1;
            btn_sale.Text = "Sale";
            btn_sale.UseVisualStyleBackColor = false;
            btn_sale.Click += btn_sale_Click;
            // 
            // btn_history
            // 
            btn_history.BackColor = Color.DodgerBlue;
            btn_history.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_history.Location = new Point(180, 191);
            btn_history.Name = "btn_history";
            btn_history.Size = new Size(182, 79);
            btn_history.TabIndex = 2;
            btn_history.Text = "History";
            btn_history.UseVisualStyleBackColor = false;
            btn_history.Click += btn_history_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 361);
            Controls.Add(btn_history);
            Controls.Add(btn_sale);
            Controls.Add(btn_products);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_products;
        private Button btn_sale;
        private Button btn_history;
    }
}
