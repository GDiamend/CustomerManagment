using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManagment.forms
{
    partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCustomerManagment_Click(object sender, EventArgs e)
        {
            CustomerManagment customerManagment = new CustomerManagment();
            customerManagment.ShowDialog();
        }
    }
}
