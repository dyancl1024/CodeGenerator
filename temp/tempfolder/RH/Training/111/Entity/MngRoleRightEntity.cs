using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_MngRoleRight ( RH_MngRoleRight ) Entity类
    ///</summary>
    public class MngRoleRightEntity
    {
        private int m_ID = 0; //-- ID
        private string m_RoleCode = string.Empty; //-- RoleCode
        private string m_MenuCode = string.Empty; //-- 菜单code  对应RH_MngMenu
        private int m_CreateBy = 0; //-- 创建人
        private DateTime m_CreateTime ; //-- 创建时间

        public MngRoleRightEntity(){ }
        public MngRoleRightEntity(int ID,string RoleCode,string MenuCode,int CreateBy,DateTime CreateTime)
        {
            this.ID=ID;
            this.RoleCode=RoleCode;
            this.MenuCode=MenuCode;
            this.CreateBy=CreateBy;
            this.CreateTime=CreateTime;
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