using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_DesignContentAttachment ( RH_DesignContentAttachment ) Entity类
    ///</summary>
    [Serializable]
    public class DesignContentAttachmentEntity
    {
        private int m_ID = 0; 
        private int m_DesignContentID = 0; 
        private string m_AttachementName = string.Empty; 
        private string m_AttachmentUrl = string.Empty; 
        private string m_Version = string.Empty; 
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
        ///DesignContentID
        ///</summary>
        public int DesignContentID
        {
            set { m_DesignContentID = value;}
            get { return m_DesignContentID;}
        }

        ///<summary>
        ///AttachementName
        ///</summary>
        public string AttachementName
        {
            set { m_AttachementName = value;}
            get { return m_AttachementName;}
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
        ///版本号：附件带版本号（系统自动编号），如：v1.0，2.0，按版本从高到低排序
        ///</summary>
        public string Version
        {
            set { m_Version = value;}
            get { return m_Version;}
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