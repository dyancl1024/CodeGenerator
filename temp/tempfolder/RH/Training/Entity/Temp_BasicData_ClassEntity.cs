using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Temp_BasicData_Class ( RH_Temp_BasicData_Class ) Entity类
    ///</summary>
    [Serializable]
    public class Temp_BasicData_ClassEntity
    {
        private int m_ID = 0; 
        private int m_SubTID = 0; 
        private int m_ClassID = 0; 
        private int m_YX_HW = 0; 
        private int m_TJ_HW = 0; 
        private int m_StudyNum = 0; 
        private int m_FinishedNum = 0; 
        private int m_UserNum = 0; 
        private decimal m_ClassRate = 0; 
        private int m_HG_HW = 0; 
        private int m_No_Num = 0; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
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
        ///ClassID
        ///</summary>
        public int ClassID
        {
            set { m_ClassID = value;}
            get { return m_ClassID;}
        }

        ///<summary>
        ///优秀作业数量
        ///</summary>
        public int YX_HW
        {
            set { m_YX_HW = value;}
            get { return m_YX_HW;}
        }

        ///<summary>
        ///提交作业数量
        ///</summary>
        public int TJ_HW
        {
            set { m_TJ_HW = value;}
            get { return m_TJ_HW;}
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
        ///合格的人数
        ///</summary>
        public int FinishedNum
        {
            set { m_FinishedNum = value;}
            get { return m_FinishedNum;}
        }

        ///<summary>
        ///班级人数
        ///</summary>
        public int UserNum
        {
            set { m_UserNum = value;}
            get { return m_UserNum;}
        }

        ///<summary>
        ///班级合格率
        ///</summary>
        public decimal ClassRate
        {
            set { m_ClassRate = value;}
            get { return m_ClassRate;}
        }

        ///<summary>
        ///合格作业数量（审批状态为合格和优秀）
        ///</summary>
        public int HG_HW
        {
            set { m_HG_HW = value;}
            get { return m_HG_HW;}
        }

        ///<summary>
        ///未审批作业数
        ///</summary>
        public int No_Num
        {
            set { m_No_Num = value;}
            get { return m_No_Num;}
        }

    }
}