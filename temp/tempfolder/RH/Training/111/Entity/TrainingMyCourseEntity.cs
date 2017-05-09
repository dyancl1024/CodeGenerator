using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingMyCourse ( RH_TrainingMyCourse ) Entity类
    ///</summary>
    public class TrainingMyCourseEntity
    {
        private int m_ID = 0; //-- 主键
        private int m_SubTID = 0; //-- 项目id
        private int m_PCID = 0; //-- 套餐id，对应课程预设表
        private int m_CID = 0; //-- 课程id
        private int m_UserID = 0; //-- 学员id
        private DateTime m_CreateTime ; //-- 选课时间
        private int m_Status = 0; //-- 选课状态：1.正常2.删除

        public TrainingMyCourseEntity(){ }
        public TrainingMyCourseEntity(int ID,int SubTID,int PCID,int CID,int UserID,DateTime CreateTime,int Status)
        {
            this.ID=ID;
            this.SubTID=SubTID;
            this.PCID=PCID;
            this.CID=CID;
            this.UserID=UserID;
            this.CreateTime=CreateTime;
            this.Status=Status;
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
        ///项目id
        ///</summary>
        public int SubTID
        {
            set { m_SubTID = value;}
            get { return m_SubTID;}
        }

        ///<summary>
        ///套餐id，对应课程预设表
        ///</summary>
        public int PCID
        {
            set { m_PCID = value;}
            get { return m_PCID;}
        }

        ///<summary>
        ///课程id
        ///</summary>
        public int CID
        {
            set { m_CID = value;}
            get { return m_CID;}
        }

        ///<summary>
        ///学员id
        ///</summary>
        public int UserID
        {
            set { m_UserID = value;}
            get { return m_UserID;}
        }

        ///<summary>
        ///选课时间
        ///</summary>
        public DateTime CreateTime
        {
            set { m_CreateTime = value;}
            get { return m_CreateTime;}
        }

        ///<summary>
        ///选课状态：1.正常2.删除
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
        }

    }
}