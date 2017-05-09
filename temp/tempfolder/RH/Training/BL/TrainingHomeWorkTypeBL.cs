using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingHomeWorkType ( RH_TrainingHomeWorkType ) BL类
    ///</summary>
    public class TrainingHomeWorkTypeBL
    {

        /// <summary>
        /// 添加RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingHomeWorkType(TrainingHomeWorkTypeEntity info)
        {
            return TrainingHomeWorkTypeDB.AddTrainingHomeWorkType(info);
        }


        /// <summary>
        /// 修改RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingHomeWorkType(TrainingHomeWorkTypeEntity info)
        {
            return TrainingHomeWorkTypeDB.ModifyTrainingHomeWorkType(info);
        }


        /// <summary>
        /// 删除RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingHomeWorkType(int ID)
        {
            return TrainingHomeWorkTypeDB.RemoveTrainingHomeWorkType(ID);
        }

        /// <summary>
        /// 查看RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingHomeWorkTypeEntity GetTrainingHomeWorkTypeDetail(int ID)
        {
            return TrainingHomeWorkTypeDB.GetTrainingHomeWorkTypeDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingHomeWorkTypeEntityListResult GetTrainingHomeWorkTypeEntityList(TrainingHomeWorkTypeSearcher Searcher)
        {
            return TrainingHomeWorkTypeDB.GetTrainingHomeWorkTypeEntityList(Searcher);
        }
    }
}