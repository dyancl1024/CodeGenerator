using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_CoursePreSetList ( RH_CoursePreSetList ) BL类
    ///</summary>
    public class CoursePreSetListBL
    {

        /// <summary>
        /// 添加RH_CoursePreSetList
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCoursePreSetList(CoursePreSetListEntity info)
        {
            return CoursePreSetListDB.AddCoursePreSetList(info);
        }


        /// <summary>
        /// 修改RH_CoursePreSetList
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCoursePreSetList(CoursePreSetListEntity info)
        {
            return CoursePreSetListDB.ModifyCoursePreSetList(info);
        }


        /// <summary>
        /// 删除RH_CoursePreSetList
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCoursePreSetList(int ID)
        {
            return CoursePreSetListDB.RemoveCoursePreSetList(ID);
        }

        /// <summary>
        /// 查看RH_CoursePreSetList
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CoursePreSetListEntity GetCoursePreSetListDetail(int ID)
        {
            return CoursePreSetListDB.GetCoursePreSetListDetail(ID);
        }
    }
}