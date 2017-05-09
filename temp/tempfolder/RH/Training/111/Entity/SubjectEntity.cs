using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Subject ( RH_Subject ) Entity类
    ///</summary>
    public class SubjectEntity
    {
        private int m_ID = 0; //-- ID
        private string m_SubjectName = string.Empty; //-- SubjectName
        private string m_SubCode = string.Empty; //-- SubCode
        private string m_SubjectSort = string.Empty; //-- SubjectSort

        public SubjectEntity(){ }
        public SubjectEntity(int ID,string SubjectName,string SubCode,string SubjectSort)
        {
            this.ID=ID;
            this.SubjectName=SubjectName;
            this.SubCode=SubCode;
            this.SubjectSort=SubjectSort;
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
        ///SubjectName
        ///</summary>
        public string SubjectName
        {
            set { m_SubjectName = value;}
            get { return m_SubjectName;}
        }

        ///<summary>
        ///SubCode
        ///</summary>
        public string SubCode
        {
            set { m_SubCode = value;}
            get { return m_SubCode;}
        }

        ///<summary>
        ///SubjectSort
        ///</summary>
        public string SubjectSort
        {
            set { m_SubjectSort = value;}
            get { return m_SubjectSort;}
        }

    }
}