using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_AssessmentAnswer ( RH_AssessmentAnswer ) Entity类
    ///</summary>
    public class AssessmentAnswerEntity
    {
        private int m_ID = 0; //-- 主键
        private int m_SubTID = 0; //-- 项目id
        private int m_UserID = 0; //-- 用户id
        private int m_QID = 0; //-- 问题id
        private int m_QType = 0; //-- 问题类型  RH_AssessmentQuestionType表id
        private int m_OptionID = 0; //-- 选项id  RH_AssessmentOptions表id
        private int m_Score = 0; //-- 得分

        public AssessmentAnswerEntity(){ }
        public AssessmentAnswerEntity(int ID,int SubTID,int UserID,int QID,int QType,int OptionID,int Score)
        {
            this.ID=ID;
            this.SubTID=SubTID;
            this.UserID=UserID;
            this.QID=QID;
            this.QType=QType;
            this.OptionID=OptionID;
            this.Score=Score;
        }

        ///<summary>
        ///主键
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///项目id
        ///</summary>
        public int SubTID
        {
            set { m_SubTID = value;}
            get { return m_SubTID;}
        }

        ///<summary>
        ///用户id
        ///</summary>
        public int UserID
        {
            set { m_UserID = value;}
            get { return m_UserID;}
        }

        ///<summary>
        ///问题id
        ///</summary>
        public int QID
        {
            set { m_QID = value;}
            get { return m_QID;}
        }

        ///<summary>
        ///问题类型  RH_AssessmentQuestionType表id
        ///</summary>
        public int QType
        {
            set { m_QType = value;}
            get { return m_QType;}
        }

        ///<summary>
        ///选项id  RH_AssessmentOptions表id
        ///</summary>
        public int OptionID
        {
            set { m_OptionID = value;}
            get { return m_OptionID;}
        }

        ///<summary>
        ///得分
        ///</summary>
        public int Score
        {
            set { m_Score = value;}
            get { return m_Score;}
        }

    }
}