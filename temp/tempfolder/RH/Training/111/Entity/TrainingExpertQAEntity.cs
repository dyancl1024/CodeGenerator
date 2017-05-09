using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingExpertQA ( RH_TrainingExpertQA ) Entity类
    ///</summary>
    public class TrainingExpertQAEntity
    {
        private int m_ID = 0; //-- ID
        private int m_TID = 0; //-- 项目id
        private string m_QATitle = string.Empty; //-- 答疑标题
        private string m_QAContent = string.Empty; //-- 答疑内容
        private int m_ClickNum = 0; //-- 点击率
        private int m_CreateBy = 0; //-- 创建人
        private DateTime m_CreateTime ; //-- 创建时间
        private int m_UpdateBy = 0; //-- 更新人
        private DateTime m_UpdateTime ; //-- 更新时间

        public TrainingExpertQAEntity(){ }
        public TrainingExpertQAEntity(int ID,int TID,string QATitle,string QAContent,int ClickNum,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime)
        {
            this.ID=ID;
            this.TID=TID;
            this.QATitle=QATitle;
            this.QAContent=QAContent;
            this.ClickNum=ClickNum;
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
        ///项目id
        ///</summary>
        public int TID
        {
            set { m_TID = value;}
            get { return m_TID;}
        }

        ///<summary>
        ///答疑标题
        ///</summary>
        public string QATitle
        {
            set { m_QATitle = value;}
            get { return m_QATitle;}
        }

        ///<summary>
        ///答疑内容
        ///</summary>
        public string QAContent
        {
            set { m_QAContent = value;}
            get { return m_QAContent;}
        }

        ///<summary>
        ///点击率
        ///</summary>
        public int ClickNum
        {
            set { m_ClickNum = value;}
            get { return m_ClickNum;}
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