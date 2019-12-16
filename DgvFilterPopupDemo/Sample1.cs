using DgvFilterPopup;
using System;

namespace DgvFilterPopupDemo
{
    public partial class Sample1 : DgvFilterPopupDemo.Sample0
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

