using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingHomeWorkAttachment ( RH_TrainingHomeWorkAttachment ) Entity类
    ///</summary>
    public class TrainingHomeWorkAttachmentEntity
    {
        private int m_ID = 0; //-- ID
        private int m_HomeWorkID = 0; //-- HomeWorkID
        private string m_AttachmentName = string.Empty; //-- AttachmentName
        private string m_AttachmentUrl = string.Empty; //-- AttachmentUrl
        private int m_AttachmentType = 0; //-- 1-文本 2-视频 3-图片 4-音频
        private int m_CreateBy = 0; //-- CreateBy
        private DateTime m_CreateTime ; //-- CreateTime

        public TrainingHomeWorkAttachmentEntity(){ }
        public TrainingHomeWorkAttachmentEntity(int ID,int HomeWorkID,string AttachmentName,string AttachmentUrl,int AttachmentType,int CreateBy,DateTime CreateTime)
        {
            this.ID=ID;
            this.HomeWorkID=HomeWorkID;
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
        ///HomeWorkID
        ///</summary>
        public int HomeWorkID
        {
            set { m_HomeWorkID = value;}
            get { return m_HomeWorkID;}
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
        ///1-文本 2-视频 3-图片 4-音频
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