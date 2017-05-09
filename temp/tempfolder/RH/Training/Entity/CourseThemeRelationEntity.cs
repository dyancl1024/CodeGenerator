using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_CourseThemeRelation ( RH_CourseThemeRelation ) Entity类
    ///</summary>
    [Serializable]
    public class CourseThemeRelationEntity
    {
        private int m_ID = 0; 
        private int m_CourseID = 0; 
        private string m_CourseThemeCode = string.Empty; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///课程id
        ///</summary>
        public int CourseID
        {
            set { m_CourseID = value;}
            get { return m_CourseID;}
        }

        ///<summary>
        ///能力提升课程代码
        ///</summary>
        public string CourseThemeCode
        {
            set { m_CourseThemeCode = value;}
            get { return m_CourseThemeCode;}
        }

    }
}