using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_School ( RH_School ) Entity类
    ///</summary>
    [Serializable]
    public class SchoolEntity
    {
        private int m_ID = 0; 
        private int m_DistrictID = 0; 
        private string m_SchoolName = string.Empty; 
        private int m_Status = 0; 
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