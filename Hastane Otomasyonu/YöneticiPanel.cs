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
    public partial class YöneticiPanel : Form
    {
        public YöneticiPanel()
        {
            InitializeComponent();
        }

        private void btnanamenü_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
        }

        private void YöneticiPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
