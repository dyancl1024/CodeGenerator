using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_Training ( RH_Training ) BL类
    ///</summary>
    public class TrainingBL
    {

        /// <summary>
        /// 添加RH_Training
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTraining(TrainingEntity info)
        {
            return TrainingDB.AddTraining(info);
        }


        /// <summary>
        /// 修改RH_Training
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTraining(TrainingEntity info)
        {
            return TrainingDB.ModifyTraining(info);
        }


        /// <summary>
        /// 删除RH_Training
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTraining(int ID)
        {
            return TrainingDB.RemoveTraining(ID);
        }

        /// <summary>
        /// 查看RH_Training
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingEntity GetTrainingDetail(int ID)
        {
            return TrainingDB.GetTrainingDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_Training
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingEntityListResult GetTrainingEntityList(TrainingSearcher Searcher)
        {
            return TrainingDB.GetTrainingEntityList(Searcher);
        }
    }
}