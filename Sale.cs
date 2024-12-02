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

namespace CashierApp3
{
    public partial class Sale : Form
    {

        private readonly SaleManager saleManager;
        private readonly ProductManager productManager;

        public Sale(Models.MyDbContext dbContext)
        {
            InitializeComponent();
            saleManager = new SaleManager(dbContext);
            productManager = new ProductManager(dbContext);
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            cb_products.DataSource = productManager.GetAll();
            cb_products.ValueMember = "id";
            cb_products.DisplayMember = "Name";
        }

        private void btn_sale_Click_1(object sender, EventArgs e)
        {

            //MessageBox.Show(cb_products.SelectedValue.ToString());

            Product product = productManager.GetById(int.Parse(cb_products.SelectedValue.ToString()));

            Models.Sale sale = new Models.Sale(int.Parse(cb_products.SelectedValue.ToString())
                , int.Parse(tb_count.Text),
                DateTime.Now
                );

            if (saleManager.SaleProduct(sale))
            {
                MessageBox.Show("Saled successfully.");
            }
            else
            {
                MessageBox.Show("Not enough product.");
            }
        }
    }
}
