using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_AssessmentOptions ( RH_AssessmentOptions ) Entity类
    ///</summary>
    public class AssessmentOptionsEntity
    {
        private int m_ID = 0; //-- 主键
        private int m_QID = 0; //-- 问题id
        private string m_Options = string.Empty; //-- 选项
        private int m_SortNO = 0; //-- 排序
        private int m_Score = 0; //-- 分值  1.1分 2.2分 3.3分

        public AssessmentOptionsEntity(){ }
        public AssessmentOptionsEntity(int ID,int QID,string Options,int SortNO,int Score)
        {
            this.ID=ID;
            this.QID=QID;
            this.Options=Options;
            this.SortNO=SortNO;
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
        ///问题id
        ///</summary>
        public int QID
        {
            set { m_QID = value;}
            get { return m_QID;}
        }

        ///<summary>
        ///选项
        ///</summary>
        public string Options
        {
            set { m_Options = value;}
            get { return m_Options;}
        }

        ///<summary>
        ///排序
        ///</summary>
        public int SortNO
        {
            set { m_SortNO = value;}
            get { return m_SortNO;}
        }

        ///<summary>
        ///分值  1.1分 2.2分 3.3分
        ///</summary>
        public int Score
        {
            set { m_Score = value;}
            get { return m_Score;}
        }

    }
}