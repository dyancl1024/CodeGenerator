using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingBriefing ( RH_TrainingBriefing ) Entity类
    ///</summary>
    public class TrainingBriefingEntity
    {
        private int m_ID = 0; //-- ID
        private int m_ObjectID = 0; //-- 项目id
        private int m_MType = 0; //-- 1.项目 2.班级
        private string m_Periods = string.Empty; //-- 期数 录入
        private string m_Title = string.Empty; //-- 标题
        private string m_BContnet = string.Empty; //-- 内容
        private int m_ClickNum = 0; //-- ClickNum
        private int m_CreateBy = 0; //-- 创建人
        private DateTime m_CreateTime ; //-- 发布时间
        private int m_UpdateBy = 0; //-- 更新人
        private DateTime m_UpdateTime ; //-- 更新时间
        private string m_StaticUrl = string.Empty; //-- StaticUrl

        public TrainingBriefingEntity(){ }
        public TrainingBriefingEntity(int ID,int ObjectID,int MType,string Periods,string Title,string BContnet,int ClickNum,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime,string StaticUrl)
        {
            this.ID=ID;
            this.ObjectID=ObjectID;
            this.MType=MType;
            this.Periods=Periods;
            this.Title=Title;
            this.BContnet=BContnet;
            this.ClickNum=ClickNum;
            this.CreateBy=CreateBy;
            this.CreateTime=CreateTime;
            this.UpdateBy=UpdateBy;
            this.UpdateTime=UpdateTime;
            this.StaticUrl=StaticUrl;
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
        public int ObjectID
        {
            set { m_ObjectID = value;}
            get { return m_ObjectID;}
        }

        ///<summary>
        ///1.项目 2.班级
        ///</summary>
        public int MType
        {
            set { m_MType = value;}
            get { return m_MType;}
        }

        ///<summary>
        ///期数 录入
        ///</summary>
        public string Periods
        {
            set { m_Periods = value;}
            get { return m_Periods;}
        }

        ///<summary>
        ///标题
        ///</summary>
        public string Title
        {
            set { m_Title = value;}
            get { return m_Title;}
        }

        ///<summary>
        ///内容
        ///</summary>
        public string BContnet
        {
            set { m_BContnet = value;}
            get { return m_BContnet;}
        }

        ///<summary>
        ///ClickNum
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

        ///<summary>
        ///StaticUrl
        ///</summary>
        public string StaticUrl
        {
            set { m_StaticUrl = value;}
            get { return m_StaticUrl;}
        }

    }
}