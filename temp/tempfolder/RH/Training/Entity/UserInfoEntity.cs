using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_UserInfo ( RH_UserInfo ) Entity类
    ///</summary>
    [Serializable]
    public class UserInfoEntity
    {
        private int m_ID = 0; 
        private int m_UserID = 0; 
        private int m_SchoolID = 0; 
        private string m_CUserName = string.Empty; 
        private string m_CPassword = string.Empty; 
        private int m_CSource = 0; 

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