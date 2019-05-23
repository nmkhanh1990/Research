using DevExpress.XtraEditors;
using ExcelLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Web;
using System.Windows.Forms;
using System.Xml;

namespace PMS.Comon
{
    public class ExcelImport {
            
        public static DataSet ImportExcelXLS(HttpPostedFile file, bool hasHeaders) {
            string fileName = Path.GetTempFileName();
            file.SaveAs(fileName);

            return ImportExcelXLS(fileName, hasHeaders);
        }
        private static DataSet ImportExcelXLS(string FileName, bool hasHeaders) {
            string HDR = hasHeaders ? "Yes" : "No";
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FileName + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=1\"";

            DataSet output = new DataSet();

            using (OleDbConnection conn = new OleDbConnection(strConn)) {
                conn.Open();

                System.Data.DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                foreach (DataRow row in dt.Rows) {
                    string sheet = row["TABLE_NAME"].ToString();

                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM [" + sheet + "]", conn);
                    cmd.CommandType = CommandType.Text;

                    System.Data.DataTable outputTable = new System.Data.DataTable(sheet);
                    output.Tables.Add(outputTable);
                    new OleDbDataAdapter(cmd).Fill(outputTable);
                }
            }
            return output;
        }

        struct ColumnType {
            public Type type;
            private string name;
            public ColumnType(Type type) { this.type = type; this.name = type.ToString().ToLower(); }
            public object ParseString(string input) {
                if (String.IsNullOrEmpty(input))
                    return DBNull.Value;
                switch (type.ToString()) {
                    case "system.datetime":
                        return DateTime.Parse(input);
                    case "system.decimal":
                        return decimal.Parse(input);
                    case "system.boolean":
                        return bool.Parse(input);
                    default:
                        return input;
                }
            }
        }
        public static DataSet ImportExcelXML(HttpPostedFile file, bool hasHeaders, bool autoDetectColumnType) {
            return ImportExcelXML(file.InputStream, hasHeaders, autoDetectColumnType);
        }
        public static DataSet ImportExcelXML(Stream inputFileStream, bool hasHeaders, bool autoDetectColumnType) {
            XmlDocument doc = new XmlDocument();
            doc.Load(new XmlTextReader(inputFileStream));
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);

            nsmgr.AddNamespace("o", "urn:schemas-microsoft-com:office:office");
            nsmgr.AddNamespace("x", "urn:schemas-microsoft-com:office:excel");
            nsmgr.AddNamespace("ss", "urn:schemas-microsoft-com:office:spreadsheet");

            DataSet ds = new DataSet();

            foreach (XmlNode node in doc.DocumentElement.SelectNodes("//ss:Worksheet", nsmgr)) {
                System.Data.DataTable dt = new System.Data.DataTable(node.Attributes["ss:Name"].Value);
                ds.Tables.Add(dt);
                XmlNodeList rows = node.SelectNodes("ss:Table/ss:Row", nsmgr);
                if (rows.Count > 0) {
                    List<ColumnType> columns = new List<ColumnType>();
                    int startIndex = 0;
                    if (hasHeaders) {
                        foreach (XmlNode data in rows[0].SelectNodes("ss:Cell/ss:Data", nsmgr)) {
                            columns.Add(new ColumnType(typeof(string)));//default to text
                            dt.Columns.Add(data.InnerText, typeof(string));
                        }
                        startIndex++;
                    }
                    if (autoDetectColumnType && rows.Count > 0) {
                        XmlNodeList cells = rows[startIndex].SelectNodes("ss:Cell", nsmgr);
                        int actualCellIndex = 0;
                        for (int cellIndex = 0; cellIndex < cells.Count; cellIndex++) {
                            XmlNode cell = cells[cellIndex];
                            if (cell.Attributes["ss:Index"] != null)
                                actualCellIndex = int.Parse(cell.Attributes["ss:Index"].Value) - 1;

                            ColumnType autoDetectType = getType(cell.SelectSingleNode("ss:Data", nsmgr));

                            if (actualCellIndex >= dt.Columns.Count) {
                                dt.Columns.Add("Column" + actualCellIndex.ToString(), autoDetectType.type);
                                columns.Add(autoDetectType);
                            } else {
                                dt.Columns[actualCellIndex].DataType = autoDetectType.type;
                                columns[actualCellIndex] = autoDetectType;
                            }

                            actualCellIndex++;
                        }
                    }
                    for (int i = startIndex; i < rows.Count; i++) {
                        DataRow row = dt.NewRow();
                        XmlNodeList cells = rows[i].SelectNodes("ss:Cell", nsmgr);
                        int actualCellIndex = 0;
                        for (int cellIndex = 0; cellIndex < cells.Count; cellIndex++) {
                            XmlNode cell = cells[cellIndex];
                            if (cell.Attributes["ss:Index"] != null)
                                actualCellIndex = int.Parse(cell.Attributes["ss:Index"].Value) - 1;

                            XmlNode data = cell.SelectSingleNode("ss:Data", nsmgr);

                            if (actualCellIndex >= dt.Columns.Count) {
                                for (int j = dt.Columns.Count; j < actualCellIndex; j++)
                                {
                                    dt.Columns.Add("Column" + actualCellIndex.ToString(), typeof(string));
                                    columns.Add(getDefaultType());
                                }
                                ColumnType autoDetectType = getType(cell.SelectSingleNode("ss:Data", nsmgr));
                                dt.Columns.Add("Column" + actualCellIndex.ToString(), typeof(string));
                                columns.Add(autoDetectType);
                            }
                            if (data != null)
                                row[actualCellIndex] = data.InnerText;

                            actualCellIndex++;
                        }

                        dt.Rows.Add(row);
                    }
                }
            }
            return ds;

            //<?xml version="1.0"?>
            //<?mso-application progid="Excel.Sheet"?>
            //<Workbook>
            // <Worksheet ss:Name="Sheet1">
            //  <Table>
            //   <Row>
            //    <Cell><Data ss:Type="String">Item Number</Data></Cell>
            //    <Cell><Data ss:Type="String">Description</Data></Cell>
            //    <Cell ss:StyleID="s21"><Data ss:Type="String">Item Barcode</Data></Cell>
            //   </Row>
            // </Worksheet>
            //</Workbook>
        }

        private static ColumnType getDefaultType() {
            return new ColumnType(typeof(String));
        }

        private static ColumnType getType(XmlNode data) {
            string type = null;
            if (data.Attributes["ss:Type"] == null || data.Attributes["ss:Type"].Value == null)
                type = "";
            else
                type = data.Attributes["ss:Type"].Value;

            switch (type) {
                case "DateTime":
                    return new ColumnType(typeof(DateTime));
                case "Boolean":
                    return new ColumnType(typeof(Boolean));
                case "Number":
                    return new ColumnType(typeof(Decimal));
                case "":
                    decimal test2;
                    if (data == null || String.IsNullOrEmpty(data.InnerText) || decimal.TryParse(data.InnerText, out test2)) {
                        return new ColumnType(typeof(Decimal));
                    } else {
                        return new ColumnType(typeof(String));
                    }
                default://"String"
                    return new ColumnType(typeof(String));
            }
        }

        private static System.Data.DataTable CreateTable (System.Data.DataTable dbTable)
        {
            System.Data.DataTable tbl = new System.Data.DataTable();
            foreach (DataColumn itemcolumn in dbTable.Columns)
            {                
                tbl.Columns.Add(itemcolumn.ColumnName.ToString(),typeof(string));
            }
            return tbl;
        }

        public static void ExprotExcel( System.Data.DataTable tbl)
        {
            DataSet dsTable = new DataSet();
            System.Data.DataTable dbTable = CreateTable(tbl);
            foreach (DataRow item in tbl.Rows)
            {
                DataRow itemRow = dbTable.NewRow();
                foreach (DataColumn itemcolumn in tbl.Columns)
                {
                    itemRow[itemcolumn.ColumnName] = item[itemcolumn.ColumnName];
                }
                dbTable.Rows.Add(itemRow);
            }
            dsTable.Tables.Add(dbTable);
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Excel file (*.xls)|*.xls";
            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    iloveit1208Library k = new iloveit1208Library();//Lib ExcelLibrary
                    k.ExportToExcel(dsTable, f.FileName);
                    XtraMessageBox.Show("Đã xuất danh sách thành công.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    XtraMessageBox.Show("Lỗi xuất dữ liệu.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
        public static void exportDataToExcel(int ndongdautien, System.Data.DataTable dtTable)
        {
            
            object misValue = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(misValue);
            Microsoft.Office.Interop.Excel.Worksheet exSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlRange = exSheet.UsedRange;
            
            int iIndex = 0;
            //exSheet.get_Range("A1", "D1").Merge(false);
            //xlRange=exSheet.get_Range("A1", "D1");
            //xlRange.FormulaR1C1 = "TRƯỜNG ĐẠI HỌC NGÂN HÀNG TP.HCM";
            //xlRange.HorizontalAlignment = 1;
            //xlRange.VerticalAlignment = 1;
            ////xlRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            //xlRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            //xlRange.Font.Size = 10;
            ////xlRange.Font.FontStyle = System.Drawing.FontFamily.GetFamilies(System.Drawing.Font.FromHfont)
            //xlRange.EntireRow.Font.Bold = true;

            //exSheet.get_Range("E1", "H1").Merge(false);
            //xlRange = exSheet.get_Range("E1", "H1");
            //xlRange.FormulaR1C1 = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
            //xlRange.HorizontalAlignment = 1;
            //xlRange.VerticalAlignment = 1;
            ////xlRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            //xlRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            //xlRange.Font.Size = 10;
            //xlRange.EntireRow.Font.Bold = true;


            //exSheet.get_Range("E2", "H2").Merge(false);
            //xlRange = exSheet.get_Range("E2", "H2");
            //xlRange.FormulaR1C1 = "Độc lập- Tự do- Hạnh phúc ";
            //xlRange.HorizontalAlignment = 1;
            //xlRange.VerticalAlignment = 1;
            ////xlRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            //xlRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            //xlRange.Font.Size = 10;
            //xlRange.EntireRow.Font.Bold = true;


            //exSheet.get_Range("A4", "H4").Merge(false);
            //xlRange = exSheet.get_Range("A4", "H4");
            //xlRange.FormulaR1C1 = " TỔNG HỢP PHÂN CÔNG CHẤM THI TAY 2";
            //xlRange.HorizontalAlignment = 3;
            //xlRange.VerticalAlignment = 3;
            
            //xlRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
            //xlRange.Font.Size = 10;
            //xlRange.EntireRow.Font.Bold = true;

            xlRange = exSheet.get_Range("A1", "E1");            
            xlRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.PaleGreen);
            xlRange.EntireRow.Font.Bold = true;


            exSheet.Cells["1", 1] = "STT";
            exSheet.Cells["1", 2] = "TÊN MÔN HỌC";
            exSheet.Cells["1", 3] = " MÃ LỚP HỌC PHẦN";
            exSheet.Cells["1", 4] = "SỈ SỐ";
            exSheet.Cells["1", 5] = "MÃ GIẢNG VIÊN";


            int iTotalrow = dtTable.Rows.Count + 1;
            Microsoft.Office.Interop.Excel.Range cell = exSheet.Range["A1:E"+ iTotalrow];
            Microsoft.Office.Interop.Excel.Borders border = cell.Borders;
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            xlRange.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous);

            if (dtTable.Rows.Count >= ndongdautien)
            {
                xlRange = exSheet.get_Range("A1" , "E1");
                xlRange.NumberFormat = "@";
            }
            
            foreach (DataRow itemrow in dtTable.Rows)
            {
                iIndex = iIndex + 1;
                exSheet.Range["A" + ndongdautien.ToString()].Value = iIndex.ToString();
                for (int i = 1; i <= dtTable.Columns.Count; i++)
                {
                    
                    string strAlpha = GetAlpha(i);                  
                    exSheet.Range[strAlpha + ndongdautien.ToString()].Value = itemrow[dtTable.Columns[i - 1].ColumnName].ToString();
                   
                }
                ndongdautien++;
            }

            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Excel file (*.xls)|*.xls";
            if (f.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    xlWorkbook.SaveAs(f.FileName);
                    xlWorkbook.Close(true, misValue, misValue);
                    xlApp.Quit();
                    XtraMessageBox.Show("Đã xuất danh sách thành công.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    XtraMessageBox.Show("Lỗi xuất dữ liệu.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            releaseObject(xlApp);
            releaseObject(xlWorkbook);
            releaseObject(exSheet);
        }
        static public void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                throw new Exception("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private static string GetColumnName(System.Data.DataTable dbTable)
        {
            string strcolumn = string.Empty;
            foreach (DataColumn itemcolumn in dbTable.Columns)
            {
                foreach (DataColumn itemcolumndb in dbTable.Columns)
                {
                    if (itemcolumn.ColumnName == itemcolumndb.ColumnName)
                    {
                        strcolumn = itemcolumn.ColumnName;
                        break;
                    }

                }
            }
            return strcolumn;
        }

        private static string GetAlpha(int icountcolumn)
        {
            string strAlpha = string.Empty;
            string strAlphaindex = "0";
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = 0; i < alpha.Length; i++)
            {
                strAlphaindex = getColumnNameFromIndex(i);
                if (strAlphaindex.Length > 1)
                    strAlpha = strAlphaindex;
                else
                {
                    if (i == icountcolumn)
                    {
                        strAlpha = alpha[i].ToString();
                        break;
                    }
                }
            }
            return strAlpha;
        }

        public static String getColumnNameFromIndex(int column)
        {
            column--;
            String col = Convert.ToString((char)('A' + (column % 26)));
            while (column >= 26)
            {
                column = (column / 26) - 1;
                col = Convert.ToString((char)('A' + (column % 26))) + col;
            }
            return col;
        }

        public static void ExcelQuit()
        {
            System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("Excel");
            foreach (System.Diagnostics.Process p in process)
            {
                if (!string.IsNullOrEmpty(p.ProcessName) && p.StartTime.AddSeconds(+10) > DateTime.Now)
                {
                    try
                    {
                        p.Kill();
                    }
                    catch { }
                }
            }
        }

        public static System.Data.DataTable ReadFromExcel(string strFileName)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            Microsoft.Office.Interop.Excel.Range range;
            string strValue;
            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(strFileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;
            DataTable tbl = new DataTable();
            Microsoft.Office.Interop.Excel.Range rangeTemp;
            for (rCnt = 1; rCnt <= rw; rCnt++)
            {
                DataRow drItem = tbl.NewRow();
                for (cCnt = 1; cCnt <= cl; cCnt++)
                {
                    rangeTemp = range.Cells[rCnt, cCnt] as Microsoft.Office.Interop.Excel.Range;
                    if (rangeTemp == null) continue;
                    if (rCnt == 1)
                    {
                        string strColumnName = PMS.Common.Globals.BoDau (
                            (string)rangeTemp.Value2
                        );
                        tbl.Columns.Add(strColumnName, typeof(string));
                    }
                    else
                    {
                        strValue = PMS.Common.Globals.ToStr(rangeTemp.Value2);
                        drItem[tbl.Columns[cCnt - 1].ColumnName] = strValue;
                    }
                }
                if (rCnt > 1)
                    tbl.Rows.Add(drItem);
            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            return tbl;
        }
    }
}
