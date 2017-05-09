using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingHomeWorkAudit ( RH_TrainingHomeWorkAudit ) Entity类
    ///</summary>
    public class TrainingHomeWorkAuditEntity
    {
        private int m_ID = 0; //-- ID
        private int m_HomeWorkID = 0; //-- HomeWorkID
        private int m_Auditor = 0; //-- Auditor
        private DateTime m_AuditTime ; //-- AuditTime
        private string m_AuditDesc = string.Empty; //-- 审批意见
        private int m_Status = 0; //-- 作业状态：1.待提交 2.待审批 3.不合格 4.合格 5.优秀 -不合格时（待提交）

        public TrainingHomeWorkAuditEntity(){ }
        public TrainingHomeWorkAuditEntity(int ID,int HomeWorkID,int Auditor,DateTime AuditTime,string AuditDesc,int Status)
        {
            this.ID=ID;
            this.HomeWorkID=HomeWorkID;
            this.Auditor=Auditor;
            this.AuditTime=AuditTime;
            this.AuditDesc=AuditDesc;
            this.Status=Status;
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
        ///HomeWorkID
        ///</summary>
        public int HomeWorkID
        {
            set { m_HomeWorkID = value;}
            get { return m_HomeWorkID;}
        }

        ///<summary>
        ///Auditor
        ///</summary>
        public int Auditor
        {
            set { m_Auditor = value;}
            get { return m_Auditor;}
        }

        ///<summary>
        ///AuditTime
        ///</summary>
        public DateTime AuditTime
        {
            set { m_AuditTime = value;}
            get { return m_AuditTime;}
        }

        ///<summary>
        ///审批意见
        ///</summary>
        public string AuditDesc
        {
            set { m_AuditDesc = value;}
            get { return m_AuditDesc;}
        }

        ///<summary>
        ///作业状态：1.待提交 2.待审批 3.不合格 4.合格 5.优秀 -不合格时（待提交）
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
        }

    }
}