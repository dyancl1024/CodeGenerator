using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingMyHomeWork ( RH_TrainingMyHomeWork ) Entity类
    ///</summary>
    public class TrainingMyHomeWorkEntity
    {
        private int m_ID = 0; //-- ID
        private string m_HomeWorkTitle = string.Empty; //-- 作业标题
        private string m_HomeWorkContent = string.Empty; //-- 作业内容
        private int m_HomeWorkPhaseID = 0; //-- 作业指标ID  RH_TrainingPhase
        private int m_SubTID = 0; //-- 阶段项目ID
        private int m_Status = 0; //-- 作业状态：1.待提交 2.待审批 3.不合格 4.合格 5.优秀 -不合格时（待提交）
        private int m_CreateBy = 0; //-- 导入人
        private DateTime m_CreateTime ; //-- 导入时间

        public TrainingMyHomeWorkEntity(){ }
        public TrainingMyHomeWorkEntity(int ID,string HomeWorkTitle,string HomeWorkContent,int HomeWorkPhaseID,int SubTID,int Status,int CreateBy,DateTime CreateTime)
        {
            this.ID=ID;
            this.HomeWorkTitle=HomeWorkTitle;
            this.HomeWorkContent=HomeWorkContent;
            this.HomeWorkPhaseID=HomeWorkPhaseID;
            this.SubTID=SubTID;
            this.Status=Status;
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
        ///作业标题
        ///</summary>
        public string HomeWorkTitle
        {
            set { m_HomeWorkTitle = value;}
            get { return m_HomeWorkTitle;}
        }

        ///<summary>
        ///作业内容
        ///</summary>
        public string HomeWorkContent
        {
            set { m_HomeWorkContent = value;}
            get { return m_HomeWorkContent;}
        }

        ///<summary>
        ///作业指标ID  RH_TrainingPhase
        ///</summary>
        public int HomeWorkPhaseID
        {
            set { m_HomeWorkPhaseID = value;}
            get { return m_HomeWorkPhaseID;}
        }

        ///<summary>
        ///阶段项目ID
        ///</summary>
        public int SubTID
        {
            set { m_SubTID = value;}
            get { return m_SubTID;}
        }

        ///<summary>
        ///作业状态：1.待提交 2.待审批 3.不合格 4.合格 5.优秀 -不合格时（待提交）
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
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