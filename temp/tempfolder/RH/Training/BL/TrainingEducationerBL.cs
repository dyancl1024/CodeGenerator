using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingEducationer ( RH_TrainingEducationer ) BL类
    ///</summary>
    public class TrainingEducationerBL
    {

        /// <summary>
        /// 添加RH_TrainingEducationer
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingEducationer(TrainingEducationerEntity info)
        {
            return TrainingEducationerDB.AddTrainingEducationer(info);
        }


        /// <summary>
        /// 修改RH_TrainingEducationer
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingEducationer(TrainingEducationerEntity info)
        {
            return TrainingEducationerDB.ModifyTrainingEducationer(info);
        }


        /// <summary>
        /// 删除RH_TrainingEducationer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingEducationer(int ID)
        {
            return TrainingEducationerDB.RemoveTrainingEducationer(ID);
        }

        /// <summary>
        /// 查看RH_TrainingEducationer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingEducationerEntity GetTrainingEducationerDetail(int ID)
        {
            return TrainingEducationerDB.GetTrainingEducationerDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingEducationer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingEducationerEntityListResult GetTrainingEducationerEntityList(TrainingEducationerSearcher Searcher)
        {
            return TrainingEducationerDB.GetTrainingEducationerEntityList(Searcher);
        }
    }
}