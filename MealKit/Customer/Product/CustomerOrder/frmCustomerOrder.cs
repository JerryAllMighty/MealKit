using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MealKit.Customer.Product.CustomerOrder.Customer.Product.CustomerOrder;
namespace MealKit.Customer.Product.CustomerOrder
{    
    public partial class frmCustomerOrder : Form
    {
        public frmCustomerOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOrderBest frm = new frmOrderBest();
            frm.Show();
            frm.Activate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOrderBeverage frm = new frmOrderBeverage();
            frm.Show();
            frm.Activate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmOrderChinese frm = new frmOrderChinese();
            frm.Show();
            frm.Activate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmOrderHealthy frm = new frmOrderHealthy();
            frm.Show();
            frm.Activate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmOrderKids frm = new frmOrderKids();
            frm.Show();
            frm.Activate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmOrderKorean frm = new frmOrderKorean();
            frm.Show();
            frm.Activate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmOrderMorning frm = new frmOrderMorning();
            frm.Show();
            frm.Activate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmOrderWestern frm = new frmOrderWestern();
            frm.Show();
            frm.Activate();
        }
    }
}
