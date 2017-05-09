using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_CourseTheme ( RH_CourseTheme ) Entity类
    ///</summary>
    [Serializable]
    public class CourseThemeEntity
    {
        private int m_ID = 0; 
        private string m_Name = string.Empty; 
        private string m_Code = string.Empty; 
        private int m_Sort = 0; 
        private int m_Type = 0; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///Name
        ///</summary>
        public string Name
        {
            set { m_Name = value;}
            get { return m_Name;}
        }

        ///<summary>
        ///Code
        ///</summary>
        public string Code
        {
            set { m_Code = value;}
            get { return m_Code;}
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
        ///1.应用信息技术优化课堂教学  2.应用信息技术转变学习方式
        ///</summary>
        public int Type
        {
            set { m_Type = value;}
            get { return m_Type;}
        }

    }
}