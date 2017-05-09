using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingOtherAttachment ( RH_TrainingOtherAttachment ) Entity类
    ///</summary>
    public class TrainingOtherAttachmentEntity
    {
        private int m_ID = 0; //-- ID
        private int m_TOID = 0; //-- 对应RH_TrainingOther表id
        private string m_AttachmentName = string.Empty; //-- AttachmentName
        private string m_AttachmentURL = string.Empty; //-- AttachmentURL
        private int m_CreateBy = 0; //-- CreateBy
        private DateTime m_CreateTime ; //-- CreateTime
        private int m_UpdateBy = 0; //-- UpdateBy
        private DateTime m_UpdateTime ; //-- UpdateTime

        public TrainingOtherAttachmentEntity(){ }
        public TrainingOtherAttachmentEntity(int ID,int TOID,string AttachmentName,string AttachmentURL,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime)
        {
            this.ID=ID;
            this.TOID=TOID;
            this.AttachmentName=AttachmentName;
            this.AttachmentURL=AttachmentURL;
            this.CreateBy=CreateBy;
            this.CreateTime=CreateTime;
            this.UpdateBy=UpdateBy;
            this.UpdateTime=UpdateTime;
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