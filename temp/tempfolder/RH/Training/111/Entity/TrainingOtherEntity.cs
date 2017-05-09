using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingOther ( RH_TrainingOther ) Entity类
    ///</summary>
    public class TrainingOtherEntity
    {
        private int m_ID = 0; //-- ID
        private int m_TID = 0; //-- TID
        private int m_SubTID = 0; //-- SubTID
        private string m_TTitle = string.Empty; //-- TTitle
        private int m_TType = 0; //-- 项目附属信息  1.项目考核方案 2.学员手册 3.辅导老师手册 4.项目实施方案
        private string m_TContent = string.Empty; //-- TContent
        private int m_CreateBy = 0; //-- 创建人
        private DateTime m_CreateTime ; //-- 创建时间
        private int m_UpdateBy = 0; //-- 更新人
        private DateTime m_UpdateTime ; //-- 更新时间

        public TrainingOtherEntity(){ }
        public TrainingOtherEntity(int ID,int TID,int SubTID,string TTitle,int TType,string TContent,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime)
        {
            this.ID=ID;
            this.TID=TID;
            this.SubTID=SubTID;
            this.TTitle=TTitle;
            this.TType=TType;
            this.TContent=TContent;
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
        ///TTitle
        ///</summary>
        public string TTitle
        {
            set { m_TTitle = value;}
            get { return m_TTitle;}
        }

        ///<summary>
        ///项目附属信息  1.项目考核方案 2.学员手册 3.辅导老师手册 4.项目实施方案
        ///</summary>
        public int TType
        {
            set { m_TType = value;}
            get { return m_TType;}
        }

        ///<summary>
        ///TContent
        ///</summary>
        public string TContent
        {
            set { m_TContent = value;}
            get { return m_TContent;}
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