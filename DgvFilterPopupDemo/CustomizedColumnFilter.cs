using DgvFilterPopup;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DgvFilterPopupDemo
{

    public partial class CustomizedColumnFilter : DgvBaseColumnFilter
    {

        Button mLastClickedButton;

        public CustomizedColumnFilter() {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.EventArgs e) {
            mLastClickedButton = ((Button)sender);
            // call the filter expression building
            FilterExpressionBuild();
        }

        protected override void OnFilterExpressionBuilding(object sender, CancelEventArgs e) {
            if (mLastClickedButton == null) return;
            string ColName = this.DataGridViewColumn.DataPropertyName;
            string btnText = mLastClickedButton.Text;
            FilterCaption = OriginalDataGridViewColumnHeaderText + "\n = " + btnText;

            switch (btnText) {
                case "A...D":
                    FilterExpression = "(" + ColName + ">='A' AND "+ColName+"<='DZ')";
                    break;
                case "E...H":
                    FilterExpression = "(" + ColName + ">='E' AND " + ColName + "<='HZ')";
                    break;
                case "I...L":
                    FilterExpression = "(" + ColName + ">='I' AND " + ColName + "<='LZ')";
                    break;
                case "M...P":
                    FilterExpression = "(" + ColName + ">='M' AND " + ColName + "<='PZ')";
                    break;
                case "Q...T":
                    FilterExpression = "(" + ColName + ">='Q' AND " + ColName + "<='TZ')";
                    break;
                case "U...Z":
                    FilterExpression = "(" + ColName + ">='U' AND " + ColName + "<='ZZ')";
                    break;
            }
            Active = true;
            //Apply the filter immediately
            FilterManager.RebuildFilter();
        }
    }
}
