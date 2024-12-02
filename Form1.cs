using CashierApp3.Models;

namespace CashierApp3
{
    public partial class Form1 : Form
    {
        private readonly MyDbContext dbContext;
        public Form1()
        {
            InitializeComponent();

            dbContext = new MyDbContext();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            Products products = new Products(dbContext);
            products.ShowDialog();
        }

        private void btn_sale_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale(dbContext);
            sale.Show();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            History history = new History(dbContext);
            history.ShowDialog();
        }
    }
}
