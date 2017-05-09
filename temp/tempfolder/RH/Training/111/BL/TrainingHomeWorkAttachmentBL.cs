using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingHomeWorkAttachment ( RH_TrainingHomeWorkAttachment ) BL类
    ///</summary>
    public class TrainingHomeWorkAttachmentBL
    {

        /// <summary>
        /// 添加RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingHomeWorkAttachment(TrainingHomeWorkAttachmentEntity info)
        {
            return TrainingHomeWorkAttachmentDB.AddTrainingHomeWorkAttachment(info);
        }


        /// <summary>
        /// 修改RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingHomeWorkAttachment(TrainingHomeWorkAttachmentEntity info)
        {
            return TrainingHomeWorkAttachmentDB.ModifyTrainingHomeWorkAttachment(info);
        }


        /// <summary>
        /// 删除RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingHomeWorkAttachment(int ID)
        {
            return TrainingHomeWorkAttachmentDB.RemoveTrainingHomeWorkAttachment(ID);
        }

        /// <summary>
        /// 查看RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingHomeWorkAttachmentEntity GetTrainingHomeWorkAttachmentDetail(int ID)
        {
            return TrainingHomeWorkAttachmentDB.GetTrainingHomeWorkAttachmentDetail(ID);
        }
    }
}