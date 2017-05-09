using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingClassUserRelation ( RH_TrainingClassUserRelation ) Entity类
    ///</summary>
    [Serializable]
    public class TrainingClassUserRelationEntity
    {
        private int m_ID = 0; 
        private int m_UserID = 0; 
        private int m_ClassID = 0; 
        private int m_SubTID = 0; 
        private int m_CreateBy = 0; 
        private DateTime m_CreateTime ; 
        private int m_UpdateBy = 0; 
        private DateTime m_UpdateTime ; 

        ///<summary>
        ///主键
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///用户id
        ///</summary>
        public int UserID
        {
            set { m_UserID = value;}
            get { return m_UserID;}
        }

        ///<summary>
        ///工作坊id（班级）
        ///</summary>
        public int ClassID
        {
            set { m_ClassID = value;}
            get { return m_ClassID;}
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
        ///导入人
        ///</summary>
        public int CreateBy
        {
            set { m_CreateBy = value;}
            get { return m_CreateBy;}
        }

        ///<summary>
        ///导入时间
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