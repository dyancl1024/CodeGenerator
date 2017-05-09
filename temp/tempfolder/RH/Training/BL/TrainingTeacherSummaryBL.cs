using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingTeacherSummary ( RH_TrainingTeacherSummary ) BL类
    ///</summary>
    public class TrainingTeacherSummaryBL
    {

        /// <summary>
        /// 添加RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingTeacherSummary(TrainingTeacherSummaryEntity info)
        {
            return TrainingTeacherSummaryDB.AddTrainingTeacherSummary(info);
        }


        /// <summary>
        /// 修改RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingTeacherSummary(TrainingTeacherSummaryEntity info)
        {
            return TrainingTeacherSummaryDB.ModifyTrainingTeacherSummary(info);
        }


        /// <summary>
        /// 删除RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingTeacherSummary(int ID)
        {
            return TrainingTeacherSummaryDB.RemoveTrainingTeacherSummary(ID);
        }

        /// <summary>
        /// 查看RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingTeacherSummaryEntity GetTrainingTeacherSummaryDetail(int ID)
        {
            return TrainingTeacherSummaryDB.GetTrainingTeacherSummaryDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingTeacherSummaryEntityListResult GetTrainingTeacherSummaryEntityList(TrainingTeacherSummarySearcher Searcher)
        {
            return TrainingTeacherSummaryDB.GetTrainingTeacherSummaryEntityList(Searcher);
        }
    }
}