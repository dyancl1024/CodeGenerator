using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingDynamic ( RH_TrainingDynamic ) BL类
    ///</summary>
    public class TrainingDynamicBL
    {

        /// <summary>
        /// 添加RH_TrainingDynamic
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingDynamic(TrainingDynamicEntity info)
        {
            return TrainingDynamicDB.AddTrainingDynamic(info);
        }


        /// <summary>
        /// 修改RH_TrainingDynamic
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingDynamic(TrainingDynamicEntity info)
        {
            return TrainingDynamicDB.ModifyTrainingDynamic(info);
        }


        /// <summary>
        /// 删除RH_TrainingDynamic
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingDynamic(int ID)
        {
            return TrainingDynamicDB.RemoveTrainingDynamic(ID);
        }

        /// <summary>
        /// 查看RH_TrainingDynamic
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingDynamicEntity GetTrainingDynamicDetail(int ID)
        {
            return TrainingDynamicDB.GetTrainingDynamicDetail(ID);
        }
    }
}