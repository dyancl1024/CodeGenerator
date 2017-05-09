using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingStudyGroupUser ( RH_TrainingStudyGroupUser ) BL类
    ///</summary>
    public class TrainingStudyGroupUserBL
    {

        /// <summary>
        /// 添加RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingStudyGroupUser(TrainingStudyGroupUserEntity info)
        {
            return TrainingStudyGroupUserDB.AddTrainingStudyGroupUser(info);
        }


        /// <summary>
        /// 修改RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingStudyGroupUser(TrainingStudyGroupUserEntity info)
        {
            return TrainingStudyGroupUserDB.ModifyTrainingStudyGroupUser(info);
        }


        /// <summary>
        /// 删除RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingStudyGroupUser(int ID)
        {
            return TrainingStudyGroupUserDB.RemoveTrainingStudyGroupUser(ID);
        }

        /// <summary>
        /// 查看RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingStudyGroupUserEntity GetTrainingStudyGroupUserDetail(int ID)
        {
            return TrainingStudyGroupUserDB.GetTrainingStudyGroupUserDetail(ID);
        }
    }
}