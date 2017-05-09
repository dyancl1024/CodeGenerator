using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Temp_BasicData_User ( RH_Temp_BasicData_User ) Entity类
    ///</summary>
    public class Temp_BasicData_UserEntity
    {
        private int m_ID = 0; //-- ID
        private int m_SubTID = 0; //-- SubTID
        private int m_ClassID = 0; //-- ClassID
        private int m_UserID = 0; //-- UserID
        private int m_Phase = 0; //-- 获得作业学时
        private int m_Q_jxfs = 0; //-- Q_jxfs
        private int m_T_jxfs = 0; //-- T_jxfs
        private int m_F_jxfs = 0; //-- F_jxfs
        private int m_E_jxfs = 0; //-- E_jxfs
        private int m_Q_jxcl = 0; //-- Q_jxcl
        private int m_T_jxcl = 0; //-- T_jxcl
        private int m_F_jxcl = 0; //-- F_jxcl
        private int m_E_jxcl = 0; //-- E_jxcl
        private int m_Q_xxxd = 0; //-- Q_xxxd
        private int m_T_xxxd = 0; //-- T_xxxd
        private int m_F_xxxd = 0; //-- F_xxxd
        private int m_E_xxxd = 0; //-- E_xxxd
        private int m_Q_wtfx = 0; //-- Q_wtfx
        private int m_T_wtfx = 0; //-- T_wtfx
        private int m_F_wtfx = 0; //-- F_wtfx
        private int m_E_wtfx = 0; //-- E_wtfx
        private int m_Q_yxrz = 0; //-- Q_yxrz
        private int m_T_yxrz = 0; //-- T_yxrz
        private int m_F_yxrz = 0; //-- F_yxrz
        private int m_E_yxrz = 0; //-- E_yxrz
        private int m_Q_pxzj = 0; //-- Q_pxzj
        private int m_T_pxzj = 0; //-- T_pxzj
        private int m_F_pxzj = 0; //-- F_pxzj
        private int m_E_pxzj = 0; //-- E_pxzj
        private int m_Finished = 0; //-- 作业是否完成
        private int m_GetCoursePhase = 0; //-- 获得课程学时
        private int m_CoursePhase = 0; //-- 课程总学时
        private string m_StatusName = string.Empty; //-- 培训状态
        private int m_IsStudy = 0; //-- 是否学习
        private int m_HomeWorkPhase = 0; //-- 作业总学时

        public Temp_BasicData_UserEntity(){ }
        public Temp_BasicData_UserEntity(int ID,int SubTID,int ClassID,int UserID,int Phase,int Q_jxfs,int T_jxfs,int F_jxfs,int E_jxfs,int Q_jxcl,int T_jxcl,int F_jxcl,int E_jxcl,int Q_xxxd,int T_xxxd,int F_xxxd,int E_xxxd,int Q_wtfx,int T_wtfx,int F_wtfx,int E_wtfx,int Q_yxrz,int T_yxrz,int F_yxrz,int E_yxrz,int Q_pxzj,int T_pxzj,int F_pxzj,int E_pxzj,int Finished,int GetCoursePhase,int CoursePhase,string StatusName,int IsStudy,int HomeWorkPhase)
        {
            this.ID=ID;
            this.SubTID=SubTID;
            this.ClassID=ClassID;
            this.UserID=UserID;
            this.Phase=Phase;
            this.Q_jxfs=Q_jxfs;
            this.T_jxfs=T_jxfs;
            this.F_jxfs=F_jxfs;
            this.E_jxfs=E_jxfs;
            this.Q_jxcl=Q_jxcl;
            this.T_jxcl=T_jxcl;
            this.F_jxcl=F_jxcl;
            this.E_jxcl=E_jxcl;
            this.Q_xxxd=Q_xxxd;
            this.T_xxxd=T_xxxd;
            this.F_xxxd=F_xxxd;
            this.E_xxxd=E_xxxd;
            this.Q_wtfx=Q_wtfx;
            this.T_wtfx=T_wtfx;
            this.F_wtfx=F_wtfx;
            this.E_wtfx=E_wtfx;
            this.Q_yxrz=Q_yxrz;
            this.T_yxrz=T_yxrz;
            this.F_yxrz=F_yxrz;
            this.E_yxrz=E_yxrz;
            this.Q_pxzj=Q_pxzj;
            this.T_pxzj=T_pxzj;
            this.F_pxzj=F_pxzj;
            this.E_pxzj=E_pxzj;
            this.Finished=Finished;
            this.GetCoursePhase=GetCoursePhase;
            this.CoursePhase=CoursePhase;
            this.StatusName=StatusName;
            this.IsStudy=IsStudy;
            this.HomeWorkPhase=HomeWorkPhase;
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
        ///UserID
        ///</summary>
        public int UserID
        {
            set { m_UserID = value;}
            get { return m_UserID;}
        }

        ///<summary>
        ///获得作业学时
        ///</summary>
        public int Phase
        {
            set { m_Phase = value;}
            get { return m_Phase;}
        }

        ///<summary>
        ///Q_jxfs
        ///</summary>
        public int Q_jxfs
        {
            set { m_Q_jxfs = value;}
            get { return m_Q_jxfs;}
        }

        ///<summary>
        ///T_jxfs
        ///</summary>
        public int T_jxfs
        {
            set { m_T_jxfs = value;}
            get { return m_T_jxfs;}
        }

        ///<summary>
        ///F_jxfs
        ///</summary>
        public int F_jxfs
        {
            set { m_F_jxfs = value;}
            get { return m_F_jxfs;}
        }

        ///<summary>
        ///E_jxfs
        ///</summary>
        public int E_jxfs
        {
            set { m_E_jxfs = value;}
            get { return m_E_jxfs;}
        }

        ///<summary>
        ///Q_jxcl
        ///</summary>
        public int Q_jxcl
        {
            set { m_Q_jxcl = value;}
            get { return m_Q_jxcl;}
        }

        ///<summary>
        ///T_jxcl
        ///</summary>
        public int T_jxcl
        {
            set { m_T_jxcl = value;}
            get { return m_T_jxcl;}
        }

        ///<summary>
        ///F_jxcl
        ///</summary>
        public int F_jxcl
        {
            set { m_F_jxcl = value;}
            get { return m_F_jxcl;}
        }

        ///<summary>
        ///E_jxcl
        ///</summary>
        public int E_jxcl
        {
            set { m_E_jxcl = value;}
            get { return m_E_jxcl;}
        }

        ///<summary>
        ///Q_xxxd
        ///</summary>
        public int Q_xxxd
        {
            set { m_Q_xxxd = value;}
            get { return m_Q_xxxd;}
        }

        ///<summary>
        ///T_xxxd
        ///</summary>
        public int T_xxxd
        {
            set { m_T_xxxd = value;}
            get { return m_T_xxxd;}
        }

        ///<summary>
        ///F_xxxd
        ///</summary>
        public int F_xxxd
        {
            set { m_F_xxxd = value;}
            get { return m_F_xxxd;}
        }

        ///<summary>
        ///E_xxxd
        ///</summary>
        public int E_xxxd
        {
            set { m_E_xxxd = value;}
            get { return m_E_xxxd;}
        }

        ///<summary>
        ///Q_wtfx
        ///</summary>
        public int Q_wtfx
        {
            set { m_Q_wtfx = value;}
            get { return m_Q_wtfx;}
        }

        ///<summary>
        ///T_wtfx
        ///</summary>
        public int T_wtfx
        {
            set { m_T_wtfx = value;}
            get { return m_T_wtfx;}
        }

        ///<summary>
        ///F_wtfx
        ///</summary>
        public int F_wtfx
        {
            set { m_F_wtfx = value;}
            get { return m_F_wtfx;}
        }

        ///<summary>
        ///E_wtfx
        ///</summary>
        public int E_wtfx
        {
            set { m_E_wtfx = value;}
            get { return m_E_wtfx;}
        }

        ///<summary>
        ///Q_yxrz
        ///</summary>
        public int Q_yxrz
        {
            set { m_Q_yxrz = value;}
            get { return m_Q_yxrz;}
        }

        ///<summary>
        ///T_yxrz
        ///</summary>
        public int T_yxrz
        {
            set { m_T_yxrz = value;}
            get { return m_T_yxrz;}
        }

        ///<summary>
        ///F_yxrz
        ///</summary>
        public int F_yxrz
        {
            set { m_F_yxrz = value;}
            get { return m_F_yxrz;}
        }

        ///<summary>
        ///E_yxrz
        ///</summary>
        public int E_yxrz
        {
            set { m_E_yxrz = value;}
            get { return m_E_yxrz;}
        }

        ///<summary>
        ///Q_pxzj
        ///</summary>
        public int Q_pxzj
        {
            set { m_Q_pxzj = value;}
            get { return m_Q_pxzj;}
        }

        ///<summary>
        ///T_pxzj
        ///</summary>
        public int T_pxzj
        {
            set { m_T_pxzj = value;}
            get { return m_T_pxzj;}
        }

        ///<summary>
        ///F_pxzj
        ///</summary>
        public int F_pxzj
        {
            set { m_F_pxzj = value;}
            get { return m_F_pxzj;}
        }

        ///<summary>
        ///E_pxzj
        ///</summary>
        public int E_pxzj
        {
            set { m_E_pxzj = value;}
            get { return m_E_pxzj;}
        }

        ///<summary>
        ///作业是否完成
        ///</summary>
        public int Finished
        {
            set { m_Finished = value;}
            get { return m_Finished;}
        }

        ///<summary>
        ///获得课程学时
        ///</summary>
        public int GetCoursePhase
        {
            set { m_GetCoursePhase = value;}
            get { return m_GetCoursePhase;}
        }

        ///<summary>
        ///课程总学时
        ///</summary>
        public int CoursePhase
        {
            set { m_CoursePhase = value;}
            get { return m_CoursePhase;}
        }

        ///<summary>
        ///培训状态
        ///</summary>
        public string StatusName
        {
            set { m_StatusName = value;}
            get { return m_StatusName;}
        }

        ///<summary>
        ///是否学习
        ///</summary>
        public int IsStudy
        {
            set { m_IsStudy = value;}
            get { return m_IsStudy;}
        }

        ///<summary>
        ///作业总学时
        ///</summary>
        public int HomeWorkPhase
        {
            set { m_HomeWorkPhase = value;}
            get { return m_HomeWorkPhase;}
        }

    }
}