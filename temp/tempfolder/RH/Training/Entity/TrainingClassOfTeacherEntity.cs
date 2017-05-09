using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingClassOfTeacher ( RH_TrainingClassOfTeacher ) Entity类
    ///</summary>
    [Serializable]
    public class TrainingClassOfTeacherEntity
    {
        private int m_ID = 0; 
        private int m_SubTID = 0; 
        private int m_ClassID = 0; 
        private int m_TeacherID = 0; 
        private int m_Appointer = 0; 
        private DateTime m_AppointTime ; 

        ///<summary>
        ///主键
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///班级id  RH_Class
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
        ///辅导老师id RH_User表
        ///</summary>
        public int TeacherID
        {
            set { m_TeacherID = value;}
            get { return m_TeacherID;}
        }

        ///<summary>
        ///任命人 对应RH_User表id
        ///</summary>
        public int Appointer
        {
            set { m_Appointer = value;}
            get { return m_Appointer;}
        }

        ///<summary>
        ///任命时间
        ///</summary>
        public DateTime AppointTime
        {
            set { m_AppointTime = value;}
            get { return m_AppointTime;}
        }

    }
}