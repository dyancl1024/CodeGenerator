using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_CourseQuestion ( RH_CourseQuestion ) BL类
    ///</summary>
    public class CourseQuestionBL
    {

        /// <summary>
        /// 添加RH_CourseQuestion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseQuestion(CourseQuestionEntity info)
        {
            return CourseQuestionDB.AddCourseQuestion(info);
        }


        /// <summary>
        /// 修改RH_CourseQuestion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseQuestion(CourseQuestionEntity info)
        {
            return CourseQuestionDB.ModifyCourseQuestion(info);
        }


        /// <summary>
        /// 删除RH_CourseQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseQuestion(int ID)
        {
            return CourseQuestionDB.RemoveCourseQuestion(ID);
        }

        /// <summary>
        /// 查看RH_CourseQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseQuestionEntity GetCourseQuestionDetail(int ID)
        {
            return CourseQuestionDB.GetCourseQuestionDetail(ID);
        }
    }
}