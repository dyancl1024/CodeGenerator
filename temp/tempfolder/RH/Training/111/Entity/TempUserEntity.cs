using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TempUser ( RH_TempUser ) Entity类
    ///</summary>
    public class TempUserEntity
    {
        private int m_id = 0; //-- id
        private string m_UserName = string.Empty; //-- UserName
        private string m_Password = string.Empty; //-- Password
        private string m_TrueName = string.Empty; //-- TrueName
        private string m_Gender = string.Empty; //-- Gender
        private string m_PicUrl = string.Empty; //-- PicUrl
        private int m_Nation = 0; //-- Nation
        private string m_IDNO = string.Empty; //-- IDNO
        private int m_ProvinceID = 0; //-- ProvinceID
        private int m_CityID = 0; //-- CityID
        private int m_DistrictID = 0; //-- DistrictID
        private string m_Mobile = string.Empty; //-- Mobile
        private string m_Email = string.Empty; //-- Email
        private string m_QQ = string.Empty; //-- QQ
        private string m_IPAddr = string.Empty; //-- IPAddr
        private int m_IsChange = 0; //-- IsChange
        private int m_UserState = 0; //-- UserState
        private int m_CreateBy = 0; //-- CreateBy
        private DateTime m_CreateTime ; //-- CreateTime
        private int m_UpdateBy = 0; //-- UpdateBy
        private DateTime m_UpdateTime ; //-- UpdateTime
        private string m_CUserName = string.Empty; //-- CUserName
        private string m_CPassword = string.Empty; //-- CPassword
        private string m_GradeCode = string.Empty; //-- GradeCode
        private string m_SubjectCode = string.Empty; //-- SubjectCode
        private int m_SchoolID = 0; //-- SchoolID
        private string m_SchoolName = string.Empty; //-- SchoolName
        private string m_TempRemark = string.Empty; //-- TempRemark
        private int m_TempUserID = 0; //-- TempUserID
        private string m_TempClassName = string.Empty; //-- TempClassName
        private int m_TempClassID = 0; //-- TempClassID

        public TempUserEntity(){ }
        public TempUserEntity(int id,string UserName,string Password,string TrueName,string Gender,string PicUrl,int Nation,string IDNO,int ProvinceID,int CityID,int DistrictID,string Mobile,string Email,string QQ,string IPAddr,int IsChange,int UserState,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime,string CUserName,string CPassword,string GradeCode,string SubjectCode,int SchoolID,string SchoolName,string TempRemark,int TempUserID,string TempClassName,int TempClassID)
        {
            this.id=id;
            this.UserName=UserName;
            this.Password=Password;
            this.TrueName=TrueName;
            this.Gender=Gender;
            this.PicUrl=PicUrl;
            this.Nation=Nation;
            this.IDNO=IDNO;
            this.ProvinceID=ProvinceID;
            this.CityID=CityID;
            this.DistrictID=DistrictID;
            this.Mobile=Mobile;
            this.Email=Email;
            this.QQ=QQ;
            this.IPAddr=IPAddr;
            this.IsChange=IsChange;
            this.UserState=UserState;
            this.CreateBy=CreateBy;
            this.CreateTime=CreateTime;
            this.UpdateBy=UpdateBy;
            this.UpdateTime=UpdateTime;
            this.CUserName=CUserName;
            this.CPassword=CPassword;
            this.GradeCode=GradeCode;
            this.SubjectCode=SubjectCode;
            this.SchoolID=SchoolID;
            this.SchoolName=SchoolName;
            this.TempRemark=TempRemark;
            this.TempUserID=TempUserID;
            this.TempClassName=TempClassName;
            this.TempClassID=TempClassID;
        }

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