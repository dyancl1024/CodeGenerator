using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingExpertQA ( RH_TrainingExpertQA ) BL类
    ///</summary>
    public class TrainingExpertQABL
    {

        /// <summary>
        /// 添加RH_TrainingExpertQA
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingExpertQA(TrainingExpertQAEntity info)
        {
            return TrainingExpertQADB.AddTrainingExpertQA(info);
        }


        /// <summary>
        /// 修改RH_TrainingExpertQA
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingExpertQA(TrainingExpertQAEntity info)
        {
            return TrainingExpertQADB.ModifyTrainingExpertQA(info);
        }


        /// <summary>
        /// 删除RH_TrainingExpertQA
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingExpertQA(int ID)
        {
            return TrainingExpertQADB.RemoveTrainingExpertQA(ID);
        }

        /// <summary>
        /// 查看RH_TrainingExpertQA
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingExpertQAEntity GetTrainingExpertQADetail(int ID)
        {
            return TrainingExpertQADB.GetTrainingExpertQADetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingExpertQA
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingExpertQAEntityListResult GetTrainingExpertQAEntityList(TrainingExpertQASearcher Searcher)
        {
            return TrainingExpertQADB.GetTrainingExpertQAEntityList(Searcher);
        }
    }
}