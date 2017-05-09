using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Country ( RH_Country ) Entity类
    ///</summary>
    [Serializable]
    public class CountryEntity
    {
        private int m_ID = 0; 
        private string m_CountryName = string.Empty; 
        private string m_CountryPY = string.Empty; 

        ///<summary>
        ///主键
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///国家名
        ///</summary>
        public string CountryName
        {
            set { m_CountryName = value;}
            get { return m_CountryName;}
        }

        ///<summary>
        ///国家拼音
        ///</summary>
        public string CountryPY
        {
            set { m_CountryPY = value;}
            get { return m_CountryPY;}
        }

    }
}