using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingOtherAttachment ( RH_TrainingOtherAttachment ) Entity类
    ///</summary>
    [Serializable]
    public class TrainingOtherAttachmentEntity
    {
        private int m_ID = 0; 
        private int m_TOID = 0; 
        private string m_AttachmentName = string.Empty; 
        private string m_AttachmentURL = string.Empty; 
        private int m_CreateBy = 0; 
        private DateTime m_CreateTime ; 
        private int m_UpdateBy = 0; 
        private DateTime m_UpdateTime ; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///对应RH_TrainingOther表id
        ///</summary>
        public int TOID
        {
            set { m_TOID = value;}
            get { return m_TOID;}
        }

        ///<summary>
        ///AttachmentName
        ///</summary>
        public string AttachmentName
        {
            set { m_AttachmentName = value;}
            get { return m_AttachmentName;}
        }

        ///<summary>
        ///AttachmentURL
        ///</summary>
        public string AttachmentURL
        {
            set { m_AttachmentURL = value;}
            get { return m_AttachmentURL;}
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

        ///<summary>
        ///UpdateBy
        ///</summary>
        public int UpdateBy
        {
            set { m_UpdateBy = value;}
            get { return m_UpdateBy;}
        }

        ///<summary>
        ///UpdateTime
        ///</summary>
        public DateTime UpdateTime
        {
            set { m_UpdateTime = value;}
            get { return m_UpdateTime;}
        }

    }
}