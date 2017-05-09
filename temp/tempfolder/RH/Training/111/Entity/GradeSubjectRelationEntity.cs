using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_GradeSubjectRelation ( RH_GradeSubjectRelation ) Entity类
    ///</summary>
    public class GradeSubjectRelationEntity
    {
        private int m_ID = 0; //-- ID
        private string m_GradeCode = string.Empty; //-- 学段代码
        private string m_SubjectCode = string.Empty; //-- 学科code

        public GradeSubjectRelationEntity(){ }
        public GradeSubjectRelationEntity(int ID,string GradeCode,string SubjectCode)
        {
            this.ID=ID;
            this.GradeCode=GradeCode;
            this.SubjectCode=SubjectCode;
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
        ///学段代码
        ///</summary>
        public string GradeCode
        {
            set { m_GradeCode = value;}
            get { return m_GradeCode;}
        }

        ///<summary>
        ///学科code
        ///</summary>
        public string SubjectCode
        {
            set { m_SubjectCode = value;}
            get { return m_SubjectCode;}
        }

    }
}