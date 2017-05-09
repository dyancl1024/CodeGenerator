using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_CourseTheme ( RH_CourseTheme ) BL类
    ///</summary>
    public class CourseThemeBL
    {

        /// <summary>
        /// 添加RH_CourseTheme
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseTheme(CourseThemeEntity info)
        {
            return CourseThemeDB.AddCourseTheme(info);
        }


        /// <summary>
        /// 修改RH_CourseTheme
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseTheme(CourseThemeEntity info)
        {
            return CourseThemeDB.ModifyCourseTheme(info);
        }


        /// <summary>
        /// 删除RH_CourseTheme
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseTheme(int ID)
        {
            return CourseThemeDB.RemoveCourseTheme(ID);
        }

        /// <summary>
        /// 查看RH_CourseTheme
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseThemeEntity GetCourseThemeDetail(int ID)
        {
            return CourseThemeDB.GetCourseThemeDetail(ID);
        }
    }
}