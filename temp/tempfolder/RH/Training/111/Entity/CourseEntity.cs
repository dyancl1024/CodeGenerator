using System;

namespace RH.Training.Entity
{
    ///<summary>
    ///RH_Course ( RH_Course ) Entity类
    ///</summary>
    public class CourseEntity
    {
        private int m_ID = 0; //-- ID
        private string m_CourseName = string.Empty; //-- 课程名称
        private int m_CoursePharse = 0; //-- 课程学时
        private string m_CourseCategoryCode = string.Empty; //-- 1-通识 2-专业 3-技术 4-科研 5-教研
        private string m_CourseDesc = string.Empty; //-- CourseDesc
        private string m_CourseUrl = string.Empty; //-- 记录课程文件路径
        private string m_TeacherDesc = string.Empty; //-- 讲师简介
        private string m_TeacherName = string.Empty; //-- 讲师姓名
        private string m_TeacherTitle = string.Empty; //-- 讲师职称
        private string m_CourseLabel = string.Empty; //-- 课程标签
        private string m_CourseCode = string.Empty; //-- 课程代码
        private int m_IsPractice = 0; //-- 是否为实践性课程：1.是 2.否
        private string m_CourseCompany = string.Empty; //-- 课程单位
        private string m_CourseStyle = string.Empty; //-- 课程形式
        private int m_IsSpecialTeacher = 0; //-- 是否为一线教师教研员：1.是 2.否
        private int m_VideoDuration = 0; //-- 学习时长
        private int m_IsApp = 0; //-- 是否App： 1.是2.否
        private int m_Status = 0; //-- 状态 1-未发布 2-已发布 3-删除
        private int m_CreateBy = 0; //-- 创建人
        private DateTime m_CreateTime ; //-- 创建时间
        private int m_UpdateBy = 0; //-- 更新人
        private DateTime m_UpdateTime ; //-- 更新时间

        public CourseEntity(){ }
        public CourseEntity(int ID,string CourseName,int CoursePharse,string CourseCategoryCode,string CourseDesc,string CourseUrl,string TeacherDesc,string TeacherName,string TeacherTitle,string CourseLabel,string CourseCode,int IsPractice,string CourseCompany,string CourseStyle,int IsSpecialTeacher,int VideoDuration,int IsApp,int Status,int CreateBy,DateTime CreateTime,int UpdateBy,DateTime UpdateTime)
        {
            this.ID=ID;
            this.CourseName=CourseName;
            this.CoursePharse=CoursePharse;
            this.CourseCategoryCode=CourseCategoryCode;
            this.CourseDesc=CourseDesc;
            this.CourseUrl=CourseUrl;
            this.TeacherDesc=TeacherDesc;
            this.TeacherName=TeacherName;
            this.TeacherTitle=TeacherTitle;
            this.CourseLabel=CourseLabel;
            this.CourseCode=CourseCode;
            this.IsPractice=IsPractice;
            this.CourseCompany=CourseCompany;
            this.CourseStyle=CourseStyle;
            this.IsSpecialTeacher=IsSpecialTeacher;
            this.VideoDuration=VideoDuration;
            this.IsApp=IsApp;
            this.Status=Status;
            this.CreateBy=CreateBy;
            this.CreateTime=CreateTime;
            this.UpdateBy=UpdateBy;
            this.UpdateTime=UpdateTime;
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