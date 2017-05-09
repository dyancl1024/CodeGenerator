using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingOtherAttachment ( RH_TrainingOtherAttachment ) BL类
    ///</summary>
    public class TrainingOtherAttachmentBL
    {

        /// <summary>
        /// 添加RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingOtherAttachment(TrainingOtherAttachmentEntity info)
        {
            return TrainingOtherAttachmentDB.AddTrainingOtherAttachment(info);
        }


        /// <summary>
        /// 修改RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingOtherAttachment(TrainingOtherAttachmentEntity info)
        {
            return TrainingOtherAttachmentDB.ModifyTrainingOtherAttachment(info);
        }


        /// <summary>
        /// 删除RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingOtherAttachment(int ID)
        {
            return TrainingOtherAttachmentDB.RemoveTrainingOtherAttachment(ID);
        }

        /// <summary>
        /// 查看RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingOtherAttachmentEntity GetTrainingOtherAttachmentDetail(int ID)
        {
            return TrainingOtherAttachmentDB.GetTrainingOtherAttachmentDetail(ID);
        }
    }
}