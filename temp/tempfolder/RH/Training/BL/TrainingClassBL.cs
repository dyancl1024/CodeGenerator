using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingClass ( RH_TrainingClass ) BL类
    ///</summary>
    public class TrainingClassBL
    {

        /// <summary>
        /// 添加RH_TrainingClass
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingClass(TrainingClassEntity info)
        {
            return TrainingClassDB.AddTrainingClass(info);
        }


        /// <summary>
        /// 修改RH_TrainingClass
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingClass(TrainingClassEntity info)
        {
            return TrainingClassDB.ModifyTrainingClass(info);
        }


        /// <summary>
        /// 删除RH_TrainingClass
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingClass(int ID)
        {
            return TrainingClassDB.RemoveTrainingClass(ID);
        }

        /// <summary>
        /// 查看RH_TrainingClass
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassEntity GetTrainingClassDetail(int ID)
        {
            return TrainingClassDB.GetTrainingClassDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingClass
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassEntityListResult GetTrainingClassEntityList(TrainingClassSearcher Searcher)
        {
            return TrainingClassDB.GetTrainingClassEntityList(Searcher);
        }
    }
}