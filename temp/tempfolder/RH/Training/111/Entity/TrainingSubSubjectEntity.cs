using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingSubSubject ( RH_TrainingSubSubject ) Entity类
    ///</summary>
    public class TrainingSubSubjectEntity
    {
        private int m_ID = 0; //-- ID
        private int m_SubTID = 0; //-- SubTID
        private string m_GradeCode = string.Empty; //-- GradeCode
        private string m_SubjectCode = string.Empty; //-- SubjectCode
        private int m_CreateBy = 0; //-- CreateBy
        private DateTime m_CreateTime ; //-- CreateTime

        public TrainingSubSubjectEntity(){ }
        public TrainingSubSubjectEntity(int ID,int SubTID,string GradeCode,string SubjectCode,int CreateBy,DateTime CreateTime)
        {
            this.ID=ID;
            this.SubTID=SubTID;
            this.GradeCode=GradeCode;
            this.SubjectCode=SubjectCode;
            this.CreateBy=CreateBy;
            this.CreateTime=CreateTime;
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
        ///SubTID
        ///</summary>
        public int SubTID
        {
            set { m_SubTID = value;}
            get { return m_SubTID;}
        }

        ///<summary>
        ///GradeCode
        ///</summary>
        public string GradeCode
        {
            set { m_GradeCode = value;}
            get { return m_GradeCode;}
        }

        ///<summary>
        ///SubjectCode
        ///</summary>
        public string SubjectCode
        {
            set { m_SubjectCode = value;}
            get { return m_SubjectCode;}
        }

        ///<summary>
        ///CreateBy
        ///</summary>
        public int CreateBy
        {
            set { m_CreateBy = value;}
            get { return m_CreateBy;}
        }

        ///<summary>
        ///CreateTime
        ///</summary>
        public DateTime CreateTime
        {
            set { m_CreateTime = value;}
            get { return m_CreateTime;}
        }

    }
}