using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Bromo_Airlines
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 form = new Form12();
            form.ShowDialog();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.ShowDialog();
            this.Hide();        }
    }
}
