using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Entities;
using PMS.Services;

namespace PMS.Common
{
    public static class XuLyTitle
    {
        public static void GetTitleAll(string strMaTruong, out string strShowField,out string strShowFieTitle,out int[] iSize)
        {
            strShowField = string.Empty;
            strShowFieTitle = string.Empty;
            iSize = null;
            TList<TieuDe> lstTieuDe = DataServices.TieuDe.GetAll();
            for (int i = 0; i < lstTieuDe.Count; i++)
            {
                if(checkMaTruong(lstTieuDe[i].MaTruong,strMaTruong))
                {

                }
            }
        }
        
        public static bool checkMaTruong(string strLstMaTruong,string strMaTruong)
        {
            bool bchk = false;
            string[] LstmaTruong = strLstMaTruong.Split(';');
            for (int i = 0; i < LstmaTruong.Length; i++)
            {
                if(LstmaTruong[i].ToString()== strMaTruong)
                {
                    bchk = true;
                    break;
                }
            }
            return bchk;
        }    
    }
}
