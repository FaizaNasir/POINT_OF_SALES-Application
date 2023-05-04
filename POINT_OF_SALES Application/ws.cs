using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POINT_OF_SALES_Application
{
    public partial class ws : Form
    {
        public ws()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HashingPassword h = new HashingPassword();
            label1.Text =  h.Decryption(textBox1.Text);
        }
    }
}
