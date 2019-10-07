using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Common
{
    public class XuLyTapHop
    {
        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        public static DataTable LoaiBoDongTrong(DataTable dt)
        {
            DataTable dtResult = dt.Copy();
            int i = 0;
            bool isNullRow;
            foreach (DataRow row in dt.Rows)
            {
                isNullRow = true;
                foreach (DataColumn column in dt.Columns)
                {
                    if (row[column] != null && row[column].ToString() != "")
                    {
                        isNullRow = false;
                    }
                }
                if (isNullRow)
                {
                    dtResult.Rows.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
            return dtResult;
        }
    }
}
