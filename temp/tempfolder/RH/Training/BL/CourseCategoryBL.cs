using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_CourseCategory ( RH_CourseCategory ) BL类
    ///</summary>
    public class CourseCategoryBL
    {

        /// <summary>
        /// 添加RH_CourseCategory
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseCategory(CourseCategoryEntity info)
        {
            return CourseCategoryDB.AddCourseCategory(info);
        }


        /// <summary>
        /// 修改RH_CourseCategory
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseCategory(CourseCategoryEntity info)
        {
            return CourseCategoryDB.ModifyCourseCategory(info);
        }


        /// <summary>
        /// 删除RH_CourseCategory
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseCategory(int ID)
        {
            return CourseCategoryDB.RemoveCourseCategory(ID);
        }

        /// <summary>
        /// 查看RH_CourseCategory
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseCategoryEntity GetCourseCategoryDetail(int ID)
        {
            return CourseCategoryDB.GetCourseCategoryDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_CourseCategory
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseCategoryEntityListResult GetCourseCategoryEntityList(CourseCategorySearcher Searcher)
        {
            return CourseCategoryDB.GetCourseCategoryEntityList(Searcher);
        }
    }
}