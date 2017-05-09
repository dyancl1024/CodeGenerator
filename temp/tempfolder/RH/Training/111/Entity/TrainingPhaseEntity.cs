using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingPhase ( RH_TrainingPhase ) Entity类
    ///</summary>
    public class TrainingPhaseEntity
    {
        private int m_ID = 0; //-- ID
        private int m_SubTID = 0; //-- SubTID
        private int m_PType = 0; //-- 1 课程学时 2.作业学时
        private string m_HomeName = string.Empty; //-- 作业名称
        private string m_HomeWorkDesc = string.Empty; //-- 作业描述
        private string m_HomeWorkCode = string.Empty; //-- 作业类型：表RH_TrainingHomeWorkType
        private int m_Phase = 0; //-- Phase
        private int m_CreateBy = 0; //-- 导入人
        private DateTime m_CreateTime ; //-- 导入时间
        private int m_UpdateBy = 0; //-- 更新人
        private DateTime m_UpdateTime ; //-- 更新时间

        public TrainingPhaseEntity(){ }
        public TrainingPhaseEntity(int ID,int SubTID,int PType,string HomeName,string HomeWorkDesc,string HomeWorkCode,int Phase,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime)
        {
            this.ID=ID;
            this.SubTID=SubTID;
            this.PType=PType;
            this.HomeName=HomeName;
            this.HomeWorkDesc=HomeWorkDesc;
            this.HomeWorkCode=HomeWorkCode;
            this.Phase=Phase;
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
        ///SubTID
        ///</summary>
        public int SubTID
        {
            set { m_SubTID = value;}
            get { return m_SubTID;}
        }

        ///<summary>
        ///1 课程学时 2.作业学时
        ///</summary>
        public int PType
        {
            set { m_PType = value;}
            get { return m_PType;}
        }

        ///<summary>
        ///作业名称
        ///</summary>
        public string HomeName
        {
            set { m_HomeName = value;}
            get { return m_HomeName;}
        }

        ///<summary>
        ///作业描述
        ///</summary>
        public string HomeWorkDesc
        {
            set { m_HomeWorkDesc = value;}
            get { return m_HomeWorkDesc;}
        }

        ///<summary>
        ///作业类型：表RH_TrainingHomeWorkType
        ///</summary>
        public string HomeWorkCode
        {
            set { m_HomeWorkCode = value;}
            get { return m_HomeWorkCode;}
        }

        ///<summary>
        ///Phase
        ///</summary>
        public int Phase
        {
            set { m_Phase = value;}
            get { return m_Phase;}
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