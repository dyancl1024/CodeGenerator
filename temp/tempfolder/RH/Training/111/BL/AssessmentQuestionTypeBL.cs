using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_AssessmentQuestionType ( RH_AssessmentQuestionType ) BL类
    ///</summary>
    public class AssessmentQuestionTypeBL
    {

        /// <summary>
        /// 添加RH_AssessmentQuestionType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddAssessmentQuestionType(AssessmentQuestionTypeEntity info)
        {
            return AssessmentQuestionTypeDB.AddAssessmentQuestionType(info);
        }


        /// <summary>
        /// 修改RH_AssessmentQuestionType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyAssessmentQuestionType(AssessmentQuestionTypeEntity info)
        {
            return AssessmentQuestionTypeDB.ModifyAssessmentQuestionType(info);
        }


        /// <summary>
        /// 删除RH_AssessmentQuestionType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveAssessmentQuestionType(int ID)
        {
            return AssessmentQuestionTypeDB.RemoveAssessmentQuestionType(ID);
        }

        /// <summary>
        /// 查看RH_AssessmentQuestionType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentQuestionTypeEntity GetAssessmentQuestionTypeDetail(int ID)
        {
            return AssessmentQuestionTypeDB.GetAssessmentQuestionTypeDetail(ID);
        }
    }
}