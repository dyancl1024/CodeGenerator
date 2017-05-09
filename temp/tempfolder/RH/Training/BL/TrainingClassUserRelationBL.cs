using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingClassUserRelation ( RH_TrainingClassUserRelation ) BL类
    ///</summary>
    public class TrainingClassUserRelationBL
    {

        /// <summary>
        /// 添加RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingClassUserRelation(TrainingClassUserRelationEntity info)
        {
            return TrainingClassUserRelationDB.AddTrainingClassUserRelation(info);
        }


        /// <summary>
        /// 修改RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingClassUserRelation(TrainingClassUserRelationEntity info)
        {
            return TrainingClassUserRelationDB.ModifyTrainingClassUserRelation(info);
        }


        /// <summary>
        /// 删除RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingClassUserRelation(int ID)
        {
            return TrainingClassUserRelationDB.RemoveTrainingClassUserRelation(ID);
        }

        /// <summary>
        /// 查看RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassUserRelationEntity GetTrainingClassUserRelationDetail(int ID)
        {
            return TrainingClassUserRelationDB.GetTrainingClassUserRelationDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassUserRelationEntityListResult GetTrainingClassUserRelationEntityList(TrainingClassUserRelationSearcher Searcher)
        {
            return TrainingClassUserRelationDB.GetTrainingClassUserRelationEntityList(Searcher);
        }
    }
}