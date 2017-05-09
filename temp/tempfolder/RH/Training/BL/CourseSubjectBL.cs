using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_CourseSubject ( RH_CourseSubject ) BL类
    ///</summary>
    public class CourseSubjectBL
    {

        /// <summary>
        /// 添加RH_CourseSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseSubject(CourseSubjectEntity info)
        {
            return CourseSubjectDB.AddCourseSubject(info);
        }


        /// <summary>
        /// 修改RH_CourseSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseSubject(CourseSubjectEntity info)
        {
            return CourseSubjectDB.ModifyCourseSubject(info);
        }


        /// <summary>
        /// 删除RH_CourseSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseSubject(int ID)
        {
            return CourseSubjectDB.RemoveCourseSubject(ID);
        }

        /// <summary>
        /// 查看RH_CourseSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseSubjectEntity GetCourseSubjectDetail(int ID)
        {
            return CourseSubjectDB.GetCourseSubjectDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_CourseSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseSubjectEntityListResult GetCourseSubjectEntityList(CourseSubjectSearcher Searcher)
        {
            return CourseSubjectDB.GetCourseSubjectEntityList(Searcher);
        }
    }
}