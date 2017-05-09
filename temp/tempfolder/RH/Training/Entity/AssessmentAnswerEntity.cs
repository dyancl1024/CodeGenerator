using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_AssessmentAnswer ( RH_AssessmentAnswer ) Entity类
    ///</summary>
    [Serializable]
    public class AssessmentAnswerEntity
    {
        private int m_ID = 0; 
        private int m_SubTID = 0; 
        private int m_UserID = 0; 
        private int m_QID = 0; 
        private int m_QType = 0; 
        private int m_OptionID = 0; 
        private int m_Score = 0; 

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