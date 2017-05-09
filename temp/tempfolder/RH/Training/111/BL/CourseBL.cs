using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_Course ( RH_Course ) BL类
    ///</summary>
    public class CourseBL
    {

        /// <summary>
        /// 添加RH_Course
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourse(CourseEntity info)
        {
            return CourseDB.AddCourse(info);
        }


        /// <summary>
        /// 修改RH_Course
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourse(CourseEntity info)
        {
            return CourseDB.ModifyCourse(info);
        }


        /// <summary>
        /// 删除RH_Course
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourse(int ID)
        {
            return CourseDB.RemoveCourse(ID);
        }

        /// <summary>
        /// 查看RH_Course
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseEntity GetCourseDetail(int ID)
        {
            return CourseDB.GetCourseDetail(ID);
        }
    }
}