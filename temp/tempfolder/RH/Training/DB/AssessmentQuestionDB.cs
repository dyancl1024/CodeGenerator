using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_AssessmentQuestion ( RH_AssessmentQuestion ) DB类
    ///</summary>
    public class AssessmentQuestionDB
    {

        /// <summary>
        /// 添加RH_AssessmentQuestion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddAssessmentQuestion(AssessmentQuestionEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_AssessmentID",info.AssessmentID);
            param.Add("@i_Question",info.Question);
            param.Add("@i_QuestionDesc",info.QuestionDesc);
            param.Add("@i_TypeID",info.TypeID);
            param.Add("@i_Dimensions",info.Dimensions);
            param.Add("@i_SortNo",info.SortNo);
            param.Add("@i_Status",info.Status);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_AssessmentQuestion_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_AssessmentQuestion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyAssessmentQuestion(AssessmentQuestionEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_AssessmentID",info.AssessmentID);
            param.Add("@i_Question",info.Question);
            param.Add("@i_QuestionDesc",info.QuestionDesc);
            param.Add("@i_TypeID",info.TypeID);
            param.Add("@i_Dimensions",info.Dimensions);
            param.Add("@i_SortNo",info.SortNo);
            param.Add("@i_Status",info.Status);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_AssessmentQuestion_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_AssessmentQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveAssessmentQuestion(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_AssessmentQuestion_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_AssessmentQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentQuestionInfo GetAssessmentQuestionDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_AssessmentQuestion_Detail", param, DBConnEnm.TRDBWrite);

            return (AssessmentQuestionInfo)ORMapping.MapSingleObject(typeof(AssessmentQuestionInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_AssessmentQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentQuestionEntityListResult GetAssessmentQuestionEntityList(AssessmentQuestionSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_AssessmentQuestion_List", param, DBConnEnm.TRDBWrite);

            AssessmentQuestionEntityListResult Result= new AssessmentQuestionEntityListResult();
            Result.AssessmentQuestionList = (List<AssessmentQuestionInfo>)ORMapping.MapListObject(typeof(AssessmentQuestionInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}