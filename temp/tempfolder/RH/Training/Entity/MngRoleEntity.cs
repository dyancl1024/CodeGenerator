using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_MngRole ( RH_MngRole ) Entity类
    ///</summary>
    [Serializable]
    public class MngRoleEntity
    {
        private int m_ID = 0; 
        private string m_RoleName = string.Empty; 
        private string m_RoleCode = string.Empty; 
        private int m_SortNum = 0; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///角色名称
        ///</summary>
        public string RoleName
        {
            set { m_RoleName = value;}
            get { return m_RoleName;}
        }

        ///<summary>
        ///角色代码
        ///</summary>
        public string RoleCode
        {
            set { m_RoleCode = value;}
            get { return m_RoleCode;}
        }

        ///<summary>
        ///角色排序
        ///</summary>
        public int SortNum
        {
            set { m_SortNum = value;}
            get { return m_SortNum;}
        }

    }
}