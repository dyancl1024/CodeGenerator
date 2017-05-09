using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_CourseLevelRelation ( RH_CourseLevelRelation ) Entity类
    ///</summary>
    public class CourseLevelRelationEntity
    {
        private int m_ID = 0; //-- ID
        private int m_CourseID = 0; //-- CourseID
        private int m_CourseLevel = 0; //-- 1初级2中级3高级

        public CourseLevelRelationEntity(){ }
        public CourseLevelRelationEntity(int ID,int CourseID,int CourseLevel)
        {
            this.ID=ID;
            this.CourseID=CourseID;
            this.CourseLevel=CourseLevel;
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
        ///CourseID
        ///</summary>
        public int CourseID
        {
            set { m_CourseID = value;}
            get { return m_CourseID;}
        }

        ///<summary>
        ///1初级2中级3高级
        ///</summary>
        public int CourseLevel
        {
            set { m_CourseLevel = value;}
            get { return m_CourseLevel;}
        }

    }
}