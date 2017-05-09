using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingStudyGroup ( RH_TrainingStudyGroup ) BL类
    ///</summary>
    public class TrainingStudyGroupBL
    {

        /// <summary>
        /// 添加RH_TrainingStudyGroup
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingStudyGroup(TrainingStudyGroupEntity info)
        {
            return TrainingStudyGroupDB.AddTrainingStudyGroup(info);
        }


        /// <summary>
        /// 修改RH_TrainingStudyGroup
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingStudyGroup(TrainingStudyGroupEntity info)
        {
            return TrainingStudyGroupDB.ModifyTrainingStudyGroup(info);
        }


        /// <summary>
        /// 删除RH_TrainingStudyGroup
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingStudyGroup(int ID)
        {
            return TrainingStudyGroupDB.RemoveTrainingStudyGroup(ID);
        }

        /// <summary>
        /// 查看RH_TrainingStudyGroup
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingStudyGroupEntity GetTrainingStudyGroupDetail(int ID)
        {
            return TrainingStudyGroupDB.GetTrainingStudyGroupDetail(ID);
        }
    }
}