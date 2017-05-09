using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingPhase ( RH_TrainingPhase ) BL类
    ///</summary>
    public class TrainingPhaseBL
    {

        /// <summary>
        /// 添加RH_TrainingPhase
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingPhase(TrainingPhaseEntity info)
        {
            return TrainingPhaseDB.AddTrainingPhase(info);
        }


        /// <summary>
        /// 修改RH_TrainingPhase
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingPhase(TrainingPhaseEntity info)
        {
            return TrainingPhaseDB.ModifyTrainingPhase(info);
        }


        /// <summary>
        /// 删除RH_TrainingPhase
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingPhase(int ID)
        {
            return TrainingPhaseDB.RemoveTrainingPhase(ID);
        }

        /// <summary>
        /// 查看RH_TrainingPhase
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingPhaseEntity GetTrainingPhaseDetail(int ID)
        {
            return TrainingPhaseDB.GetTrainingPhaseDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingPhase
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingPhaseEntityListResult GetTrainingPhaseEntityList(TrainingPhaseSearcher Searcher)
        {
            return TrainingPhaseDB.GetTrainingPhaseEntityList(Searcher);
        }
    }
}