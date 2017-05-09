using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingTeacher ( RH_TrainingTeacher ) Entity类
    ///</summary>
    public class TrainingTeacherEntity
    {
        private int m_ID = 0; //-- ID
        private int m_UserID = 0; //-- 用户id
        private int m_SubTID = 0; //-- 项目id
        private int m_CreateBy = 0; //-- 导入人
        private DateTime m_CreateTime ; //-- 导入时间

        public TrainingTeacherEntity(){ }
        public TrainingTeacherEntity(int ID,int UserID,int SubTID,int CreateBy,DateTime CreateTime)
        {
            this.ID=ID;
            this.UserID=UserID;
            this.SubTID=SubTID;
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
        ///用户id
        ///</summary>
        public int UserID
        {
            set { m_UserID = value;}
            get { return m_UserID;}
        }

        ///<summary>
        ///项目id
        ///</summary>
        public int SubTID
        {
            set { m_SubTID = value;}
            get { return m_SubTID;}
        }

        ///<summary>
        ///导入人
        ///</summary>
        public int CreateBy
        {
            set { m_CreateBy = value;}
            get { return m_CreateBy;}
        }

        ///<summary>
        ///导入时间
        ///</summary>
        public DateTime CreateTime
        {
            set { m_CreateTime = value;}
            get { return m_CreateTime;}
        }

    }
}