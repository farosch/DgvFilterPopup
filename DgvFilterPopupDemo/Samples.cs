using System;
using System.Windows.Forms;

namespace DgvFilterPopupDemo
{
    public partial class Samples : Form
    {
        public Samples()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Sample1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new Sample2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var f = new Sample3();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f = new Sample4();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var f = new Sample5();
            f.Show();
        }
    }
}