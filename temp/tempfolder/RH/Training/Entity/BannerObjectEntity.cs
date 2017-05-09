using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_BannerObject ( RH_BannerObject ) Entity类
    ///</summary>
    [Serializable]
    public class BannerObjectEntity
    {
        private int m_ID = 0; 
        private int m_BannerID = 0; 
        private int m_ObjectID = 0; 
        private int m_CreateBy = 0; 
        private DateTime m_CreateTime ; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///BannerID
        ///</summary>
        public int BannerID
        {
            set { m_BannerID = value;}
            get { return m_BannerID;}
        }

        ///<summary>
        ///ObjectID
        ///</summary>
        public int ObjectID
        {
            set { m_ObjectID = value;}
            get { return m_ObjectID;}
        }

        ///<summary>
        ///创建人
        ///</summary>
        public int CreateBy
        {
            set { m_CreateBy = value;}
            get { return m_CreateBy;}
        }

        ///<summary>
        ///创建时间
        ///</summary>
        public DateTime CreateTime
        {
            set { m_CreateTime = value;}
            get { return m_CreateTime;}
        }

    }
}