using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShope
{
    public partial class Form1 : Form
    {
        ReportCoffeeShopEntities context = new ReportCoffeeShopEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Menu = context.Menu.Include("TypeCoffee");
            crystalReport12.Database
                .Tables["CoffeeShope_Menu"]
                .SetDataSource(Menu);

            var TypeMenu = context.TypeCoffee.Include("Menu");
            crystalReport12.Database
                .Tables["CoffeeShope_TypeCoffee"]
                .SetDataSource(TypeMenu);

            crystalReportViewer1.ReportSource = crystalReport12;
            crystalReportViewer1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ดึงข้อมูลเมนูพร้อมการเชื่อมโยงกับออเดอร์ และกรองเฉพาะข้อมูลเดือนมกราคม 2024
            var Menu = context.Menu.Include("Order")
                .Where(m => m.Order.Any(o => o.date.Year == 2024 && o.date.Month == 1))
                .OrderBy(m => m.Order.Min(o => o.oid)); 
            crystalReport31.Database
                .Tables["CoffeeShope_Menu"]
                .SetDataSource(Menu); 

            // ดึงข้อมูลออเดอร์และกรองเฉพาะเดือนมกราคม 2024 พร้อมเรียงลำดับ oid จากน้อยไปมาก
            var Order = context.Order.Include("Menu")
                .Where(o => o.date.Year == 2024 && o.date.Month == 1)
                .OrderBy(o => o.oid);
            crystalReport31.Database
                .Tables["CoffeeShope_Order"]
                .SetDataSource(Order);

            crystalReportViewer1.ReportSource = crystalReport31;
            crystalReportViewer1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var Menu = context.Menu.Include("Order");
            crystalReport41.Database
                .Tables["CoffeeShope_Menu"]
                .SetDataSource(Menu);

 
            var Order = context.Order.Include("Menu");
            crystalReport41.Database
                .Tables["CoffeeShope_Order"]
                .SetDataSource(Order);


            crystalReportViewer1.ReportSource = crystalReport41;
            crystalReportViewer1.Show();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
