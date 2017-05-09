using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_CourseOption ( RH_CourseOption ) Entity类
    ///</summary>
    public class CourseOptionEntity
    {
        private int m_ID = 0; //-- ID
        private int m_QuestionID = 0; //-- QuestionID
        private string m_QOption = string.Empty; //-- QOption
        private int m_Sort = 0; //-- Sort
        private int m_IsRight = 0; //-- 是否标准答案1是2否

        public CourseOptionEntity(){ }
        public CourseOptionEntity(int ID,int QuestionID,string QOption,int Sort,int IsRight)
        {
            this.ID=ID;
            this.QuestionID=QuestionID;
            this.QOption=QOption;
            this.Sort=Sort;
            this.IsRight=IsRight;
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