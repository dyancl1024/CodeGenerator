using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_CourseThemeRelation ( RH_CourseThemeRelation ) BL类
    ///</summary>
    public class CourseThemeRelationBL
    {

        /// <summary>
        /// 添加RH_CourseThemeRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseThemeRelation(CourseThemeRelationEntity info)
        {
            return CourseThemeRelationDB.AddCourseThemeRelation(info);
        }


        /// <summary>
        /// 修改RH_CourseThemeRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseThemeRelation(CourseThemeRelationEntity info)
        {
            return CourseThemeRelationDB.ModifyCourseThemeRelation(info);
        }


        /// <summary>
        /// 删除RH_CourseThemeRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseThemeRelation(int ID)
        {
            return CourseThemeRelationDB.RemoveCourseThemeRelation(ID);
        }

        /// <summary>
        /// 查看RH_CourseThemeRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseThemeRelationEntity GetCourseThemeRelationDetail(int ID)
        {
            return CourseThemeRelationDB.GetCourseThemeRelationDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_CourseThemeRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseThemeRelationEntityListResult GetCourseThemeRelationEntityList(CourseThemeRelationSearcher Searcher)
        {
            return CourseThemeRelationDB.GetCourseThemeRelationEntityList(Searcher);
        }
    }
}