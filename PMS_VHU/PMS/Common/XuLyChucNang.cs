using PMS.Entities;
using PMS.Services;

namespace PMS.Common
{
    public class XuLyChucNang
    {
        public static string ChoPhepChotChucNang(string strIDChucNang,string strFormName)
        {
            string b = string.Empty;
            if (strIDChucNang != null && strFormName != null)
            {
                foreach (var item in strIDChucNang.Split(';'))
                {
                    ChucNang itemChucNang = DataServices.ChucNang.GetById(int.Parse(item));
                    if(itemChucNang!=null)
                    {
                        if(itemChucNang.TenForm==strFormName)
                        {
                            b = itemChucNang.Id.ToString();
                        }
                    }
                }            
            }
            return b;
        }       
    }
}
