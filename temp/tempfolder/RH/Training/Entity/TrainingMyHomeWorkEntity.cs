using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingMyHomeWork ( RH_TrainingMyHomeWork ) Entity类
    ///</summary>
    [Serializable]
    public class TrainingMyHomeWorkEntity
    {
        private int m_ID = 0; 
        private string m_HomeWorkTitle = string.Empty; 
        private string m_HomeWorkContent = string.Empty; 
        private int m_HomeWorkPhaseID = 0; 
        private int m_SubTID = 0; 
        private int m_Status = 0; 
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
        ///作业标题
        ///</summary>
        public string HomeWorkTitle
        {
            set { m_HomeWorkTitle = value;}
            get { return m_HomeWorkTitle;}
        }

        ///<summary>
        ///作业内容
        ///</summary>
        public string HomeWorkContent
        {
            set { m_HomeWorkContent = value;}
            get { return m_HomeWorkContent;}
        }

        ///<summary>
        ///作业指标ID  RH_TrainingPhase
        ///</summary>
        public int HomeWorkPhaseID
        {
            set { m_HomeWorkPhaseID = value;}
            get { return m_HomeWorkPhaseID;}
        }

        ///<summary>
        ///阶段项目ID
        ///</summary>
        public int SubTID
        {
            set { m_SubTID = value;}
            get { return m_SubTID;}
        }

        ///<summary>
        ///作业状态：1.待提交 2.待审批 3.不合格 4.合格 5.优秀 -不合格时（待提交）
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
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

    }
}