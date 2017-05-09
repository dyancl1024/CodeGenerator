using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_MngMenu ( RH_MngMenu ) Entity类
    ///</summary>
    [Serializable]
    public class MngMenuEntity
    {
        private int m_ID = 0; 
        private string m_MenuName = string.Empty; 
        private string m_MenuUrl = string.Empty; 
        private string m_MenuCode = string.Empty; 
        private int m_MenuLevel = 0; 
        private int m_MenuSort = 0; 
        private int m_Status = 0; 
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
        ///菜单名字
        ///</summary>
        public string MenuName
        {
            set { m_MenuName = value;}
            get { return m_MenuName;}
        }

        ///<summary>
        ///菜单路径
        ///</summary>
        public string MenuUrl
        {
            set { m_MenuUrl = value;}
            get { return m_MenuUrl;}
        }

        ///<summary>
        ///MenuCode
        ///</summary>
        public string MenuCode
        {
            set { m_MenuCode = value;}
            get { return m_MenuCode;}
        }

        ///<summary>
        ///菜单级别
        ///</summary>
        public int MenuLevel
        {
            set { m_MenuLevel = value;}
            get { return m_MenuLevel;}
        }

        ///<summary>
        ///菜单排序
        ///</summary>
        public int MenuSort
        {
            set { m_MenuSort = value;}
            get { return m_MenuSort;}
        }

        ///<summary>
        ///状态：1.正常2.删除
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
        }

        ///<summary>
        ///父级菜单id
        ///</summary>
        public int ParentID
        {
            set { m_ParentID = value;}
            get { return m_ParentID;}
        }

    }
}