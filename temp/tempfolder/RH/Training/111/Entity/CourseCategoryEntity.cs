using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_CourseCategory ( RH_CourseCategory ) Entity类
    ///</summary>
    public class CourseCategoryEntity
    {
        private int m_ID = 0; //-- ID
        private string m_Name = string.Empty; //-- 通识、技术、教研、科研、专业、技术素养、计划与准备、组织与管理、评估与诊断、组织与发展
        private string m_Code = string.Empty; //-- Code
        private int m_Type = 0; //-- 课程类型：1非能力2能力
        private int m_Sort = 0; //-- Sort

        public CourseCategoryEntity(){ }
        public CourseCategoryEntity(int ID,string Name,string Code,int Type,int Sort)
        {
            this.ID=ID;
            this.Name=Name;
            this.Code=Code;
            this.Type=Type;
            this.Sort=Sort;
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
        ///通识、技术、教研、科研、专业、技术素养、计划与准备、组织与管理、评估与诊断、组织与发展
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
        ///课程类型：1非能力2能力
        ///</summary>
        public int Type
        {
            set { m_Type = value;}
            get { return m_Type;}
        }

        ///<summary>
        ///Sort
        ///</summary>
        public int Sort
        {
            set { m_Sort = value;}
            get { return m_Sort;}
        }

    }
}