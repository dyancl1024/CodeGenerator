using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_CourseOption ( RH_CourseOption ) BL类
    ///</summary>
    public class CourseOptionBL
    {

        /// <summary>
        /// 添加RH_CourseOption
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseOption(CourseOptionEntity info)
        {
            return CourseOptionDB.AddCourseOption(info);
        }


        /// <summary>
        /// 修改RH_CourseOption
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseOption(CourseOptionEntity info)
        {
            return CourseOptionDB.ModifyCourseOption(info);
        }


        /// <summary>
        /// 删除RH_CourseOption
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseOption(int ID)
        {
            return CourseOptionDB.RemoveCourseOption(ID);
        }

        /// <summary>
        /// 查看RH_CourseOption
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseOptionEntity GetCourseOptionDetail(int ID)
        {
            return CourseOptionDB.GetCourseOptionDetail(ID);
        }
    }
}