using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Grade ( RH_Grade ) Entity类
    ///</summary>
    public class GradeEntity
    {
        private int m_ID = 0; //-- ID
        private string m_Name = string.Empty; //-- Name
        private string m_Code = string.Empty; //-- Code
        private int m_Sort = 0; //-- Sort
        private int m_ParentID = 0; //-- 0：大学段（如：小学） ，&lt;&gt;0:小学段（如小学1-6年级）

        public GradeEntity(){ }
        public GradeEntity(int ID,string Name,string Code,int Sort,int ParentID)
        {
            this.ID=ID;
            this.Name=Name;
            this.Code=Code;
            this.Sort=Sort;
            this.ParentID=ParentID;
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
        ///Name
        ///</summary>
        public string Name
        {
            set { m_Name = value;}
            get { return m_Name;}
        }

        ///<summary>
        ///Code
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
        ///0：大学段（如：小学） ，&lt;&gt;0:小学段（如小学1-6年级）
        ///</summary>
        public int ParentID
        {
            set { m_ParentID = value;}
            get { return m_ParentID;}
        }

    }
}