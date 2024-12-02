namespace CashierApp3
{
    partial class Products
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
            tb_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tb_price = new TextBox();
            label3 = new Label();
            tb_count = new TextBox();
            btn_add = new Button();
            dgv_products = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            SuspendLayout();
            // 
            // tb_name
            // 
            tb_name.Location = new Point(53, 50);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(100, 23);
            tb_name.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 32);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 32);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 3;
            label2.Text = "Price";
            // 
            // tb_price
            // 
            tb_price.Location = new Point(187, 50);
            tb_price.Name = "tb_price";
            tb_price.Size = new Size(100, 23);
            tb_price.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(310, 32);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Count";
            // 
            // tb_count
            // 
            tb_count.Location = new Point(310, 50);
            tb_count.Name = "tb_count";
            tb_count.Size = new Size(65, 23);
            tb_count.TabIndex = 4;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.MediumSpringGreen;
            btn_add.Location = new Point(416, 49);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 6;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // dgv_products
            // 
            dgv_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_products.Location = new Point(53, 154);
            dgv_products.Name = "dgv_products";
            dgv_products.Size = new Size(438, 290);
            dgv_products.TabIndex = 7;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 483);
            Controls.Add(dgv_products);
            Controls.Add(btn_add);
            Controls.Add(label3);
            Controls.Add(tb_count);
            Controls.Add(label2);
            Controls.Add(tb_price);
            Controls.Add(label1);
            Controls.Add(tb_name);
            Name = "Products";
            Text = "Products";
            Load += Products_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_name;
        private Label label1;
        private Label label2;
        private TextBox tb_price;
        private Label label3;
        private TextBox tb_count;
        private Button btn_add;
        private DataGridView dgv_products;
    }
}