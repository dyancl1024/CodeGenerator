using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingStudyGroupUser ( RH_TrainingStudyGroupUser ) Entity类
    ///</summary>
    public class TrainingStudyGroupUserEntity
    {
        private int m_ID = 0; //-- ID
        private int m_StudyGroupID = 0; //-- StudyGroupID
        private int m_UserID = 0; //-- UserID
        private int m_Status = 0; //-- 1.正常2.删除
        private DateTime m_CreateTime ; //-- 发布时间

        public TrainingStudyGroupUserEntity(){ }
        public TrainingStudyGroupUserEntity(int ID,int StudyGroupID,int UserID,int Status,DateTime CreateTime)
        {
            this.ID=ID;
            this.StudyGroupID=StudyGroupID;
            this.UserID=UserID;
            this.Status=Status;
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
        ///StudyGroupID
        ///</summary>
        public int StudyGroupID
        {
            set { m_StudyGroupID = value;}
            get { return m_StudyGroupID;}
        }

        ///<summary>
        ///UserID
        ///</summary>
        public int UserID
        {
            set { m_UserID = value;}
            get { return m_UserID;}
        }

        ///<summary>
        ///1.正常2.删除
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
        }

        ///<summary>
        ///发布时间
        ///</summary>
        public DateTime CreateTime
        {
            set { m_CreateTime = value;}
            get { return m_CreateTime;}
        }

    }
}