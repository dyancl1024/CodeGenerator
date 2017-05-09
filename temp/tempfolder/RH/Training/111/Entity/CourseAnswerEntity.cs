using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_CourseAnswer ( RH_CourseAnswer ) Entity类
    ///</summary>
    public class CourseAnswerEntity
    {
        private int m_ID = 0; //-- ID
        private int m_QuestionID = 0; //-- QuestionID
        private int m_OptionID = 0; //-- OptionID
        private int m_IsRight = 0; //-- IsRight
        private int m_CreateBy = 0; //-- CreateBy
        private DateTime m_CreateTime ; //-- 创建时间

        public CourseAnswerEntity(){ }
        public CourseAnswerEntity(int ID,int QuestionID,int OptionID,int IsRight,int CreateBy,DateTime CreateTime)
        {
            this.ID=ID;
            this.QuestionID=QuestionID;
            this.OptionID=OptionID;
            this.IsRight=IsRight;
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
        ///QuestionID
        ///</summary>
        public int QuestionID
        {
            set { m_QuestionID = value;}
            get { return m_QuestionID;}
        }

        ///<summary>
        ///OptionID
        ///</summary>
        public int OptionID
        {
            set { m_OptionID = value;}
            get { return m_OptionID;}
        }

        ///<summary>
        ///IsRight
        ///</summary>
        public int IsRight
        {
            set { m_IsRight = value;}
            get { return m_IsRight;}
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
        ///创建时间
        ///</summary>
        public DateTime CreateTime
        {
            set { m_CreateTime = value;}
            get { return m_CreateTime;}
        }

    }
}