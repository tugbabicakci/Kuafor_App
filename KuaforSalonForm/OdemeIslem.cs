using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HairDesigner.Dll;

namespace KuaforSalonForm
{
    public partial class OdemeIslem : Form
    {
        public OdemeIslem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ICartReaderAdapter cartReaderAdapter=new XBankCartReader();


            MessageBox.Show(cartReaderAdapter.ReadCartData());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ICartReaderAdapter cartReaderAdapter=new YBankCartReader();

            MessageBox.Show(cartReaderAdapter.ReadCartData());
        }
    }
}
