using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace KuaforSalonApp.UI
{
    public partial class Form1 : Form
    {
        
        Form1 form1=new Form1();
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image =
                Image.FromFile(@"C:\Users\tugba.bicakci\source\repos\KuaforSalonApp\KuaforSalonApp.UI\İmage\Kua.jpg");
        }

      
        private void ModernButton_Click(object sender, EventArgs e)
        {
           
          HandAndFoot af=new HandAndFoot();
          af.Show();
          form1.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
