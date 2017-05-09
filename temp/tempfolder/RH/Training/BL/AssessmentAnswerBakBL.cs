using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_AssessmentAnswerBak ( RH_AssessmentAnswerBak ) BL类
    ///</summary>
    public class AssessmentAnswerBakBL
    {

        /// <summary>
        /// 添加RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddAssessmentAnswerBak(AssessmentAnswerBakEntity info)
        {
            return AssessmentAnswerBakDB.AddAssessmentAnswerBak(info);
        }


        /// <summary>
        /// 修改RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyAssessmentAnswerBak(AssessmentAnswerBakEntity info)
        {
            return AssessmentAnswerBakDB.ModifyAssessmentAnswerBak(info);
        }


        /// <summary>
        /// 删除RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveAssessmentAnswerBak(int ID)
        {
            return AssessmentAnswerBakDB.RemoveAssessmentAnswerBak(ID);
        }

        /// <summary>
        /// 查看RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentAnswerBakEntity GetAssessmentAnswerBakDetail(int ID)
        {
            return AssessmentAnswerBakDB.GetAssessmentAnswerBakDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentAnswerBakEntityListResult GetAssessmentAnswerBakEntityList(AssessmentAnswerBakSearcher Searcher)
        {
            return AssessmentAnswerBakDB.GetAssessmentAnswerBakEntityList(Searcher);
        }
    }
}