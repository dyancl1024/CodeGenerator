using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_City ( RH_City ) Entity类
    ///</summary>
    public class CityEntity
    {
        private int m_id = 0; //-- id
        private string m_CityName = string.Empty; //-- CityName
        private string m_CityPY = string.Empty; //-- CityPY
        private int m_ProvinceID = 0; //-- ProvinceID

        public CityEntity(){ }
        public CityEntity(int id,string CityName,string CityPY,int ProvinceID)
        {
            this.id=id;
            this.CityName=CityName;
            this.CityPY=CityPY;
            this.ProvinceID=ProvinceID;
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
        ///CityName
        ///</summary>
        public string CityName
        {
            set { m_CityName = value;}
            get { return m_CityName;}
        }

        ///<summary>
        ///CityPY
        ///</summary>
        public string CityPY
        {
            set { m_CityPY = value;}
            get { return m_CityPY;}
        }

        ///<summary>
        ///ProvinceID
        ///</summary>
        public int ProvinceID
        {
            set { m_ProvinceID = value;}
            get { return m_ProvinceID;}
        }

    }
}