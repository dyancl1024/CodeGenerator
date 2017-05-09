using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingStudyGroup ( RH_TrainingStudyGroup ) Entity类
    ///</summary>
    public class TrainingStudyGroupEntity
    {
        private int m_ID = 0; //-- ID
        private string m_StudyGroupName = string.Empty; //-- 学习小组名称
        private int m_SubTID = 0; //-- 阶段项目ID
        private int m_CID = 0; //-- 课程ID
        private int m_Status = 0; //-- 状态：1.正常2.关闭
        private int m_CreateBy = 0; //-- 创建人
        private DateTime m_CreateTime ; //-- 发布时间
        private int m_UpdateBy = 0; //-- 更新人
        private DateTime m_UpdateTime ; //-- 更新时间

        public TrainingStudyGroupEntity(){ }
        public TrainingStudyGroupEntity(int ID,string StudyGroupName,int SubTID,int CID,int Status,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime)
        {
            this.ID=ID;
            this.StudyGroupName=StudyGroupName;
            this.SubTID=SubTID;
            this.CID=CID;
            this.Status=Status;
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
        ///学习小组名称
        ///</summary>
        public string StudyGroupName
        {
            set { m_StudyGroupName = value;}
            get { return m_StudyGroupName;}
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
        ///课程ID
        ///</summary>
        public int CID
        {
            set { m_CID = value;}
            get { return m_CID;}
        }

        ///<summary>
        ///状态：1.正常2.关闭
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
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
        ///发布时间
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