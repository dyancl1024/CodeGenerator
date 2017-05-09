using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Grade ( RH_Grade ) Entity类
    ///</summary>
    [Serializable]
    public class GradeEntity
    {
        private int m_ID = 0; 
        private string m_Name = string.Empty; 
        private string m_Code = string.Empty; 
        private int m_Sort = 0; 
        private int m_ParentID = 0; 

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
        ///0：大学段（如：小学） ，&lt;&gt;0:小学段（如小学1-6年级）
        ///</summary>
        public int ParentID
        {
            set { m_ParentID = value;}
            get { return m_ParentID;}
        }

    }
}