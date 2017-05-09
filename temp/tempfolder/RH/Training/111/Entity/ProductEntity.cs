using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Product ( RH_Product ) Entity类
    ///</summary>
    public class ProductEntity
    {
        private int m_ID = 0; //-- ID
        private string m_ProductName = string.Empty; //-- ProductName
        private string m_ProductCode = string.Empty; //-- ProductCode
        private int m_ProductLevel = 0; //-- 产品级别 1.省 2. 市 3.区县
        private string m_ProductUrl = string.Empty; //-- ProductUrl
        private int m_Status = 0; //-- 1.正常 2.删除
        private int m_ProvinceID = 0; //-- ProvinceID
        private int m_CityID = 0; //-- CityID
        private int m_DistrictID = 0; //-- DistrictID
        private string m_StaticUrl = string.Empty; //-- StaticUrl
        private int m_CreateBy = 0; //-- CreateBy
        private DateTime m_CreateTime ; //-- CreateTime
        private int m_UpdateBy = 0; //-- UpdateBy
        private DateTime m_UpdateTime ; //-- UpdateTime

        public ProductEntity(){ }
        public ProductEntity(int ID,string ProductName,string ProductCode,int ProductLevel,string ProductUrl,int Status,int ProvinceID,int CityID,int DistrictID,string StaticUrl,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime)
        {
            this.ID=ID;
            this.ProductName=ProductName;
            this.ProductCode=ProductCode;
            this.ProductLevel=ProductLevel;
            this.ProductUrl=ProductUrl;
            this.Status=Status;
            this.ProvinceID=ProvinceID;
            this.CityID=CityID;
            this.DistrictID=DistrictID;
            this.StaticUrl=StaticUrl;
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
        ///ProductName
        ///</summary>
        public string ProductName
        {
            set { m_ProductName = value;}
            get { return m_ProductName;}
        }

        ///<summary>
        ///ProductCode
        ///</summary>
        public string ProductCode
        {
            set { m_ProductCode = value;}
            get { return m_ProductCode;}
        }

        ///<summary>
        ///产品级别 1.省 2. 市 3.区县
        ///</summary>
        public int ProductLevel
        {
            set { m_ProductLevel = value;}
            get { return m_ProductLevel;}
        }

        ///<summary>
        ///ProductUrl
        ///</summary>
        public string ProductUrl
        {
            set { m_ProductUrl = value;}
            get { return m_ProductUrl;}
        }

        ///<summary>
        ///1.正常 2.删除
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
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
        ///StaticUrl
        ///</summary>
        public string StaticUrl
        {
            set { m_StaticUrl = value;}
            get { return m_StaticUrl;}
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