using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
  
namespace MealKit.Customer.Product.CustomerOrder
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 고객ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm = new frmCustomer();
            //frm.Show();
            //frm.Activate();
        }

        private void 주문ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerOrder frm = new frmCustomerOrder();
            frm.Show();
            frm.Activate();
        }
    }
}
