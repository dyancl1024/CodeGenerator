using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_CourseAttachment ( RH_CourseAttachment ) Entity类
    ///</summary>
    public class CourseAttachmentEntity
    {
        private int m_ID = 0; //-- ID
        private int m_CourseID = 0; //-- CourseID
        private string m_AttachmentName = string.Empty; //-- AttachmentName
        private string m_AttachmentUrl = string.Empty; //-- AttachmentUrl
        private int m_AttachmentType = 0; //-- AttachmentType
        private int m_CreateBy = 0; //-- CreateBy
        private DateTime m_CreateTime ; //-- CreateTime

        public CourseAttachmentEntity(){ }
        public CourseAttachmentEntity(int ID,int CourseID,string AttachmentName,string AttachmentUrl,int AttachmentType,int CreateBy,DateTime CreateTime)
        {
            this.ID=ID;
            this.CourseID=CourseID;
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
        ///CourseID
        ///</summary>
        public int CourseID
        {
            set { m_CourseID = value;}
            get { return m_CourseID;}
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