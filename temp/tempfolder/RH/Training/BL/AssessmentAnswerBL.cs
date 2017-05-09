using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_AssessmentAnswer ( RH_AssessmentAnswer ) BL类
    ///</summary>
    public class AssessmentAnswerBL
    {

        /// <summary>
        /// 添加RH_AssessmentAnswer
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddAssessmentAnswer(AssessmentAnswerEntity info)
        {
            return AssessmentAnswerDB.AddAssessmentAnswer(info);
        }


        /// <summary>
        /// 修改RH_AssessmentAnswer
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyAssessmentAnswer(AssessmentAnswerEntity info)
        {
            return AssessmentAnswerDB.ModifyAssessmentAnswer(info);
        }


        /// <summary>
        /// 删除RH_AssessmentAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveAssessmentAnswer(int ID)
        {
            return AssessmentAnswerDB.RemoveAssessmentAnswer(ID);
        }

        /// <summary>
        /// 查看RH_AssessmentAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentAnswerEntity GetAssessmentAnswerDetail(int ID)
        {
            return AssessmentAnswerDB.GetAssessmentAnswerDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_AssessmentAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentAnswerEntityListResult GetAssessmentAnswerEntityList(AssessmentAnswerSearcher Searcher)
        {
            return AssessmentAnswerDB.GetAssessmentAnswerEntityList(Searcher);
        }
    }
}