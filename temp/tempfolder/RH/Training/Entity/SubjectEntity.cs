using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Subject ( RH_Subject ) Entity类
    ///</summary>
    [Serializable]
    public class SubjectEntity
    {
        private int m_ID = 0; 
        private string m_SubjectName = string.Empty; 
        private string m_SubCode = string.Empty; 
        private string m_SubjectSort = string.Empty; 

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