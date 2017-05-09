using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_User ( RH_User ) Entity类
    ///</summary>
    [Serializable]
    public class UserEntity
    {
        private int m_id = 0; 
        private string m_UserName = string.Empty; 
        private string m_Password = string.Empty; 
        private string m_TrueName = string.Empty; 
        private string m_Gender = string.Empty; 
        private string m_PicUrl = string.Empty; 
        private int m_Nation = 0; 
        private string m_IDNO = string.Empty; 
        private int m_ProvinceID = 0; 
        private int m_CityID = 0; 
        private int m_DistrictID = 0; 
        private string m_Mobile = string.Empty; 
        private string m_Email = string.Empty; 
        private string m_QQ = string.Empty; 
        private string m_IPAddr = string.Empty; 
        private int m_IsChange = 0; 
        private int m_UserState = 0; 
        private int m_CreateBy = 0; 
        private DateTime m_CreateTime ; 
        private int m_UpdateBy = 0; 
        private DateTime m_UpdateTime ; 

        ///<summary>
        ///id
        ///</summary>
        public int id
        {
            set { m_id = value;}
            get { return m_id;}
        }

        ///<summary>
        ///UserName
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
        ///TrueName
        ///</summary>
        public string TrueName
        {
            set { m_TrueName = value;}
            get { return m_TrueName;}
        }

        ///<summary>
        ///Gender
        ///</summary>
        public string Gender
        {
            set { m_Gender = value;}
            get { return m_Gender;}
        }

        ///<summary>
        ///PicUrl
        ///</summary>
        public string PicUrl
        {
            set { m_PicUrl = value;}
            get { return m_PicUrl;}
        }

        ///<summary>
        ///Nation
        ///</summary>
        public int Nation
        {
            set { m_Nation = value;}
            get { return m_Nation;}
        }

        ///<summary>
        ///IDNO
        ///</summary>
        public string IDNO
        {
            set { m_IDNO = value;}
            get { return m_IDNO;}
        }

        ///<summary>
        ///ProvinceID
        ///</summary>
        public int ProvinceID
        {
            set { m_ProvinceID = value;}
            get { return m_ProvinceID;}
        }

        ///<summary>
        ///CityID
        ///</summary>
        public int CityID
        {
            set { m_CityID = value;}
            get { return m_CityID;}
        }

        ///<summary>
        ///DistrictID
        ///</summary>
        public int DistrictID
        {
            set { m_DistrictID = value;}
            get { return m_DistrictID;}
        }

        ///<summary>
        ///Mobile
        ///</summary>
        public string Mobile
        {
            set { m_Mobile = value;}
            get { return m_Mobile;}
        }

        ///<summary>
        ///Email
        ///</summary>
        public string Email
        {
            set { m_Email = value;}
            get { return m_Email;}
        }

        ///<summary>
        ///QQ
        ///</summary>
        public string QQ
        {
            set { m_QQ = value;}
            get { return m_QQ;}
        }

        ///<summary>
        ///IPAddr
        ///</summary>
        public string IPAddr
        {
            set { m_IPAddr = value;}
            get { return m_IPAddr;}
        }

        ///<summary>
        ///IsChange
        ///</summary>
        public int IsChange
        {
            set { m_IsChange = value;}
            get { return m_IsChange;}
        }

        ///<summary>
        ///UserState
        ///</summary>
        public int UserState
        {
            set { m_UserState = value;}
            get { return m_UserState;}
        }

        ///<summary>
        ///CreateBy
        ///</summary>
        public int CreateBy
        {
            set { m_CreateBy = value;}
            get { return m_CreateBy;}
        }

        ///<summary>
        ///CreateTime
        ///</summary>
        public DateTime CreateTime
        {
            set { m_CreateTime = value;}
            get { return m_CreateTime;}
        }

        ///<summary>
        ///UpdateBy
        ///</summary>
        public int UpdateBy
        {
            set { m_UpdateBy = value;}
            get { return m_UpdateBy;}
        }

        ///<summary>
        ///UpdateTime
        ///</summary>
        public DateTime UpdateTime
        {
            set { m_UpdateTime = value;}
            get { return m_UpdateTime;}
        }

    }
}