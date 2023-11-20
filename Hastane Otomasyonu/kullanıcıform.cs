using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class kullanıcıform : Form
    {
        Form1 form1 = new Form1();
        public kullanıcıform()
        {
            InitializeComponent();
        }

        private void kullanıcıform_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            form1.Show();
        }

        private void btnanamenü_Click(object sender, EventArgs e)
        {
            form1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
