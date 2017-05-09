using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_Assessment ( RH_Assessment ) BL类
    ///</summary>
    public class AssessmentBL
    {

        /// <summary>
        /// 添加RH_Assessment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddAssessment(AssessmentEntity info)
        {
            return AssessmentDB.AddAssessment(info);
        }


        /// <summary>
        /// 修改RH_Assessment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyAssessment(AssessmentEntity info)
        {
            return AssessmentDB.ModifyAssessment(info);
        }


        /// <summary>
        /// 删除RH_Assessment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveAssessment(int ID)
        {
            return AssessmentDB.RemoveAssessment(ID);
        }

        /// <summary>
        /// 查看RH_Assessment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentEntity GetAssessmentDetail(int ID)
        {
            return AssessmentDB.GetAssessmentDetail(ID);
        }
    }
}