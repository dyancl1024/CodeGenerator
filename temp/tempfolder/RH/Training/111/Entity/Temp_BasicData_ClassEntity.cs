using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Temp_BasicData_Class ( RH_Temp_BasicData_Class ) Entity类
    ///</summary>
    public class Temp_BasicData_ClassEntity
    {
        private int m_ID = 0; //-- ID
        private int m_SubTID = 0; //-- SubTID
        private int m_ClassID = 0; //-- ClassID
        private int m_YX_HW = 0; //-- 优秀作业数量
        private int m_TJ_HW = 0; //-- 提交作业数量
        private int m_StudyNum = 0; //-- 学习人数
        private int m_FinishedNum = 0; //-- 合格的人数
        private int m_UserNum = 0; //-- 班级人数
        private decimal m_ClassRate = 0; //-- 班级合格率
        private int m_HG_HW = 0; //-- 合格作业数量（审批状态为合格和优秀）
        private int m_No_Num = 0; //-- 未审批作业数

        public Temp_BasicData_ClassEntity(){ }
        public Temp_BasicData_ClassEntity(int ID,int SubTID,int ClassID,int YX_HW,int TJ_HW,int StudyNum,int FinishedNum,int UserNum,decimal ClassRate,int HG_HW,int No_Num)
        {
            this.ID=ID;
            this.SubTID=SubTID;
            this.ClassID=ClassID;
            this.YX_HW=YX_HW;
            this.TJ_HW=TJ_HW;
            this.StudyNum=StudyNum;
            this.FinishedNum=FinishedNum;
            this.UserNum=UserNum;
            this.ClassRate=ClassRate;
            this.HG_HW=HG_HW;
            this.No_Num=No_Num;
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