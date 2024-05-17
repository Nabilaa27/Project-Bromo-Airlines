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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("IU-0969", "Super Ai", "Soekarno", "Supadio", "21-04-2", "07:25", "01 jam 3", "Sesuai J", "-", "Ubah");
            dataGridView1.Rows.Add("UI-0697", "Super Ai", "Supadio", "Soekarno", "27-04-2", "09.40", "01 jam 2", "Sesuai J", "-", "Ubah");
            dataGridView1.Rows.Add("ID-7508", "Batik Air", "Juanda", "Halim P", "22-05-", "05.00", "01 jam 1", "Sesuai J", "-", "Ubah");
            dataGridView1.Rows.Add("ID-6589", "Batik Air", "Juanda", "Soekarno", "22-05-", "05.00", "01 jam 2", "Sesuai J", "-", "Ubah");
            dataGridView1.Rows.Add("JT-0786", "Lion Air", "Juanda", "Soekarno", "22-05-", "05.00", "01 jam 3", "Sesuai J", "-", "Ubah");
            dataGridView1.Rows.Add("JT-0786", "Lion Air", "Juanda", "Soekarno", "22-05-", "05.55", "01 jam 0", "Sesuai J", "-", "Ubah");
            dataGridView1.Rows.Add("QG-0725", "Citilink", "Juanda", "Soekarno", "22-05-", "06.00", "01 jam 3", "Sesuai J", "-", "Ubah");
            dataGridView1.Rows.Add("UI-0706", "Super Ai", "Juanda", "Soekarno", "22-05-", "06.00", "00 jam ...", "Sesuai J", "-", "Ubah");
            dataGridView1.Rows.Add("UI-0333", "Super Ai", "Juanda", "Soekarno", "22-05-..", "06.00", "01 jam 2", "Sesuai J", "-", "Ubah");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void masterMaskapaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void masterJadwalPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void masterKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
