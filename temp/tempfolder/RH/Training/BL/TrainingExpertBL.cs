using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingExpert ( RH_TrainingExpert ) BL类
    ///</summary>
    public class TrainingExpertBL
    {

        /// <summary>
        /// 添加RH_TrainingExpert
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingExpert(TrainingExpertEntity info)
        {
            return TrainingExpertDB.AddTrainingExpert(info);
        }


        /// <summary>
        /// 修改RH_TrainingExpert
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingExpert(TrainingExpertEntity info)
        {
            return TrainingExpertDB.ModifyTrainingExpert(info);
        }


        /// <summary>
        /// 删除RH_TrainingExpert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingExpert(int ID)
        {
            return TrainingExpertDB.RemoveTrainingExpert(ID);
        }

        /// <summary>
        /// 查看RH_TrainingExpert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingExpertEntity GetTrainingExpertDetail(int ID)
        {
            return TrainingExpertDB.GetTrainingExpertDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingExpert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingExpertEntityListResult GetTrainingExpertEntityList(TrainingExpertSearcher Searcher)
        {
            return TrainingExpertDB.GetTrainingExpertEntityList(Searcher);
        }
    }
}