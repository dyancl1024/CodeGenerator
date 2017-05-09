using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_City ( RH_City ) Entity类
    ///</summary>
    [Serializable]
    public class CityEntity
    {
        private int m_id = 0; 
        private string m_CityName = string.Empty; 
        private string m_CityPY = string.Empty; 
        private int m_ProvinceID = 0; 

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