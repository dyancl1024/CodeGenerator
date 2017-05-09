using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingMyCourse ( RH_TrainingMyCourse ) Entity类
    ///</summary>
    [Serializable]
    public class TrainingMyCourseEntity
    {
        private int m_ID = 0; 
        private int m_SubTID = 0; 
        private int m_PCID = 0; 
        private int m_CID = 0; 
        private int m_UserID = 0; 
        private DateTime m_CreateTime ; 
        private int m_Status = 0; 

        ///<summary>
        ///主键
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
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
        ///套餐id，对应课程预设表
        ///</summary>
        public int PCID
        {
            set { m_PCID = value;}
            get { return m_PCID;}
        }

        ///<summary>
        ///课程id
        ///</summary>
        public int CID
        {
            set { m_CID = value;}
            get { return m_CID;}
        }

        ///<summary>
        ///学员id
        ///</summary>
        public int UserID
        {
            set { m_UserID = value;}
            get { return m_UserID;}
        }

        ///<summary>
        ///选课时间
        ///</summary>
        public DateTime CreateTime
        {
            set { m_CreateTime = value;}
            get { return m_CreateTime;}
        }

        ///<summary>
        ///选课状态：1.正常2.删除
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
        }

    }
}