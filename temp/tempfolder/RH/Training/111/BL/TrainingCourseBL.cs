using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingCourse ( RH_TrainingCourse ) BL类
    ///</summary>
    public class TrainingCourseBL
    {

        /// <summary>
        /// 添加RH_TrainingCourse
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingCourse(TrainingCourseEntity info)
        {
            return TrainingCourseDB.AddTrainingCourse(info);
        }


        /// <summary>
        /// 修改RH_TrainingCourse
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingCourse(TrainingCourseEntity info)
        {
            return TrainingCourseDB.ModifyTrainingCourse(info);
        }


        /// <summary>
        /// 删除RH_TrainingCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingCourse(int ID)
        {
            return TrainingCourseDB.RemoveTrainingCourse(ID);
        }

        /// <summary>
        /// 查看RH_TrainingCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingCourseEntity GetTrainingCourseDetail(int ID)
        {
            return TrainingCourseDB.GetTrainingCourseDetail(ID);
        }
    }
}