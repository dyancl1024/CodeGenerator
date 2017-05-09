using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_AssessmentQuestionType ( RH_AssessmentQuestionType ) Entity类
    ///</summary>
    public class AssessmentQuestionTypeEntity
    {
        private int m_ID = 0; //-- 主键
        private string m_TypeName = string.Empty; //-- 问题类型

        public AssessmentQuestionTypeEntity(){ }
        public AssessmentQuestionTypeEntity(int ID,string TypeName)
        {
            this.ID=ID;
            this.TypeName=TypeName;
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
        ///问题类型
        ///</summary>
        public string TypeName
        {
            set { m_TypeName = value;}
            get { return m_TypeName;}
        }

    }
}