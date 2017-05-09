using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingMyCourseRecord ( RH_TrainingMyCourseRecord ) Entity类
    ///</summary>
    [Serializable]
    public class TrainingMyCourseRecordEntity
    {
        private int m_ID = 0; 
        private int m_UserID = 0; 
        private int m_SubTID = 0; 
        private int m_PCID = 0; 
        private int m_CourseID = 0; 
        private int m_WatchTime = 0; 
        private int m_TotalWatchTime = 0; 
        private DateTime m_CreateTime ; 

        ///<summary>
        ///主键
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///人员ID
        ///</summary>
        public int UserID
        {
            set { m_UserID = value;}
            get { return m_UserID;}
        }

        ///<summary>
        ///项目id
        ///</summary>
        public int SubTID
        {
            set { m_SubTID = value;}
            get { return m_SubTID;}
        }

        ///<summary>
        ///套餐ID
        ///</summary>
        public int PCID
        {
            set { m_PCID = value;}
            get { return m_PCID;}
        }

        ///<summary>
        ///课程id
        ///</summary>
        public int CourseID
        {
            set { m_CourseID = value;}
            get { return m_CourseID;}
        }

        ///<summary>
        ///当前已观看时间
        ///</summary>
        public int WatchTime
        {
            set { m_WatchTime = value;}
            get { return m_WatchTime;}
        }

        ///<summary>
        ///总共观看时间
        ///</summary>
        public int TotalWatchTime
        {
            set { m_TotalWatchTime = value;}
            get { return m_TotalWatchTime;}
        }

        ///<summary>
        ///CreateTime
        ///</summary>
        public DateTime CreateTime
        {
            set { m_CreateTime = value;}
            get { return m_CreateTime;}
        }

    }
}