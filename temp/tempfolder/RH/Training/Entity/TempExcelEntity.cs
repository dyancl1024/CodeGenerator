using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TempExcel ( RH_TempExcel ) Entity类
    ///</summary>
    [Serializable]
    public class TempExcelEntity
    {
        private int m_ID = 0; 
        private string m_FileExcel = string.Empty; 
        private string m_TableName = string.Empty; 
        private string m_TempRemark = string.Empty; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///FileExcel
        ///</summary>
        public string FileExcel
        {
            set { m_FileExcel = value;}
            get { return m_FileExcel;}
        }

        ///<summary>
        ///TableName
        ///</summary>
        public string TableName
        {
            set { m_TableName = value;}
            get { return m_TableName;}
        }

        ///<summary>
        ///TempRemark
        ///</summary>
        public string TempRemark
        {
            set { m_TempRemark = value;}
            get { return m_TempRemark;}
        }

    }
}