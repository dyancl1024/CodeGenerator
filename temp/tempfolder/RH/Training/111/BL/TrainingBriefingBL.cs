using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingBriefing ( RH_TrainingBriefing ) BL类
    ///</summary>
    public class TrainingBriefingBL
    {

        /// <summary>
        /// 添加RH_TrainingBriefing
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingBriefing(TrainingBriefingEntity info)
        {
            return TrainingBriefingDB.AddTrainingBriefing(info);
        }


        /// <summary>
        /// 修改RH_TrainingBriefing
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingBriefing(TrainingBriefingEntity info)
        {
            return TrainingBriefingDB.ModifyTrainingBriefing(info);
        }


        /// <summary>
        /// 删除RH_TrainingBriefing
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingBriefing(int ID)
        {
            return TrainingBriefingDB.RemoveTrainingBriefing(ID);
        }

        /// <summary>
        /// 查看RH_TrainingBriefing
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingBriefingEntity GetTrainingBriefingDetail(int ID)
        {
            return TrainingBriefingDB.GetTrainingBriefingDetail(ID);
        }
    }
}