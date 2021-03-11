using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FileLab
{
    public partial class DatabaseExport : Form
    {
        public DatabaseExport()
        {
            InitializeComponent();
        }

        private void DatabaseExport_Load(object sender, EventArgs e)
        {
            //
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                SqlCommand command = new SqlCommand(QueryTextBox.Text, sqlConnect.connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                DataGridView.DataSource = dataTable;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Error");
                return;
            }
        }

        private void QueryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                var excelWb = excelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i < DataGridView.Columns.Count - 1; i++)
                {
                    excelApp.Cells[1, i + 1] = DataGridView.Columns[i].HeaderText;
                }

                for (int i = 0; i < DataGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < DataGridView.Columns.Count - 1; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = DataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "xlsx";
                sfd.FileName = "Database_Export.xlsx";
                sfd.AddExtension = true;
                sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                sfd.ShowDialog();
                excelApp.Application.ActiveWorkbook.SaveCopyAs(sfd.FileName);
                excelApp.Application.ActiveWorkbook.Saved = true;

                excelApp.Application.Quit();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Error");
                return;
            }
        }

        private void btn_ConnectionClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExcelSave_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
