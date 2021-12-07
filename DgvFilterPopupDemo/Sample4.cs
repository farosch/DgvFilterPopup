using System;
using DgvFilterPopup;

namespace DgvFilterPopupDemo
{
    public partial class Sample4 : Sample0
    {
        public Sample4()
        {
            InitializeComponent();
        }

        private void Sample4_Load(object sender, EventArgs e)
        {
            InitGrid();
            var fm = new DgvFilterManager();
            fm.FilterHost = new CustomizedFilterHost();
            fm.DataGridView = dataGridView1;
            // Customize the popup positioning.
            fm.PopupShowing += fm_PopupShowing;
        }

        private void fm_PopupShowing(object sender, ColumnFilterEventArgs e)
        {
            var fm = (DgvFilterManager)sender;
            var HeaderRectangle = fm.DataGridView.GetCellDisplayRectangle(e.Column.Index, -1, true);
            //Show the popup under the column header
            fm.FilterHost.Popup.Show(fm.DataGridView, HeaderRectangle.Left, HeaderRectangle.Bottom);
            e.Handled = true;
        }
    }
}