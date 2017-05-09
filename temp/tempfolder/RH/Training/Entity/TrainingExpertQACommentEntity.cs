using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingExpertQAComment ( RH_TrainingExpertQAComment ) Entity类
    ///</summary>
    [Serializable]
    public class TrainingExpertQACommentEntity
    {
        private int m_ID = 0; 
        private int m_QAID = 0; 
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
        ///QAID
        ///</summary>
        public int QAID
        {
            set { m_QAID = value;}
            get { return m_QAID;}
        }

        ///<summary>
        ///Comment
        ///</summary>
        public string Comment
        {
            set { m_Comment = value;}
            get { return m_Comment;}
        }

        ///<summary>
        ///IPAdress
        ///</summary>
        public string IPAdress
        {
            set { m_IPAdress = value;}
            get { return m_IPAdress;}
        }

        ///<summary>
        ///ParentID
        ///</summary>
        public int ParentID
        {
            set { m_ParentID = value;}
            get { return m_ParentID;}
        }

        ///<summary>
        ///是否专家回答 1.是 2.否
        ///</summary>
        public int IsExpert
        {
            set { m_IsExpert = value;}
            get { return m_IsExpert;}
        }

        ///<summary>
        ///CreateBy
        ///</summary>
        public int CreateBy
        {
            set { m_CreateBy = value;}
            get { return m_CreateBy;}
        }

        ///<summary>
        ///CreateTime
        ///</summary>
        public DateTime CreateTime
        {
            set { m_CreateTime = value;}
            get { return m_CreateTime;}
        }

    }
}