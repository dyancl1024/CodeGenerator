using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_CourseOption ( RH_CourseOption ) Entity类
    ///</summary>
    [Serializable]
    public class CourseOptionEntity
    {
        private int m_ID = 0; 
        private int m_QuestionID = 0; 
        private string m_QOption = string.Empty; 
        private int m_Sort = 0; 
        private int m_IsRight = 0; 

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
        ///QOption
        ///</summary>
        public string QOption
        {
            set { m_QOption = value;}
            get { return m_QOption;}
        }

        ///<summary>
        ///Sort
        ///</summary>
        public int Sort
        {
            set { m_Sort = value;}
            get { return m_Sort;}
        }

        ///<summary>
        ///是否标准答案1是2否
        ///</summary>
        public int IsRight
        {
            set { m_IsRight = value;}
            get { return m_IsRight;}
        }

    }
}