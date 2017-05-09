using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingExcellent ( RH_TrainingExcellent ) BL类
    ///</summary>
    public class TrainingExcellentBL
    {

        /// <summary>
        /// 添加RH_TrainingExcellent
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingExcellent(TrainingExcellentEntity info)
        {
            return TrainingExcellentDB.AddTrainingExcellent(info);
        }


        /// <summary>
        /// 修改RH_TrainingExcellent
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingExcellent(TrainingExcellentEntity info)
        {
            return TrainingExcellentDB.ModifyTrainingExcellent(info);
        }


        /// <summary>
        /// 删除RH_TrainingExcellent
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingExcellent(int ID)
        {
            return TrainingExcellentDB.RemoveTrainingExcellent(ID);
        }

        /// <summary>
        /// 查看RH_TrainingExcellent
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingExcellentEntity GetTrainingExcellentDetail(int ID)
        {
            return TrainingExcellentDB.GetTrainingExcellentDetail(ID);
        }
    }
}