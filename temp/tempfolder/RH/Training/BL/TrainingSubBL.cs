using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingSub ( RH_TrainingSub ) BL类
    ///</summary>
    public class TrainingSubBL
    {

        /// <summary>
        /// 添加RH_TrainingSub
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingSub(TrainingSubEntity info)
        {
            return TrainingSubDB.AddTrainingSub(info);
        }


        /// <summary>
        /// 修改RH_TrainingSub
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingSub(TrainingSubEntity info)
        {
            return TrainingSubDB.ModifyTrainingSub(info);
        }


        /// <summary>
        /// 删除RH_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingSub(int ID)
        {
            return TrainingSubDB.RemoveTrainingSub(ID);
        }

        /// <summary>
        /// 查看RH_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingSubEntity GetTrainingSubDetail(int ID)
        {
            return TrainingSubDB.GetTrainingSubDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingSubEntityListResult GetTrainingSubEntityList(TrainingSubSearcher Searcher)
        {
            return TrainingSubDB.GetTrainingSubEntityList(Searcher);
        }
    }
}