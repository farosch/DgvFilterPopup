using System;
using DgvFilterPopup;

namespace DgvFilterPopupDemo
{
    public partial class Sample1 : Sample0
    {
        public Sample1()
        {
            InitializeComponent();
        }

        private void Sample1_Load(object sender, EventArgs e)
        {
            InitGrid();
            new DgvFilterManager(dataGridView1);
        }
    }
}