using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Course ( RH_Course ) Entity类
    ///</summary>
    [Serializable]
    public class CourseEntity
    {
        private int m_ID = 0; 
        private string m_CourseName = string.Empty; 
        private int m_CoursePharse = 0; 
        private string m_CourseCategoryCode = string.Empty; 
        private string m_CourseDesc = string.Empty; 
        private string m_CourseUrl = string.Empty; 
        private string m_TeacherDesc = string.Empty; 
        private string m_TeacherName = string.Empty; 
        private string m_TeacherTitle = string.Empty; 
        private string m_CourseLabel = string.Empty; 
        private string m_CourseCode = string.Empty; 
        private int m_IsPractice = 0; 
        private string m_CourseCompany = string.Empty; 
        private string m_CourseStyle = string.Empty; 
        private int m_IsSpecialTeacher = 0; 
        private int m_VideoDuration = 0; 
        private int m_IsApp = 0; 
        private int m_Status = 0; 
        private int m_CreateBy = 0; 
        private DateTime m_CreateTime ; 
        private int m_UpdateBy = 0; 
        private DateTime m_UpdateTime ; 

        ///<summary>
        ///ID
        ///</summary>
        public int ID
        {
            set { m_ID = value;}
            get { return m_ID;}
        }

        ///<summary>
        ///课程名称
        ///</summary>
        public string CourseName
        {
            set { m_CourseName = value;}
            get { return m_CourseName;}
        }

        ///<summary>
        ///课程学时
        ///</summary>
        public int CoursePharse
        {
            set { m_CoursePharse = value;}
            get { return m_CoursePharse;}
        }

        ///<summary>
        ///1-通识 2-专业 3-技术 4-科研 5-教研
        ///</summary>
        public string CourseCategoryCode
        {
            set { m_CourseCategoryCode = value;}
            get { return m_CourseCategoryCode;}
        }

        ///<summary>
        ///CourseDesc
        ///</summary>
        public string CourseDesc
        {
            set { m_CourseDesc = value;}
            get { return m_CourseDesc;}
        }

        ///<summary>
        ///记录课程文件路径
        ///</summary>
        public string CourseUrl
        {
            set { m_CourseUrl = value;}
            get { return m_CourseUrl;}
        }

        ///<summary>
        ///讲师简介
        ///</summary>
        public string TeacherDesc
        {
            set { m_TeacherDesc = value;}
            get { return m_TeacherDesc;}
        }

        ///<summary>
        ///讲师姓名
        ///</summary>
        public string TeacherName
        {
            set { m_TeacherName = value;}
            get { return m_TeacherName;}
        }

        ///<summary>
        ///讲师职称
        ///</summary>
        public string TeacherTitle
        {
            set { m_TeacherTitle = value;}
            get { return m_TeacherTitle;}
        }

        ///<summary>
        ///课程标签
        ///</summary>
        public string CourseLabel
        {
            set { m_CourseLabel = value;}
            get { return m_CourseLabel;}
        }

        ///<summary>
        ///课程代码
        ///</summary>
        public string CourseCode
        {
            set { m_CourseCode = value;}
            get { return m_CourseCode;}
        }

        ///<summary>
        ///是否为实践性课程：1.是 2.否
        ///</summary>
        public int IsPractice
        {
            set { m_IsPractice = value;}
            get { return m_IsPractice;}
        }

        ///<summary>
        ///课程单位
        ///</summary>
        public string CourseCompany
        {
            set { m_CourseCompany = value;}
            get { return m_CourseCompany;}
        }

        ///<summary>
        ///课程形式
        ///</summary>
        public string CourseStyle
        {
            set { m_CourseStyle = value;}
            get { return m_CourseStyle;}
        }

        ///<summary>
        ///是否为一线教师教研员：1.是 2.否
        ///</summary>
        public int IsSpecialTeacher
        {
            set { m_IsSpecialTeacher = value;}
            get { return m_IsSpecialTeacher;}
        }

        ///<summary>
        ///学习时长
        ///</summary>
        public int VideoDuration
        {
            set { m_VideoDuration = value;}
            get { return m_VideoDuration;}
        }

        ///<summary>
        ///是否App： 1.是2.否
        ///</summary>
        public int IsApp
        {
            set { m_IsApp = value;}
            get { return m_IsApp;}
        }

        ///<summary>
        ///状态 1-未发布 2-已发布 3-删除
        ///</summary>
        public int Status
        {
            set { m_Status = value;}
            get { return m_Status;}
        }

        ///<summary>
        ///创建人
        ///</summary>
        public int CreateBy
        {
            set { m_CreateBy = value;}
            get { return m_CreateBy;}
        }

        ///<summary>
        ///创建时间
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