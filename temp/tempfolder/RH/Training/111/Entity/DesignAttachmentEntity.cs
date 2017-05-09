using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_DesignAttachment ( RH_DesignAttachment ) Entity类
    ///</summary>
    public class DesignAttachmentEntity
    {
        private int m_ID = 0; //-- ID
        private int m_DesignID = 0; //-- DesignID
        private string m_AttachmentName = string.Empty; //-- AttachmentName
        private string m_AttachmentUrl = string.Empty; //-- AttachmentUrl
        private int m_AttachmentType = 0; //-- AttachmentType
        private int m_CreateBy = 0; //-- CreateBy
        private DateTime m_CreateTime ; //-- CreateTime

        public DesignAttachmentEntity(){ }
        public DesignAttachmentEntity(int ID,int DesignID,string AttachmentName,string AttachmentUrl,int AttachmentType,int CreateBy,DateTime CreateTime)
        {
            this.ID=ID;
            this.DesignID=DesignID;
            this.AttachmentName=AttachmentName;
            this.AttachmentUrl=AttachmentUrl;
            this.AttachmentType=AttachmentType;
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