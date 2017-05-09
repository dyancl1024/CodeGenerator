using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_District ( RH_District ) Entity类
    ///</summary>
    public class DistrictEntity
    {
        private int m_ID = 0; //-- ID
        private string m_DistrictName = string.Empty; //-- DistrictName
        private string m_DistrictPY = string.Empty; //-- DistrictPY
        private int m_CityID = 0; //-- CityID

        public DistrictEntity(){ }
        public DistrictEntity(int ID,string DistrictName,string DistrictPY,int CityID)
        {
            this.ID=ID;
            this.DistrictName=DistrictName;
            this.DistrictPY=DistrictPY;
            this.CityID=CityID;
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
        ///DistrictName
        ///</summary>
        public string DistrictName
        {
            set { m_DistrictName = value;}
            get { return m_DistrictName;}
        }

        ///<summary>
        ///DistrictPY
        ///</summary>
        public string DistrictPY
        {
            set { m_DistrictPY = value;}
            get { return m_DistrictPY;}
        }

        ///<summary>
        ///CityID
        ///</summary>
        public int CityID
        {
            set { m_CityID = value;}
            get { return m_CityID;}
        }

    }
}