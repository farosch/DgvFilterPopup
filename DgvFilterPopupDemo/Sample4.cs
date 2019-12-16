using DgvFilterPopup;
using System;
using System.Drawing;

namespace DgvFilterPopupDemo
{
    public partial class Sample4 : DgvFilterPopupDemo.Sample0
    {
        public Sample4()
        {
            InitializeComponent();
        }

        private void Sample4_Load(object sender, EventArgs e)
        {
            InitGrid();
            DgvFilterManager fm = new DgvFilterManager();
            fm.FilterHost = new CustomizedFilterHost();
            fm.DataGridView = dataGridView1;
            // Customize the popup positioning.
            fm.PopupShowing += new ColumnFilterEventHandler(fm_PopupShowing);
        }

        void fm_PopupShowing(object sender, ColumnFilterEventArgs e)
        {
            DgvFilterManager fm = ((DgvFilterManager)sender);
            Rectangle HeaderRectangle = fm.DataGridView.GetCellDisplayRectangle(e.Column.Index, -1, true);
            //Show the popup under the column header
            fm.FilterHost.Popup.Show(fm.DataGridView, HeaderRectangle.Left, HeaderRectangle.Bottom);
            e.Handled = true;
        }
    }
}

