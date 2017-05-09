using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_TrainingClassOfTeacher ( RH_TrainingClassOfTeacher ) Entity类
    ///</summary>
    public class TrainingClassOfTeacherEntity
    {
        private int m_ID = 0; //-- 主键
        private int m_SubTID = 0; //-- 班级id  RH_Class
        private int m_ClassID = 0; //-- ClassID
        private int m_TeacherID = 0; //-- 辅导老师id RH_User表
        private int m_Appointer = 0; //-- 任命人 对应RH_User表id
        private DateTime m_AppointTime ; //-- 任命时间

        public TrainingClassOfTeacherEntity(){ }
        public TrainingClassOfTeacherEntity(int ID,int SubTID,int ClassID,int TeacherID,int Appointer,DateTime AppointTime)
        {
            this.ID=ID;
            this.SubTID=SubTID;
            this.ClassID=ClassID;
            this.TeacherID=TeacherID;
            this.Appointer=Appointer;
            this.AppointTime=AppointTime;
        }

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