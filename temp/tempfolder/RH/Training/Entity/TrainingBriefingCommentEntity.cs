using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingBriefingComment ( RH_TrainingBriefingComment ) Entity类
    ///</summary>
    [Serializable]
    public class TrainingBriefingCommentEntity
    {
        private int m_ID = 0; 
        private int m_TBID = 0; 
        private string m_Comment = string.Empty; 
        private string m_IPAdress = string.Empty; 
        private int m_ParentID = 0; 
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