using System;
using DgvFilterPopup;

namespace DgvFilterPopupDemo
{
    public partial class Sample3 : Sample0
    {
        public Sample3()
        {
            InitializeComponent();
        }

        private void Sample3_Load(object sender, EventArgs e)
        {
            InitGrid();
            var fm = new DgvFilterManager();

            // Using the ColumnFilterAdding event, you may force your preferred filter,
            // BEFORE the FilterManager create the predefined filter. This event is 
            // raised for each column in the grid when you set the DataGridView property 
            // of the FilterManager.
            fm.ColumnFilterAdding += fm_ColumnFilterAdding;

            fm.DataGridView = dataGridView1; // this raises ColumnFilterAdding events

            // After column filters creation however, you can overwrite the created filter.
            fm["CustomerID"] = new DgvComboBoxColumnFilter();
        }

        private void fm_ColumnFilterAdding(object sender, ColumnFilterEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "ShipVia":
                case "OrderDate":
                case "Freight":
                    e.ColumnFilter = new DgvComboBoxColumnFilter();
                    break;
            }
        }
    }
}