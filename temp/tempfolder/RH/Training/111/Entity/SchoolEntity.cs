using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_School ( RH_School ) Entity类
    ///</summary>
    public class SchoolEntity
    {
        private int m_ID = 0; //-- ID
        private int m_DistrictID = 0; //-- DistrictID
        private string m_SchoolName = string.Empty; //-- SchoolName
        private int m_Status = 0; //-- Status
        private int m_CreateBy = 0; //-- CreateBy
        private DateTime m_CreateTime ; //-- CreateTime
        private int m_UpdateBy = 0; //-- 更新人
        private DateTime m_UpdateTime ; //-- 更新时间

        public SchoolEntity(){ }
        public SchoolEntity(int ID,int DistrictID,string SchoolName,int Status,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime)
        {
            this.ID=ID;
            this.DistrictID=DistrictID;
            this.SchoolName=SchoolName;
            this.Status=Status;
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
        ///DistrictID
        ///</summary>
        public int DistrictID
        {
            set { m_DistrictID = value;}
            get { return m_DistrictID;}
        }

        ///<summary>
        ///SchoolName
        ///</summary>
        public string SchoolName
        {
            set { m_SchoolName = value;}
            get { return m_SchoolName;}
        }

        ///<summary>
        ///Status
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
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
        ///更新人
        ///</summary>
        public int UpdateBy
        {
            set { m_UpdateBy = value;}
            get { return m_UpdateBy;}
        }

        ///<summary>
        ///更新时间
        ///</summary>
        public DateTime UpdateTime
        {
            set { m_UpdateTime = value;}
            get { return m_UpdateTime;}
        }

    }
}