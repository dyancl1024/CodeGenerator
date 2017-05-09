using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_MngRoleRight ( RH_MngRoleRight ) Entity类
    ///</summary>
    [Serializable]
    public class MngRoleRightEntity
    {
        private int m_ID = 0; 
        private string m_RoleCode = string.Empty; 
        private string m_MenuCode = string.Empty; 
        private int m_CreateBy = 0; 
        private DateTime m_CreateTime ; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///RoleCode
        ///</summary>
        public string RoleCode
        {
            set { m_RoleCode = value;}
            get { return m_RoleCode;}
        }

        ///<summary>
        ///菜单code  对应RH_MngMenu
        ///</summary>
        public string MenuCode
        {
            set { m_MenuCode = value;}
            get { return m_MenuCode;}
        }

        ///<summary>
        ///创建人
        ///</summary>
        public int CreateBy
        {
            set { m_CreateBy = value;}
            get { return m_CreateBy;}
        }

        ///<summary>
        ///创建时间
        ///</summary>
        public DateTime CreateTime
        {
            set { m_CreateTime = value;}
            get { return m_CreateTime;}
        }

    }
}