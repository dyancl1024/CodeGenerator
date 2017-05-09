using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_CourseLevelRelation ( RH_CourseLevelRelation ) Entity类
    ///</summary>
    [Serializable]
    public class CourseLevelRelationEntity
    {
        private int m_ID = 0; 
        private int m_CourseID = 0; 
        private int m_CourseLevel = 0; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///CourseID
        ///</summary>
        public int CourseID
        {
            set { m_CourseID = value;}
            get { return m_CourseID;}
        }

        ///<summary>
        ///1初级2中级3高级
        ///</summary>
        public int CourseLevel
        {
            set { m_CourseLevel = value;}
            get { return m_CourseLevel;}
        }

    }
}