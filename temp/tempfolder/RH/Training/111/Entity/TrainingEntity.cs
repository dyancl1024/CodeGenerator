using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Training ( RH_Training ) Entity类
    ///</summary>
    public class TrainingEntity
    {
        private int m_ID = 0; //-- ID
        private int m_DesignID = 0; //-- 社区id
        private string m_TName = string.Empty; //-- 项目名称
        private int m_TrainingPhase = 0; //-- 学时
        private int m_TrainingNum = 0; //-- 项目名称
        private string m_TrainingLevelCode = string.Empty; //-- 承担机构id 对应表FJ_TrainingOrg的ID
        private string m_TrainingTypeCode = string.Empty; //-- TrainingTypeCode
        private int m_ProvinceID = 0; //-- ProvinceID
        private int m_CityID = 0; //-- CityID
        private int m_DistrictID = 0; //-- DistrictID
        private DateTime m_TrainingDateB ; //-- 时间安排起
        private DateTime m_TrainingDateE ; //-- 时间安排止
        private int m_IsStage = 0; //-- 是否阶段项目 1 是 2 否
        private string m_TrainingUrl = string.Empty; //-- TrainingUrl
        private string m_TrainingCode = string.Empty; //-- 项目编码
        private string m_TrainingHeadImg = string.Empty; //-- TrainingHeadImg
        private string m_StaticUrl = string.Empty; //-- StaticUrl
        private int m_Status = 0; //-- 1.待实施(对应动作填写实施方案) 2.待配课（对应动作申请配课） 3.配课中（对应动作配课完成） 4.待发布（对应动作发布） 5.已发布 6.删除
        private int m_CreateBy = 0; //-- 创建人
        private DateTime m_CreateTime ; //-- 创建时间
        private int m_UpdateBy = 0; //-- 更新人
        private DateTime m_UpdateTime ; //-- 更新时间
        private int m_Publisher = 0; //-- 发布人
        private DateTime m_PublishDate ; //-- 发布时间

        public TrainingEntity(){ }
        public TrainingEntity(int ID,int DesignID,string TName,int TrainingPhase,int TrainingNum,string TrainingLevelCode,string TrainingTypeCode,int ProvinceID,int CityID,int DistrictID,DateTime TrainingDateB,DateTime TrainingDateE,int IsStage,string TrainingUrl,string TrainingCode,string TrainingHeadImg,string StaticUrl,int Status,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime,int Publisher,DateTime PublishDate)
        {
            this.ID=ID;
            this.DesignID=DesignID;
            this.TName=TName;
            this.TrainingPhase=TrainingPhase;
            this.TrainingNum=TrainingNum;
            this.TrainingLevelCode=TrainingLevelCode;
            this.TrainingTypeCode=TrainingTypeCode;
            this.ProvinceID=ProvinceID;
            this.CityID=CityID;
            this.DistrictID=DistrictID;
            this.TrainingDateB=TrainingDateB;
            this.TrainingDateE=TrainingDateE;
            this.IsStage=IsStage;
            this.TrainingUrl=TrainingUrl;
            this.TrainingCode=TrainingCode;
            this.TrainingHeadImg=TrainingHeadImg;
            this.StaticUrl=StaticUrl;
            this.Status=Status;
            this.CreateBy=CreateBy;
            this.CreateTime=CreateTime;
            this.UpdateBy=UpdateBy;
            this.UpdateTime=UpdateTime;
            this.Publisher=Publisher;
            this.PublishDate=PublishDate;
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
        ///社区id
        ///</summary>
        public int DesignID
        {
            set { m_DesignID = value;}
            get { return m_DesignID;}
        }

        ///<summary>
        ///项目名称
        ///</summary>
        public string TName
        {
            set { m_TName = value;}
            get { return m_TName;}
        }

        ///<summary>
        ///学时
        ///</summary>
        public int TrainingPhase
        {
            set { m_TrainingPhase = value;}
            get { return m_TrainingPhase;}
        }

        ///<summary>
        ///项目名称
        ///</summary>
        public int TrainingNum
        {
            set { m_TrainingNum = value;}
            get { return m_TrainingNum;}
        }

        ///<summary>
        ///承担机构id 对应表FJ_TrainingOrg的ID
        ///</summary>
        public string TrainingLevelCode
        {
            set { m_TrainingLevelCode = value;}
            get { return m_TrainingLevelCode;}
        }

        ///<summary>
        ///TrainingTypeCode
        ///</summary>
        public string TrainingTypeCode
        {
            set { m_TrainingTypeCode = value;}
            get { return m_TrainingTypeCode;}
        }

        ///<summary>
        ///ProvinceID
        ///</summary>
        public int ProvinceID
        {
            set { m_ProvinceID = value;}
            get { return m_ProvinceID;}
        }

        ///<summary>
        ///CityID
        ///</summary>
        public int CityID
        {
            set { m_CityID = value;}
            get { return m_CityID;}
        }

        ///<summary>
        ///DistrictID
        ///</summary>
        public int DistrictID
        {
            set { m_DistrictID = value;}
            get { return m_DistrictID;}
        }

        ///<summary>
        ///时间安排起
        ///</summary>
        public DateTime TrainingDateB
        {
            set { m_TrainingDateB = value;}
            get { return m_TrainingDateB;}
        }

        ///<summary>
        ///时间安排止
        ///</summary>
        public DateTime TrainingDateE
        {
            set { m_TrainingDateE = value;}
            get { return m_TrainingDateE;}
        }

        ///<summary>
        ///是否阶段项目 1 是 2 否
        ///</summary>
        public int IsStage
        {
            set { m_IsStage = value;}
            get { return m_IsStage;}
        }

        ///<summary>
        ///TrainingUrl
        ///</summary>
        public string TrainingUrl
        {
            set { m_TrainingUrl = value;}
            get { return m_TrainingUrl;}
        }

        ///<summary>
        ///项目编码
        ///</summary>
        public string TrainingCode
        {
            set { m_TrainingCode = value;}
            get { return m_TrainingCode;}
        }

        ///<summary>
        ///TrainingHeadImg
        ///</summary>
        public string TrainingHeadImg
        {
            set { m_TrainingHeadImg = value;}
            get { return m_TrainingHeadImg;}
        }

        ///<summary>
        ///StaticUrl
        ///</summary>
        public string StaticUrl
        {
            set { m_StaticUrl = value;}
            get { return m_StaticUrl;}
        }

        ///<summary>
        ///1.待实施(对应动作填写实施方案) 2.待配课（对应动作申请配课） 3.配课中（对应动作配课完成） 4.待发布（对应动作发布） 5.已发布 6.删除
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

        ///<summary>
        ///发布人
        ///</summary>
        public int Publisher
        {
            set { m_Publisher = value;}
            get { return m_Publisher;}
        }

        ///<summary>
        ///发布时间
        ///</summary>
        public DateTime PublishDate
        {
            set { m_PublishDate = value;}
            get { return m_PublishDate;}
        }

    }
}