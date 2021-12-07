using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DgvFilterPopupDemo.Properties;

namespace DgvFilterPopupDemo
{
    public partial class Sample0 : Form
    {
        public Sample0()
        {
            InitializeComponent();
        }

        public DataTable GetData(string strSQL)
        {
            var DataAdapter = new OleDbDataAdapter(strSQL, Settings.Default.SampleDBConnectionString);
            var dtable = new DataTable();
            DataAdapter.Fill(dtable);
            DataAdapter.SelectCommand.Connection.Close();
            return dtable;
        }

        public void InitGrid()
        {
            var EmployeeID = (DataGridViewComboBoxColumn)dataGridView1.Columns["EmployeeID"];
            EmployeeID.DataPropertyName = "EmployeeID";
            EmployeeID.ValueMember = "EmployeeID";
            EmployeeID.DisplayMember = "FullName";
            EmployeeID.DataSource = GetData("SELECT EmployeeID, LastName + ' ' + FirstName as FullName FROM Employees");
            EmployeeID.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.DataSource = GetData("SELECT * FROM Orders");
            dataGridView1.Columns["EmployeeID"].DisplayIndex = 2;
        }
    }
}