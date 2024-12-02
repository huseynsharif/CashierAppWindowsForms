using CashierApp3.business;
using CashierApp3.Models;
using CashierApp3.utils;
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
    public partial class History : Form
    {

        private readonly SaleManager saleManager;
        private readonly ProductManager productManager;
        private List<SaleDto> dataList = new List<SaleDto>();


        public History(Models.MyDbContext dbContext)
        {
            InitializeComponent();
            saleManager = new SaleManager(dbContext);
            productManager = new ProductManager(dbContext);
        }

        private void History_Load(object sender, EventArgs e)
        {
            initDgv();

            initDateTimePickers();


        }

        private void initDateTimePickers()
        {
            dtp_start.Format = DateTimePickerFormat.Custom;
            dtp_start.CustomFormat = "hh:mm dd/MM/yyyy";

            dtp_end.Format = DateTimePickerFormat.Custom;
            dtp_end.CustomFormat = "hh:mm dd/MM/yyyy";
        }

        private void initDgv()
        {
            var list = saleManager.GetAll();
            foreach (var i in list)
            {
                i.Product = productManager.GetById(i.ProductId);
                this.dataList.Add(new SaleDto(i.Product.Name, i.Count, i.Datetime));
            }
            dgv_history.DataSource = this.dataList;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            var startDate = dtp_start.Value;
            var endDate = dtp_end.Value;


            this.dataList = dataList.Where(
                i => i.Datetime > startDate && i.Datetime < endDate
                ).ToList();

            dgv_history.DataSource = this.dataList;

        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            ExportUtil.ExportToExcel(this.dataList);
        }


    }
}
