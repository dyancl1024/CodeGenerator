using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingEducationer ( RH_TrainingEducationer ) Entity类
    ///</summary>
    public class TrainingEducationerEntity
    {
        private int m_ID = 0; //-- ID
        private int m_DesignID = 0; //-- 阶段项目id
        private int m_UserID = 0; //-- 用户id
        private int m_CreateBy = 0; //-- CreateBy
        private DateTime m_CreateTime ; //-- CreateTime

        public TrainingEducationerEntity(){ }
        public TrainingEducationerEntity(int ID,int DesignID,int UserID,int CreateBy,DateTime CreateTime)
        {
            this.ID=ID;
            this.DesignID=DesignID;
            this.UserID=UserID;
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
        ///阶段项目id
        ///</summary>
        public int DesignID
        {
            set { m_DesignID = value;}
            get { return m_DesignID;}
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