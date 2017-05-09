using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingExpertQAComment ( RH_TrainingExpertQAComment ) Entity类
    ///</summary>
    public class TrainingExpertQACommentEntity
    {
        private int m_ID = 0; //-- ID
        private int m_QAID = 0; //-- QAID
        private string m_Comment = string.Empty; //-- Comment
        private string m_IPAdress = string.Empty; //-- IPAdress
        private int m_ParentID = 0; //-- ParentID
        private int m_IsExpert = 0; //-- 是否专家回答 1.是 2.否
        private int m_CreateBy = 0; //-- CreateBy
        private DateTime m_CreateTime ; //-- CreateTime

        public TrainingExpertQACommentEntity(){ }
        public TrainingExpertQACommentEntity(int ID,int QAID,string Comment,string IPAdress,int ParentID,int IsExpert,int CreateBy,DateTime CreateTime)
        {
            this.ID=ID;
            this.QAID=QAID;
            this.Comment=Comment;
            this.IPAdress=IPAdress;
            this.ParentID=ParentID;
            this.IsExpert=IsExpert;
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