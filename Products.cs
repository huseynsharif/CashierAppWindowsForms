using CashierApp3.business;
using CashierApp3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CashierApp3
{
    public partial class Products : Form
    {
        private readonly ProductManager manager;
        public Products(Models.MyDbContext dbContext)
        {
            InitializeComponent();
            manager = new ProductManager(dbContext);
        }

        private void Products_Load(object sender, EventArgs e)
        {
            initDgv();
        }

        private void initDgv()
        {
            dgv_products.DataSource = manager.GetAll();
            dgv_products.Columns["Id"].Visible = false;
            dgv_products.Columns["Sales"].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            try
            {
                Product product = new Product()
                {
                    Name = tb_name.Text,
                    Price = float.Parse(tb_price.Text),
                    Count = int.Parse(tb_count.Text),
                };

                manager.Add(product);
                MessageBox.Show("Added Successfully");
                initDgv();
            }
            catch{
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
