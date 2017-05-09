using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_AssessmentOptions ( RH_AssessmentOptions ) BL类
    ///</summary>
    public class AssessmentOptionsBL
    {

        /// <summary>
        /// 添加RH_AssessmentOptions
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddAssessmentOptions(AssessmentOptionsEntity info)
        {
            return AssessmentOptionsDB.AddAssessmentOptions(info);
        }


        /// <summary>
        /// 修改RH_AssessmentOptions
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyAssessmentOptions(AssessmentOptionsEntity info)
        {
            return AssessmentOptionsDB.ModifyAssessmentOptions(info);
        }


        /// <summary>
        /// 删除RH_AssessmentOptions
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveAssessmentOptions(int ID)
        {
            return AssessmentOptionsDB.RemoveAssessmentOptions(ID);
        }

        /// <summary>
        /// 查看RH_AssessmentOptions
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentOptionsEntity GetAssessmentOptionsDetail(int ID)
        {
            return AssessmentOptionsDB.GetAssessmentOptionsDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_AssessmentOptions
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentOptionsEntityListResult GetAssessmentOptionsEntityList(AssessmentOptionsSearcher Searcher)
        {
            return AssessmentOptionsDB.GetAssessmentOptionsEntityList(Searcher);
        }
    }
}