using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingStudyGroupComment ( RH_TrainingStudyGroupComment ) Entity类
    ///</summary>
    [Serializable]
    public class TrainingStudyGroupCommentEntity
    {
        private int m_ID = 0; 
        private int m_StudyGroupID = 0; 
        private string m_CommentTitile = string.Empty; 
        private string m_Comment = string.Empty; 
        private string m_IPAdress = string.Empty; 
        private int m_ParentID = 0; 
        private int m_IsExpert = 0; 
        private int m_CreateBy = 0; 
        private DateTime m_CreateTime ; 

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