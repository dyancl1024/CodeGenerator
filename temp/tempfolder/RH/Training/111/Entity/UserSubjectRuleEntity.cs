using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_UserSubjectRule ( RH_UserSubjectRule ) Entity类
    ///</summary>
    public class UserSubjectRuleEntity
    {
        private int m_ID = 0; //-- ID
        private int m_UserID = 0; //-- 用户id
        private string m_GradeCode = string.Empty; //-- 学段id
        private string m_SubjectCode = string.Empty; //-- 学科ID
        private int m_TID = 0; //-- 子项目ID  一个学员在一个项目下只有一个学段学科

        public UserSubjectRuleEntity(){ }
        public UserSubjectRuleEntity(int ID,int UserID,string GradeCode,string SubjectCode,int TID)
        {
            this.ID=ID;
            this.UserID=UserID;
            this.GradeCode=GradeCode;
            this.SubjectCode=SubjectCode;
            this.TID=TID;
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
        ///用户id
        ///</summary>
        public int UserID
        {
            set { m_UserID = value;}
            get { return m_UserID;}
        }

        ///<summary>
        ///学段id
        ///</summary>
        public string GradeCode
        {
            set { m_GradeCode = value;}
            get { return m_GradeCode;}
        }

        ///<summary>
        ///学科ID
        ///</summary>
        public string SubjectCode
        {
            set { m_SubjectCode = value;}
            get { return m_SubjectCode;}
        }

        ///<summary>
        ///子项目ID  一个学员在一个项目下只有一个学段学科
        ///</summary>
        public int TID
        {
            set { m_TID = value;}
            get { return m_TID;}
        }

    }
}