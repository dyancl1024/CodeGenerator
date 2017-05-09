using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_AssessmentQuestion ( RH_AssessmentQuestion ) Entity类
    ///</summary>
    public class AssessmentQuestionEntity
    {
        private int m_ID = 0; //-- 主键
        private int m_AssessmentID = 0; //-- 测评工具id 对应RH_Assessment表id
        private string m_Question = string.Empty; //-- 题干
        private string m_QuestionDesc = string.Empty; //-- 题干描述
        private int m_TypeID = 0; //-- 题型 对应RH_AssessmentQuestionType表id
        private int m_Dimensions = 0; //-- 课堂维度：1.课堂教学 2.学习方式
        private int m_SortNo = 0; //-- 排序
        private int m_Status = 0; //-- 状态 0.未发布 1.发布

        public AssessmentQuestionEntity(){ }
        public AssessmentQuestionEntity(int ID,int AssessmentID,string Question,string QuestionDesc,int TypeID,int Dimensions,int SortNo,int Status)
        {
            this.ID=ID;
            this.AssessmentID=AssessmentID;
            this.Question=Question;
            this.QuestionDesc=QuestionDesc;
            this.TypeID=TypeID;
            this.Dimensions=Dimensions;
            this.SortNo=SortNo;
            this.Status=Status;
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
        ///测评工具id 对应RH_Assessment表id
        ///</summary>
        public int AssessmentID
        {
            set { m_AssessmentID = value;}
            get { return m_AssessmentID;}
        }

        ///<summary>
        ///题干
        ///</summary>
        public string Question
        {
            set { m_Question = value;}
            get { return m_Question;}
        }

        ///<summary>
        ///题干描述
        ///</summary>
        public string QuestionDesc
        {
            set { m_QuestionDesc = value;}
            get { return m_QuestionDesc;}
        }

        ///<summary>
        ///题型 对应RH_AssessmentQuestionType表id
        ///</summary>
        public int TypeID
        {
            set { m_TypeID = value;}
            get { return m_TypeID;}
        }

        ///<summary>
        ///课堂维度：1.课堂教学 2.学习方式
        ///</summary>
        public int Dimensions
        {
            set { m_Dimensions = value;}
            get { return m_Dimensions;}
        }

        ///<summary>
        ///排序
        ///</summary>
        public int SortNo
        {
            set { m_SortNo = value;}
            get { return m_SortNo;}
        }

        ///<summary>
        ///状态 0.未发布 1.发布
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
        }

    }
}