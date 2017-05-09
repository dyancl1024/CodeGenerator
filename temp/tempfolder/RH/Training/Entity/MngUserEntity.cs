using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_MngUser ( RH_MngUser ) Entity类
    ///</summary>
    [Serializable]
    public class MngUserEntity
    {
        private int m_ID = 0; 
        private string m_UserName = string.Empty; 
        private string m_Password = string.Empty; 
        private string m_TrueName = string.Empty; 
        private int m_RoleID = 0; 
        private int m_Status = 0; 
        private int m_CreateBy = 0; 
        private DateTime m_CreateTime ; 
        private int m_UpdateBy = 0; 
        private DateTime m_UpdateTime ; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///用户名
        ///</summary>
        public string UserName
        {
            set { m_UserName = value;}
            get { return m_UserName;}
        }

        ///<summary>
        ///Password
        ///</summary>
        public string Password
        {
            set { m_Password = value;}
            get { return m_Password;}
        }

        ///<summary>
        ///真实姓名
        ///</summary>
        public string TrueName
        {
            set { m_TrueName = value;}
            get { return m_TrueName;}
        }

        ///<summary>
        ///角色id  角色表
        ///</summary>
        public int RoleID
        {
            set { m_RoleID = value;}
            get { return m_RoleID;}
        }

        ///<summary>
        ///状态：1.正常 2.删除
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
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

        ///<summary>
        ///更新人
        ///</summary>
        public int UpdateBy
        {
            set { m_UpdateBy = value;}
            get { return m_UpdateBy;}
        }

        ///<summary>
        ///更新时间
        ///</summary>
        public DateTime UpdateTime
        {
            set { m_UpdateTime = value;}
            get { return m_UpdateTime;}
        }

    }
}