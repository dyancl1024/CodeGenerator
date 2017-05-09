using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TrainingClassRule ( RH_TrainingClassRule ) BL类
    ///</summary>
    public class TrainingClassRuleBL
    {

        /// <summary>
        /// 添加RH_TrainingClassRule
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingClassRule(TrainingClassRuleEntity info)
        {
            return TrainingClassRuleDB.AddTrainingClassRule(info);
        }


        /// <summary>
        /// 修改RH_TrainingClassRule
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingClassRule(TrainingClassRuleEntity info)
        {
            return TrainingClassRuleDB.ModifyTrainingClassRule(info);
        }


        /// <summary>
        /// 删除RH_TrainingClassRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingClassRule(int ID)
        {
            return TrainingClassRuleDB.RemoveTrainingClassRule(ID);
        }

        /// <summary>
        /// 查看RH_TrainingClassRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassRuleEntity GetTrainingClassRuleDetail(int ID)
        {
            return TrainingClassRuleDB.GetTrainingClassRuleDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_TrainingClassRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassRuleEntityListResult GetTrainingClassRuleEntityList(TrainingClassRuleSearcher Searcher)
        {
            return TrainingClassRuleDB.GetTrainingClassRuleEntityList(Searcher);
        }
    }
}