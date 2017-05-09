using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Province ( RH_Province ) Entity类
    ///</summary>
    [Serializable]
    public class ProvinceEntity
    {
        private int m_ID = 0; 
        private string m_ProvinceName = string.Empty; 
        private string m_ProvincePY = string.Empty; 
        private int m_CountyID = 0; 
        private int m_Status = 0; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///ProvinceName
        ///</summary>
        public string ProvinceName
        {
            set { m_ProvinceName = value;}
            get { return m_ProvinceName;}
        }

        ///<summary>
        ///ProvincePY
        ///</summary>
        public string ProvincePY
        {
            set { m_ProvincePY = value;}
            get { return m_ProvincePY;}
        }

        ///<summary>
        ///CountyID
        ///</summary>
        public int CountyID
        {
            set { m_CountyID = value;}
            get { return m_CountyID;}
        }

        ///<summary>
        ///Status
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
        }

    }
}