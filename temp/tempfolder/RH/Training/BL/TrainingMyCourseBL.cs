using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingMyCourse ( RH_TrainingMyCourse ) BL类
    ///</summary>
    public class TrainingMyCourseBL
    {

        /// <summary>
        /// 添加RH_TrainingMyCourse
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingMyCourse(TrainingMyCourseEntity info)
        {
            return TrainingMyCourseDB.AddTrainingMyCourse(info);
        }


        /// <summary>
        /// 修改RH_TrainingMyCourse
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingMyCourse(TrainingMyCourseEntity info)
        {
            return TrainingMyCourseDB.ModifyTrainingMyCourse(info);
        }


        /// <summary>
        /// 删除RH_TrainingMyCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingMyCourse(int ID)
        {
            return TrainingMyCourseDB.RemoveTrainingMyCourse(ID);
        }

        /// <summary>
        /// 查看RH_TrainingMyCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingMyCourseEntity GetTrainingMyCourseDetail(int ID)
        {
            return TrainingMyCourseDB.GetTrainingMyCourseDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingMyCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingMyCourseEntityListResult GetTrainingMyCourseEntityList(TrainingMyCourseSearcher Searcher)
        {
            return TrainingMyCourseDB.GetTrainingMyCourseEntityList(Searcher);
        }
    }
}