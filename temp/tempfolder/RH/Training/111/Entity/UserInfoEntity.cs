using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_UserInfo ( RH_UserInfo ) Entity类
    ///</summary>
    public class UserInfoEntity
    {
        private int m_ID = 0; //-- ID
        private int m_UserID = 0; //-- 人id
        private int m_SchoolID = 0; //-- 学校ID
        private string m_CUserName = string.Empty; //-- 接口用户名
        private string m_CPassword = string.Empty; //-- CPassword
        private int m_CSource = 0; //-- CSource

        public UserInfoEntity(){ }
        public UserInfoEntity(int ID,int UserID,int SchoolID,string CUserName,string CPassword,int CSource)
        {
            this.ID=ID;
            this.UserID=UserID;
            this.SchoolID=SchoolID;
            this.CUserName=CUserName;
            this.CPassword=CPassword;
            this.CSource=CSource;
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
        ///人id
        ///</summary>
        public int UserID
        {
            set { m_UserID = value;}
            get { return m_UserID;}
        }

        ///<summary>
        ///学校ID
        ///</summary>
        public int SchoolID
        {
            set { m_SchoolID = value;}
            get { return m_SchoolID;}
        }

        ///<summary>
        ///接口用户名
        ///</summary>
        public string CUserName
        {
            set { m_CUserName = value;}
            get { return m_CUserName;}
        }

        ///<summary>
        ///CPassword
        ///</summary>
        public string CPassword
        {
            set { m_CPassword = value;}
            get { return m_CPassword;}
        }

        ///<summary>
        ///CSource
        ///</summary>
        public int CSource
        {
            set { m_CSource = value;}
            get { return m_CSource;}
        }

    }
}