using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingStudyStatus ( RH_TrainingStudyStatus ) Entity类
    ///</summary>
    [Serializable]
    public class TrainingStudyStatusEntity
    {
        private int m_ID = 0; 
        private int m_PCID = 0; 
        private int m_CID = 0; 
        private int m_SubTID = 0; 
        private int m_Status = 0; 
        private int m_UserID = 0; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///PCID
        ///</summary>
        public int PCID
        {
            set { m_PCID = value;}
            get { return m_PCID;}
        }

        ///<summary>
        ///课程ID
        ///</summary>
        public int CID
        {
            set { m_CID = value;}
            get { return m_CID;}
        }

        ///<summary>
        ///SubTID
        ///</summary>
        public int SubTID
        {
            set { m_SubTID = value;}
            get { return m_SubTID;}
        }

        ///<summary>
        ///课程学习状态：1学习中2.完成学习
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
        }

        ///<summary>
        ///UserID
        ///</summary>
        public int UserID
        {
            set { m_UserID = value;}
            get { return m_UserID;}
        }

    }
}