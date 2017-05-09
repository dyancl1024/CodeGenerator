using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingClassRule ( RH_TrainingClassRule ) Entity类
    ///</summary>
    public class TrainingClassRuleEntity
    {
        private int m_ID = 0; //-- ID
        private int m_SubTID = 0; //-- 子项目ID
        private string m_GradeCode = string.Empty; //-- 学段代码
        private string m_SubjectCode = string.Empty; //-- 学科code
        private int m_ClassNum = 0; //-- ClassNum
        private int m_UpdateBy = 0; //-- 更新人
        private DateTime m_UpdateTime ; //-- 更新时间

        public TrainingClassRuleEntity(){ }
        public TrainingClassRuleEntity(int ID,int SubTID,string GradeCode,string SubjectCode,int ClassNum,int UpdateBy,DateTime UpdateTime)
        {
            this.ID=ID;
            this.SubTID=SubTID;
            this.GradeCode=GradeCode;
            this.SubjectCode=SubjectCode;
            this.ClassNum=ClassNum;
            this.UpdateBy=UpdateBy;
            this.UpdateTime=UpdateTime;
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
        ///子项目ID
        ///</summary>
        public int SubTID
        {
            set { m_SubTID = value;}
            get { return m_SubTID;}
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

        ///<summary>
        ///ClassNum
        ///</summary>
        public int ClassNum
        {
            set { m_ClassNum = value;}
            get { return m_ClassNum;}
        }

        ///<summary>
        ///更新人
        ///</summary>
        public int UpdateBy
        {
            set { m_UpdateBy = value;}
            get { return m_UpdateBy;}
        }

        ///<summary>
        ///更新时间
        ///</summary>
        public DateTime UpdateTime
        {
            set { m_UpdateTime = value;}
            get { return m_UpdateTime;}
        }

    }
}