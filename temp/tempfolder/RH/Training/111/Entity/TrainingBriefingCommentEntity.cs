using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingBriefingComment ( RH_TrainingBriefingComment ) Entity类
    ///</summary>
    public class TrainingBriefingCommentEntity
    {
        private int m_ID = 0; //-- ID
        private int m_TBID = 0; //-- 项目简报ID 对应RH_TrainingBriefing
        private string m_Comment = string.Empty; //-- 评论内容
        private string m_IPAdress = string.Empty; //-- IP地址
        private int m_ParentID = 0; //-- 评论的父级ID
        private int m_CreateBy = 0; //-- 评论人
        private DateTime m_CreateTime ; //-- 评论时间

        public TrainingBriefingCommentEntity(){ }
        public TrainingBriefingCommentEntity(int ID,int TBID,string Comment,string IPAdress,int ParentID,int CreateBy,DateTime CreateTime)
        {
            this.ID=ID;
            this.TBID=TBID;
            this.Comment=Comment;
            this.IPAdress=IPAdress;
            this.ParentID=ParentID;
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
        ///项目简报ID 对应RH_TrainingBriefing
        ///</summary>
        public int TBID
        {
            set { m_TBID = value;}
            get { return m_TBID;}
        }

        ///<summary>
        ///评论内容
        ///</summary>
        public string Comment
        {
            set { m_Comment = value;}
            get { return m_Comment;}
        }

        ///<summary>
        ///IP地址
        ///</summary>
        public string IPAdress
        {
            set { m_IPAdress = value;}
            get { return m_IPAdress;}
        }

        ///<summary>
        ///评论的父级ID
        ///</summary>
        public int ParentID
        {
            set { m_ParentID = value;}
            get { return m_ParentID;}
        }

        ///<summary>
        ///评论人
        ///</summary>
        public int CreateBy
        {
            set { m_CreateBy = value;}
            get { return m_CreateBy;}
        }

        ///<summary>
        ///评论时间
        ///</summary>
        public DateTime CreateTime
        {
            set { m_CreateTime = value;}
            get { return m_CreateTime;}
        }

    }
}