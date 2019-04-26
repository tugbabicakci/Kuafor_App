using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuaforSalonApp.UI
{
    public partial class HandAndFoot : Form
    {
        public HandAndFoot()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image=
                Image.FromFile(@"C:\Users\tugba.bicakci\source\repos\KuaforSalonApp\KuaforSalonApp.UI\İmage\nail.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Costum().CostumMethod(new ModernFactory());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Costum().CostumMethod(new ClassicFactory());
        }
    }

}
