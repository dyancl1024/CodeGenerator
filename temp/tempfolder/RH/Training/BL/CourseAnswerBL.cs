using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_CourseAnswer ( RH_CourseAnswer ) BL类
    ///</summary>
    public class CourseAnswerBL
    {

        /// <summary>
        /// 添加RH_CourseAnswer
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseAnswer(CourseAnswerEntity info)
        {
            return CourseAnswerDB.AddCourseAnswer(info);
        }


        /// <summary>
        /// 修改RH_CourseAnswer
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseAnswer(CourseAnswerEntity info)
        {
            return CourseAnswerDB.ModifyCourseAnswer(info);
        }


        /// <summary>
        /// 删除RH_CourseAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseAnswer(int ID)
        {
            return CourseAnswerDB.RemoveCourseAnswer(ID);
        }

        /// <summary>
        /// 查看RH_CourseAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseAnswerEntity GetCourseAnswerDetail(int ID)
        {
            return CourseAnswerDB.GetCourseAnswerDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_CourseAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseAnswerEntityListResult GetCourseAnswerEntityList(CourseAnswerSearcher Searcher)
        {
            return CourseAnswerDB.GetCourseAnswerEntityList(Searcher);
        }
    }
}