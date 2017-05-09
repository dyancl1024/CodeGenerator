using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Temp_BasicData_TrainingSub ( RH_Temp_BasicData_TrainingSub ) Entity类
    ///</summary>
    [Serializable]
    public class Temp_BasicData_TrainingSubEntity
    {
        private int m_ID = 0; 
        private int m_tid = 0; 
        private int m_SubTID = 0; 
        private int m_TeacherNum = 0; 
        private int m_ClassNum = 0; 
        private int m_FinishedNum = 0; 
        private int m_StudyNum = 0; 
        private int m_UserNum = 0; 
        private decimal m_FinishedRate = 0; 
        private decimal m_StudyRate = 0; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///tid
        ///</summary>
        public int tid
        {
            set { m_tid = value;}
            get { return m_tid;}
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
        ///TeacherNum
        ///</summary>
        public int TeacherNum
        {
            set { m_TeacherNum = value;}
            get { return m_TeacherNum;}
        }

        ///<summary>
        ///班级数量
        ///</summary>
        public int ClassNum
        {
            set { m_ClassNum = value;}
            get { return m_ClassNum;}
        }

        ///<summary>
        ///合格人数
        ///</summary>
        public int FinishedNum
        {
            set { m_FinishedNum = value;}
            get { return m_FinishedNum;}
        }

        ///<summary>
        ///学习人数
        ///</summary>
        public int StudyNum
        {
            set { m_StudyNum = value;}
            get { return m_StudyNum;}
        }

        ///<summary>
        ///学员总数
        ///</summary>
        public int UserNum
        {
            set { m_UserNum = value;}
            get { return m_UserNum;}
        }

        ///<summary>
        ///合格率
        ///</summary>
        public decimal FinishedRate
        {
            set { m_FinishedRate = value;}
            get { return m_FinishedRate;}
        }

        ///<summary>
        ///学习率
        ///</summary>
        public decimal StudyRate
        {
            set { m_StudyRate = value;}
            get { return m_StudyRate;}
        }

    }
}