using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TempExcel ( RH_TempExcel ) Entity类
    ///</summary>
    public class TempExcelEntity
    {
        private int m_ID = 0; //-- ID
        private string m_FileExcel = string.Empty; //-- FileExcel
        private string m_TableName = string.Empty; //-- TableName
        private string m_TempRemark = string.Empty; //-- TempRemark

        public TempExcelEntity(){ }
        public TempExcelEntity(int ID,string FileExcel,string TableName,string TempRemark)
        {
            this.ID=ID;
            this.FileExcel=FileExcel;
            this.TableName=TableName;
            this.TempRemark=TempRemark;
        }

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