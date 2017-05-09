using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingExpertQAComment ( RH_TrainingExpertQAComment ) BL类
    ///</summary>
    public class TrainingExpertQACommentBL
    {

        /// <summary>
        /// 添加RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingExpertQAComment(TrainingExpertQACommentEntity info)
        {
            return TrainingExpertQACommentDB.AddTrainingExpertQAComment(info);
        }


        /// <summary>
        /// 修改RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingExpertQAComment(TrainingExpertQACommentEntity info)
        {
            return TrainingExpertQACommentDB.ModifyTrainingExpertQAComment(info);
        }


        /// <summary>
        /// 删除RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingExpertQAComment(int ID)
        {
            return TrainingExpertQACommentDB.RemoveTrainingExpertQAComment(ID);
        }

        /// <summary>
        /// 查看RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingExpertQACommentEntity GetTrainingExpertQACommentDetail(int ID)
        {
            return TrainingExpertQACommentDB.GetTrainingExpertQACommentDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingExpertQACommentEntityListResult GetTrainingExpertQACommentEntityList(TrainingExpertQACommentSearcher Searcher)
        {
            return TrainingExpertQACommentDB.GetTrainingExpertQACommentEntityList(Searcher);
        }
    }
}