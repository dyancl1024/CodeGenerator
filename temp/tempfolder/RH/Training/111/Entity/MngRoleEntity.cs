using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_MngRole ( RH_MngRole ) Entity类
    ///</summary>
    public class MngRoleEntity
    {
        private int m_ID = 0; //-- ID
        private string m_RoleName = string.Empty; //-- 角色名称
        private string m_RoleCode = string.Empty; //-- 角色代码
        private int m_SortNum = 0; //-- 角色排序

        public MngRoleEntity(){ }
        public MngRoleEntity(int ID,string RoleName,string RoleCode,int SortNum)
        {
            this.ID=ID;
            this.RoleName=RoleName;
            this.RoleCode=RoleCode;
            this.SortNum=SortNum;
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