using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TempUser ( RH_TempUser ) Entity类
    ///</summary>
    [Serializable]
    public class TempUserEntity
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
        private string m_CUserName = string.Empty; 
        private string m_CPassword = string.Empty; 
        private string m_GradeCode = string.Empty; 
        private string m_SubjectCode = string.Empty; 
        private int m_SchoolID = 0; 
        private string m_SchoolName = string.Empty; 
        private string m_TempRemark = string.Empty; 
        private int m_TempUserID = 0; 
        private string m_TempClassName = string.Empty; 
        private int m_TempClassID = 0; 

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

        ///<summary>
        ///CUserName
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
        ///GradeCode
        ///</summary>
        public string GradeCode
        {
            set { m_GradeCode = value;}
            get { return m_GradeCode;}
        }

        ///<summary>
        ///SubjectCode
        ///</summary>
        public string SubjectCode
        {
            set { m_SubjectCode = value;}
            get { return m_SubjectCode;}
        }

        ///<summary>
        ///SchoolID
        ///</summary>
        public int SchoolID
        {
            set { m_SchoolID = value;}
            get { return m_SchoolID;}
        }

        ///<summary>
        ///SchoolName
        ///</summary>
        public string SchoolName
        {
            set { m_SchoolName = value;}
            get { return m_SchoolName;}
        }

        ///<summary>
        ///TempRemark
        ///</summary>
        public string TempRemark
        {
            set { m_TempRemark = value;}
            get { return m_TempRemark;}
        }

        ///<summary>
        ///TempUserID
        ///</summary>
        public int TempUserID
        {
            set { m_TempUserID = value;}
            get { return m_TempUserID;}
        }

        ///<summary>
        ///TempClassName
        ///</summary>
        public string TempClassName
        {
            set { m_TempClassName = value;}
            get { return m_TempClassName;}
        }

        ///<summary>
        ///TempClassID
        ///</summary>
        public int TempClassID
        {
            set { m_TempClassID = value;}
            get { return m_TempClassID;}
        }

    }
}