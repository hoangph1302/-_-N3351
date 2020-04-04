using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_PhamHuyHoang
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {
            Price formPrice = new Price();
            formPrice.Show();
        }

        private void button_Pay_Click(object sender, EventArgs e)
        {
            Pay formPay = new Pay();
            formPay.ShowDialog();
        }
    }
}
