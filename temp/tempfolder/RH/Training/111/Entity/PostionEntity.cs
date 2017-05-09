using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Postion ( RH_Postion ) Entity类
    ///</summary>
    public class PostionEntity
    {
        private int m_ID = 0; //-- 主键
        private string m_Name = string.Empty; //-- 职位名称
        private string m_Code = string.Empty; //-- 编号
        private int m_Sort = 0; //-- 顺序

        public PostionEntity(){ }
        public PostionEntity(int ID,string Name,string Code,int Sort)
        {
            this.ID=ID;
            this.Name=Name;
            this.Code=Code;
            this.Sort=Sort;
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
        ///职位名称
        ///</summary>
        public string Name
        {
            set { m_Name = value;}
            get { return m_Name;}
        }

        ///<summary>
        ///编号
        ///</summary>
        public string Code
        {
            set { m_Code = value;}
            get { return m_Code;}
        }

        ///<summary>
        ///顺序
        ///</summary>
        public int Sort
        {
            set { m_Sort = value;}
            get { return m_Sort;}
        }

    }
}