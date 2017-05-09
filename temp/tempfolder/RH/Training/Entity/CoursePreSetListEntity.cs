using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_CoursePreSetList ( RH_CoursePreSetList ) Entity类
    ///</summary>
    [Serializable]
    public class CoursePreSetListEntity
    {
        private int m_ID = 0; 
        private int m_PreSetID = 0; 
        private int m_CourseID = 0; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///PreSetID
        ///</summary>
        public int PreSetID
        {
            set { m_PreSetID = value;}
            get { return m_PreSetID;}
        }

        ///<summary>
        ///CourseID
        ///</summary>
        public int CourseID
        {
            set { m_CourseID = value;}
            get { return m_CourseID;}
        }

    }
}