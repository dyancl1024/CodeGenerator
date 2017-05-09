using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_District ( RH_District ) Entity类
    ///</summary>
    [Serializable]
    public class DistrictEntity
    {
        private int m_ID = 0; 
        private string m_DistrictName = string.Empty; 
        private string m_DistrictPY = string.Empty; 
        private int m_CityID = 0; 

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