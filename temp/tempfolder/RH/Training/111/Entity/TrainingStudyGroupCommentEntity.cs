using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingStudyGroupComment ( RH_TrainingStudyGroupComment ) Entity类
    ///</summary>
    public class TrainingStudyGroupCommentEntity
    {
        private int m_ID = 0; //-- ID
        private int m_StudyGroupID = 0; //-- StudyGroupID
        private string m_CommentTitile = string.Empty; //-- CommentTitile
        private string m_Comment = string.Empty; //-- 评论内容
        private string m_IPAdress = string.Empty; //-- IP地址
        private int m_ParentID = 0; //-- 评论的父级ID
        private int m_IsExpert = 0; //-- 1.专家2.非专家
        private int m_CreateBy = 0; //-- 评论人
        private DateTime m_CreateTime ; //-- 评论时间

        public TrainingStudyGroupCommentEntity(){ }
        public TrainingStudyGroupCommentEntity(int ID,int StudyGroupID,string CommentTitile,string Comment,string IPAdress,int ParentID,int IsExpert,int CreateBy,DateTime CreateTime)
        {
            this.ID=ID;
            this.StudyGroupID=StudyGroupID;
            this.CommentTitile=CommentTitile;
            this.Comment=Comment;
            this.IPAdress=IPAdress;
            this.ParentID=ParentID;
            this.IsExpert=IsExpert;
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
        ///StudyGroupID
        ///</summary>
        public int StudyGroupID
        {
            set { m_StudyGroupID = value;}
            get { return m_StudyGroupID;}
        }

        ///<summary>
        ///CommentTitile
        ///</summary>
        public string CommentTitile
        {
            set { m_CommentTitile = value;}
            get { return m_CommentTitile;}
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
        ///1.专家2.非专家
        ///</summary>
        public int IsExpert
        {
            set { m_IsExpert = value;}
            get { return m_IsExpert;}
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