using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Province ( RH_Province ) Entity类
    ///</summary>
    public class ProvinceEntity
    {
        private int m_ID = 0; //-- ID
        private string m_ProvinceName = string.Empty; //-- ProvinceName
        private string m_ProvincePY = string.Empty; //-- ProvincePY
        private int m_CountyID = 0; //-- CountyID
        private int m_Status = 0; //-- Status

        public ProvinceEntity(){ }
        public ProvinceEntity(int ID,string ProvinceName,string ProvincePY,int CountyID,int Status)
        {
            this.ID=ID;
            this.ProvinceName=ProvinceName;
            this.ProvincePY=ProvincePY;
            this.CountyID=CountyID;
            this.Status=Status;
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