using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_MngUser ( RH_MngUser ) Entity类
    ///</summary>
    public class MngUserEntity
    {
        private int m_ID = 0; //-- ID
        private string m_UserName = string.Empty; //-- 用户名
        private string m_Password = string.Empty; //-- Password
        private string m_TrueName = string.Empty; //-- 真实姓名
        private int m_RoleID = 0; //-- 角色id  角色表
        private int m_Status = 0; //-- 状态：1.正常 2.删除
        private int m_CreateBy = 0; //-- 创建人
        private DateTime m_CreateTime ; //-- 创建时间
        private int m_UpdateBy = 0; //-- 更新人
        private DateTime m_UpdateTime ; //-- 更新时间

        public MngUserEntity(){ }
        public MngUserEntity(int ID,string UserName,string Password,string TrueName,int RoleID,int Status,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime)
        {
            this.ID=ID;
            this.UserName=UserName;
            this.Password=Password;
            this.TrueName=TrueName;
            this.RoleID=RoleID;
            this.Status=Status;
            this.CreateBy=CreateBy;
            this.CreateTime=CreateTime;
            this.UpdateBy=UpdateBy;
            this.UpdateTime=UpdateTime;
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