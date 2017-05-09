using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_DesignAttachment ( RH_DesignAttachment ) Entity类
    ///</summary>
    [Serializable]
    public class DesignAttachmentEntity
    {
        private int m_ID = 0; 
        private int m_DesignID = 0; 
        private string m_AttachmentName = string.Empty; 
        private string m_AttachmentUrl = string.Empty; 
        private int m_AttachmentType = 0; 
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
        ///DesignID
        ///</summary>
        public int DesignID
        {
            set { m_DesignID = value;}
            get { return m_DesignID;}
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
        ///AttachmentUrl
        ///</summary>
        public string AttachmentUrl
        {
            set { m_AttachmentUrl = value;}
            get { return m_AttachmentUrl;}
        }

        ///<summary>
        ///AttachmentType
        ///</summary>
        public int AttachmentType
        {
            set { m_AttachmentType = value;}
            get { return m_AttachmentType;}
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