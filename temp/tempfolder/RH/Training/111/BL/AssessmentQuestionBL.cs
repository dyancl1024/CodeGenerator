using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_AssessmentQuestion ( RH_AssessmentQuestion ) BL类
    ///</summary>
    public class AssessmentQuestionBL
    {

        /// <summary>
        /// 添加RH_AssessmentQuestion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddAssessmentQuestion(AssessmentQuestionEntity info)
        {
            return AssessmentQuestionDB.AddAssessmentQuestion(info);
        }


        /// <summary>
        /// 修改RH_AssessmentQuestion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyAssessmentQuestion(AssessmentQuestionEntity info)
        {
            return AssessmentQuestionDB.ModifyAssessmentQuestion(info);
        }


        /// <summary>
        /// 删除RH_AssessmentQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveAssessmentQuestion(int ID)
        {
            return AssessmentQuestionDB.RemoveAssessmentQuestion(ID);
        }

        /// <summary>
        /// 查看RH_AssessmentQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentQuestionEntity GetAssessmentQuestionDetail(int ID)
        {
            return AssessmentQuestionDB.GetAssessmentQuestionDetail(ID);
        }
    }
}