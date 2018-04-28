using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactoryCustomer;
using MiddleLayer;

namespace WinFormCustomer
{
    public partial class FrmCustomer : Form
    {
        private CustomerBase cust = null;

        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cust = Factory.CreateCustomer("Lead");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cust.Validate();
        }
    }
}
