using System;
using System.ComponentModel;
using System.Drawing;
using DgvFilterPopup;

namespace DgvFilterPopupDemo
{
    public partial class Sample2 : Sample0
    {
        private DgvDateColumnFilter OrderDate;

        public Sample2()
        {
            InitializeComponent();
        }

        private void Sample2_Load(object sender, EventArgs e)
        {
            InitGrid();

            var fm = new DgvFilterManager
            {
                DataGridView = dataGridView1 //after this line, column filters are created
            };

            // Get the created column filter for OrderDate column
            OrderDate = (DgvDateColumnFilter)fm["OrderDate"];

            //Add some new operators
            OrderDate.ComboBoxOperator.Items.Insert(0, "This year");
            OrderDate.ComboBoxOperator.Items.Insert(1, "1 year ago");
            OrderDate.ComboBoxOperator.Items.Insert(2, "2 years ago");

            //Change the size to accomodate the length of the new operators
            OrderDate.ComboBoxOperator.Width += 30;
            OrderDate.DateTimePickerValue.Width -= 30;
            OrderDate.DateTimePickerValue.Location = new Point(OrderDate.DateTimePickerValue.Left + 30,
                OrderDate.DateTimePickerValue.Top);
            OrderDate.FilterExpressionBuilding += OrderDate_FilterExpressionBuilding;
        }

        private void OrderDate_FilterExpressionBuilding(object sender, CancelEventArgs e)
        {
            var index = OrderDate.ComboBoxOperator.SelectedIndex;
            if (index < 3)
            {
                // the first 3 are the new operators
                var year = DateTime.Today.Year - index;
                OrderDate.FilterExpression =
                    $"(OrderDate>='{year.ToString()}-1-1' AND OrderDate<='{year.ToString()}-12-31') ";
                OrderDate.FilterCaption =
                    $"{OrderDate.OriginalDataGridViewColumnHeaderText}\n = year {year.ToString()}";
                e.Cancel = true;
            }
        }
    }
}