using System;
using DgvFilterPopup;

namespace DgvFilterPopupDemo
{
    public partial class Sample5 : Sample0
    {
        public Sample5()
        {
            InitializeComponent();
        }

        private void Sample5_Load(object sender, EventArgs e)
        {
            // Use this static property to set your culture-specific months naming. Default is full-named english months
            DgvMonthYearColumnFilter.MonthCsvList = "Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec";

            var fm = new DgvFilterManager(dataGridView1);
            InitGrid();
            fm["CustomerId"] = new CustomizedColumnFilter();
            fm["RequiredDate"] = new DgvDateRangeColumnFilter();
            fm["OrderId"] = new DgvNumRangeColumnFilter();
            fm["OrderDate"] = new DgvMonthYearColumnFilter();
            ((DgvMonthYearColumnFilter)fm["OrderDate"]).YearMin = 2007;
        }
    }
}