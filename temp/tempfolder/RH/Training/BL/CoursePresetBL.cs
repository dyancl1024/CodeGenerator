using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_CoursePreset ( RH_CoursePreset ) BL类
    ///</summary>
    public class CoursePresetBL
    {

        /// <summary>
        /// 添加RH_CoursePreset
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCoursePreset(CoursePresetEntity info)
        {
            return CoursePresetDB.AddCoursePreset(info);
        }


        /// <summary>
        /// 修改RH_CoursePreset
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCoursePreset(CoursePresetEntity info)
        {
            return CoursePresetDB.ModifyCoursePreset(info);
        }


        /// <summary>
        /// 删除RH_CoursePreset
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCoursePreset(int ID)
        {
            return CoursePresetDB.RemoveCoursePreset(ID);
        }

        /// <summary>
        /// 查看RH_CoursePreset
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CoursePresetEntity GetCoursePresetDetail(int ID)
        {
            return CoursePresetDB.GetCoursePresetDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_CoursePreset
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CoursePresetEntityListResult GetCoursePresetEntityList(CoursePresetSearcher Searcher)
        {
            return CoursePresetDB.GetCoursePresetEntityList(Searcher);
        }
    }
}