using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = productNameTxtBx.Text,
                Country = CountryTxtBx.Text,
                Price = CostTxtBx.Text
            };
            Form1 form = new Form1();
            
        }
    }
}
