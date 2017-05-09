using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Temp_BasicData_User ( RH_Temp_BasicData_User ) Entity类
    ///</summary>
    [Serializable]
    public class Temp_BasicData_UserEntity
    {
        private int m_ID = 0; 
        private int m_SubTID = 0; 
        private int m_ClassID = 0; 
        private int m_UserID = 0; 
        private int m_Phase = 0; 
        private int m_Q_jxfs = 0; 
        private int m_T_jxfs = 0; 
        private int m_F_jxfs = 0; 
        private int m_E_jxfs = 0; 
        private int m_Q_jxcl = 0; 
        private int m_T_jxcl = 0; 
        private int m_F_jxcl = 0; 
        private int m_E_jxcl = 0; 
        private int m_Q_xxxd = 0; 
        private int m_T_xxxd = 0; 
        private int m_F_xxxd = 0; 
        private int m_E_xxxd = 0; 
        private int m_Q_wtfx = 0; 
        private int m_T_wtfx = 0; 
        private int m_F_wtfx = 0; 
        private int m_E_wtfx = 0; 
        private int m_Q_yxrz = 0; 
        private int m_T_yxrz = 0; 
        private int m_F_yxrz = 0; 
        private int m_E_yxrz = 0; 
        private int m_Q_pxzj = 0; 
        private int m_T_pxzj = 0; 
        private int m_F_pxzj = 0; 
        private int m_E_pxzj = 0; 
        private int m_Finished = 0; 
        private int m_GetCoursePhase = 0; 
        private int m_CoursePhase = 0; 
        private string m_StatusName = string.Empty; 
        private int m_IsStudy = 0; 
        private int m_HomeWorkPhase = 0; 

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