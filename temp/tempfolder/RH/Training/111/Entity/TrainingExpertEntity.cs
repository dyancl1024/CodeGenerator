using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingExpert ( RH_TrainingExpert ) Entity类
    ///</summary>
    public class TrainingExpertEntity
    {
        private int m_ID = 0; //-- ID
        private int m_TID = 0; //-- TID
        private int m_SubTID = 0; //-- SubTID
        private int m_UserID = 0; //-- UserID
        private int m_CreateBy = 0; //-- 创建人
        private DateTime m_CreateTime ; //-- 创建时间
        private int m_UpdateBy = 0; //-- 更新人
        private DateTime m_UpdateTime ; //-- 更新时间

        public TrainingExpertEntity(){ }
        public TrainingExpertEntity(int ID,int TID,int SubTID,int UserID,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime)
        {
            this.ID=ID;
            this.TID=TID;
            this.SubTID=SubTID;
            this.UserID=UserID;
            this.CreateBy=CreateBy;
            this.CreateTime=CreateTime;
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
        ///TID
        ///</summary>
        public int TID
        {
            set { m_TID = value;}
            get { return m_TID;}
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
        ///UserID
        ///</summary>
        public int UserID
        {
            set { m_UserID = value;}
            get { return m_UserID;}
        }

        ///<summary>
        ///创建人
        ///</summary>
        public int CreateBy
        {
            set { m_CreateBy = value;}
            get { return m_CreateBy;}
        }

        ///<summary>
        ///创建时间
        ///</summary>
        public DateTime CreateTime
        {
            set { m_CreateTime = value;}
            get { return m_CreateTime;}
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