using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingBriefingComment ( RH_TrainingBriefingComment ) BL类
    ///</summary>
    public class TrainingBriefingCommentBL
    {

        /// <summary>
        /// 添加RH_TrainingBriefingComment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingBriefingComment(TrainingBriefingCommentEntity info)
        {
            return TrainingBriefingCommentDB.AddTrainingBriefingComment(info);
        }


        /// <summary>
        /// 修改RH_TrainingBriefingComment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingBriefingComment(TrainingBriefingCommentEntity info)
        {
            return TrainingBriefingCommentDB.ModifyTrainingBriefingComment(info);
        }


        /// <summary>
        /// 删除RH_TrainingBriefingComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingBriefingComment(int ID)
        {
            return TrainingBriefingCommentDB.RemoveTrainingBriefingComment(ID);
        }

        /// <summary>
        /// 查看RH_TrainingBriefingComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingBriefingCommentEntity GetTrainingBriefingCommentDetail(int ID)
        {
            return TrainingBriefingCommentDB.GetTrainingBriefingCommentDetail(ID);
        }
    }
}