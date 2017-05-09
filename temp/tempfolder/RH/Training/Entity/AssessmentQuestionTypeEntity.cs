using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_AssessmentQuestionType ( RH_AssessmentQuestionType ) Entity类
    ///</summary>
    [Serializable]
    public class AssessmentQuestionTypeEntity
    {
        private int m_ID = 0; 
        private string m_TypeName = string.Empty; 

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