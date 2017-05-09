using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingType ( RH_TrainingType ) BL类
    ///</summary>
    public class TrainingTypeBL
    {

        /// <summary>
        /// 添加RH_TrainingType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingType(TrainingTypeEntity info)
        {
            return TrainingTypeDB.AddTrainingType(info);
        }


        /// <summary>
        /// 修改RH_TrainingType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingType(TrainingTypeEntity info)
        {
            return TrainingTypeDB.ModifyTrainingType(info);
        }


        /// <summary>
        /// 删除RH_TrainingType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingType(int ID)
        {
            return TrainingTypeDB.RemoveTrainingType(ID);
        }

        /// <summary>
        /// 查看RH_TrainingType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingTypeEntity GetTrainingTypeDetail(int ID)
        {
            return TrainingTypeDB.GetTrainingTypeDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingTypeEntityListResult GetTrainingTypeEntityList(TrainingTypeSearcher Searcher)
        {
            return TrainingTypeDB.GetTrainingTypeEntityList(Searcher);
        }
    }
}