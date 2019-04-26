using KuaforCostumer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuaforSalonForm
{
    public partial class Costumer : Form
    {
        public Costumer()
        {
            InitializeComponent();
        }
        Client client = new Client();
        private void button1_Click(object sender, EventArgs e)
        {
           
            client.Name = textBox1.Text;
            client.Surname = textBox2.Text;


            MessageBox.Show("Müsterinin Adı Soyadı :" + client.Name + "" + client.Surname);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Client c2 = client.ShallowCopy();
            c2.Name = "tugba ile aynı aileden müsteri ";

            
            MessageBox.Show("Var olan müsterinin ailesinden: " + c2.Name );

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Client c3 = client.DeepCopy();
            c3.Name = "tugba ile aynı aileden müsteri ";

            MessageBox.Show("Kayıtta değişikliğe izin verilmedi: " + c3.Name, c3.Surname);
        }
    }
}
