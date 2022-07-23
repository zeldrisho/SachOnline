using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp_SQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dtgvExcel.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dtgvExcel.Columns[i].HeaderText;
            }
            for (int i = 0; i < dtgvExcel.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvExcel.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dtgvExcel.Rows[i].Cells[j].Value;
                }    
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void ImportExcel(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                for(int i=excelWorksheet.Dimension.Start.Column;i<=excelWorksheet.Dimension.End.Column;i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                } 
                for(int i=excelWorksheet.Dimension.Start.Row; i<=excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for(int j=excelWorksheet.Dimension.Start.Column;j<=excelWorksheet.Dimension.End.Column;j++)
                    {
                        listRows.Add(excelWorksheet.Cells[i,j].Value.ToString());
                    }
                    dataTable.Rows.Add(listRows.ToArray());
                }
                dtgvExcel.DataSource = dataTable;
            }    
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n"+ex.Message);
                }
            }    
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    MessageBox.Show("Nhập file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file không thành công!\n" + ex.Message);
                }
            }
        }
    }
}
