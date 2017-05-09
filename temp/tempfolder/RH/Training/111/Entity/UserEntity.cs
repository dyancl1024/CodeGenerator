using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_User ( RH_User ) Entity类
    ///</summary>
    public class UserEntity
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

        public UserEntity(){ }
        public UserEntity(int id,string UserName,string Password,string TrueName,string Gender,string PicUrl,int Nation,string IDNO,int ProvinceID,int CityID,int DistrictID,string Mobile,string Email,string QQ,string IPAddr,int IsChange,int UserState,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime)
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

    }
}