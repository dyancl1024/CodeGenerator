using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingOther ( RH_TrainingOther ) BL类
    ///</summary>
    public class TrainingOtherBL
    {

        /// <summary>
        /// 添加RH_TrainingOther
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingOther(TrainingOtherEntity info)
        {
            return TrainingOtherDB.AddTrainingOther(info);
        }


        /// <summary>
        /// 修改RH_TrainingOther
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingOther(TrainingOtherEntity info)
        {
            return TrainingOtherDB.ModifyTrainingOther(info);
        }


        /// <summary>
        /// 删除RH_TrainingOther
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingOther(int ID)
        {
            return TrainingOtherDB.RemoveTrainingOther(ID);
        }

        /// <summary>
        /// 查看RH_TrainingOther
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingOtherEntity GetTrainingOtherDetail(int ID)
        {
            return TrainingOtherDB.GetTrainingOtherDetail(ID);
        }
    }
}