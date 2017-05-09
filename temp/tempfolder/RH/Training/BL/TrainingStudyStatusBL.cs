using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingStudyStatus ( RH_TrainingStudyStatus ) BL类
    ///</summary>
    public class TrainingStudyStatusBL
    {

        /// <summary>
        /// 添加RH_TrainingStudyStatus
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingStudyStatus(TrainingStudyStatusEntity info)
        {
            return TrainingStudyStatusDB.AddTrainingStudyStatus(info);
        }


        /// <summary>
        /// 修改RH_TrainingStudyStatus
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingStudyStatus(TrainingStudyStatusEntity info)
        {
            return TrainingStudyStatusDB.ModifyTrainingStudyStatus(info);
        }


        /// <summary>
        /// 删除RH_TrainingStudyStatus
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingStudyStatus(int ID)
        {
            return TrainingStudyStatusDB.RemoveTrainingStudyStatus(ID);
        }

        /// <summary>
        /// 查看RH_TrainingStudyStatus
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingStudyStatusEntity GetTrainingStudyStatusDetail(int ID)
        {
            return TrainingStudyStatusDB.GetTrainingStudyStatusDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingStudyStatus
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingStudyStatusEntityListResult GetTrainingStudyStatusEntityList(TrainingStudyStatusSearcher Searcher)
        {
            return TrainingStudyStatusDB.GetTrainingStudyStatusEntityList(Searcher);
        }
    }
}