using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Product ( RH_Product ) Entity类
    ///</summary>
    [Serializable]
    public class ProductEntity
    {
        private int m_ID = 0; 
        private string m_ProductName = string.Empty; 
        private string m_ProductCode = string.Empty; 
        private int m_ProductLevel = 0; 
        private string m_ProductUrl = string.Empty; 
        private int m_Status = 0; 
        private int m_ProvinceID = 0; 
        private int m_CityID = 0; 
        private int m_DistrictID = 0; 
        private string m_StaticUrl = string.Empty; 
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