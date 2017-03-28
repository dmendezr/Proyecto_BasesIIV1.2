using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class ReporteDatos : Form
    {
        DataTable dt;
        public ReporteDatos(DataTable dtEnv)
        {
            dt = new DataTable();
            dt = dtEnv;
            InitializeComponent();
        }

        public void exporta_a_excel(DataGridView grd)

        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                //Rellena Excel

                int ColumnIndex = 0;

                foreach (DataGridViewColumn col in grd.Columns)

                {
                    ColumnIndex++;
                    hoja_trabajo.Cells[1, ColumnIndex] = col.Name;
                }

                int rowIndex = 0;

                foreach (DataGridViewRow row in grd.Rows)
                {
                    rowIndex++;
                    ColumnIndex = 0;

                    foreach (DataGridViewColumn col in grd.Columns)
                    {
                        ColumnIndex++;
                        hoja_trabajo.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void ReporteDatos_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            exporta_a_excel(dgvDatos);
        }
    }
}
