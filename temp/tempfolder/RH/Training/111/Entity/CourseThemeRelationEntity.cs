using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_CourseThemeRelation ( RH_CourseThemeRelation ) Entity类
    ///</summary>
    public class CourseThemeRelationEntity
    {
        private int m_ID = 0; //-- ID
        private int m_CourseID = 0; //-- 课程id
        private string m_CourseThemeCode = string.Empty; //-- 能力提升课程代码

        public CourseThemeRelationEntity(){ }
        public CourseThemeRelationEntity(int ID,int CourseID,string CourseThemeCode)
        {
            this.ID=ID;
            this.CourseID=CourseID;
            this.CourseThemeCode=CourseThemeCode;
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
        ///课程id
        ///</summary>
        public int CourseID
        {
            set { m_CourseID = value;}
            get { return m_CourseID;}
        }

        ///<summary>
        ///能力提升课程代码
        ///</summary>
        public string CourseThemeCode
        {
            set { m_CourseThemeCode = value;}
            get { return m_CourseThemeCode;}
        }

    }
}