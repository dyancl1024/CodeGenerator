using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Org ( RH_Org ) Entity类
    ///</summary>
    public class OrgEntity
    {
        private int m_ID = 0; //-- 主键
        private string m_Name = string.Empty; //-- 承担机构名称
        private string m_Code = string.Empty; //-- 机构状态 1-正常 0-删除
        private int m_Sort = 0; //-- Sort
        private int m_Status = 0; //-- 1:正常 2.删除

        public OrgEntity(){ }
        public OrgEntity(int ID,string Name,string Code,int Sort,int Status)
        {
            this.ID=ID;
            this.Name=Name;
            this.Code=Code;
            this.Sort=Sort;
            this.Status=Status;
        }

        ///<summary>
        ///主键
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///承担机构名称
        ///</summary>
        public string Name
        {
            set { m_Name = value;}
            get { return m_Name;}
        }

        ///<summary>
        ///机构状态 1-正常 0-删除
        ///</summary>
        public string Code
        {
            set { m_Code = value;}
            get { return m_Code;}
        }

        ///<summary>
        ///Sort
        ///</summary>
        public int Sort
        {
            set { m_Sort = value;}
            get { return m_Sort;}
        }

        ///<summary>
        ///1:正常 2.删除
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
        }

    }
}