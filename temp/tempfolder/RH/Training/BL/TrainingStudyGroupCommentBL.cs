using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingStudyGroupComment ( RH_TrainingStudyGroupComment ) BL类
    ///</summary>
    public class TrainingStudyGroupCommentBL
    {

        /// <summary>
        /// 添加RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingStudyGroupComment(TrainingStudyGroupCommentEntity info)
        {
            return TrainingStudyGroupCommentDB.AddTrainingStudyGroupComment(info);
        }


        /// <summary>
        /// 修改RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingStudyGroupComment(TrainingStudyGroupCommentEntity info)
        {
            return TrainingStudyGroupCommentDB.ModifyTrainingStudyGroupComment(info);
        }


        /// <summary>
        /// 删除RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingStudyGroupComment(int ID)
        {
            return TrainingStudyGroupCommentDB.RemoveTrainingStudyGroupComment(ID);
        }

        /// <summary>
        /// 查看RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingStudyGroupCommentEntity GetTrainingStudyGroupCommentDetail(int ID)
        {
            return TrainingStudyGroupCommentDB.GetTrainingStudyGroupCommentDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingStudyGroupCommentEntityListResult GetTrainingStudyGroupCommentEntityList(TrainingStudyGroupCommentSearcher Searcher)
        {
            return TrainingStudyGroupCommentDB.GetTrainingStudyGroupCommentEntityList(Searcher);
        }
    }
}