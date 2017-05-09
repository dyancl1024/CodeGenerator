using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Country ( RH_Country ) Entity类
    ///</summary>
    public class CountryEntity
    {
        private int m_ID = 0; //-- 主键
        private string m_CountryName = string.Empty; //-- 国家名
        private string m_CountryPY = string.Empty; //-- 国家拼音

        public CountryEntity(){ }
        public CountryEntity(int ID,string CountryName,string CountryPY)
        {
            this.ID=ID;
            this.CountryName=CountryName;
            this.CountryPY=CountryPY;
        }

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