using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_AssessmentAnswer ( RH_AssessmentAnswer ) DB类
    ///</summary>
    public class AssessmentAnswerDB
    {

        /// <summary>
        /// 添加RH_AssessmentAnswer
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddAssessmentAnswer(AssessmentAnswerEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_QID",info.QID);
            param.Add("@i_QType",info.QType);
            param.Add("@i_OptionID",info.OptionID);
            param.Add("@i_Score",info.Score);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_AssessmentAnswer_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_AssessmentAnswer
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyAssessmentAnswer(AssessmentAnswerEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_QID",info.QID);
            param.Add("@i_QType",info.QType);
            param.Add("@i_OptionID",info.OptionID);
            param.Add("@i_Score",info.Score);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_AssessmentAnswer_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_AssessmentAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveAssessmentAnswer(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_AssessmentAnswer_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_AssessmentAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentAnswerInfo GetAssessmentAnswerDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_AssessmentAnswer_Detail", param, DBConnEnm.TRDBWrite);

            return (AssessmentAnswerInfo)ORMapping.MapSingleObject(typeof(AssessmentAnswerInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_AssessmentAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentAnswerEntityListResult GetAssessmentAnswerEntityList(AssessmentAnswerSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_AssessmentAnswer_List", param, DBConnEnm.TRDBWrite);

            AssessmentAnswerEntityListResult Result= new AssessmentAnswerEntityListResult();
            Result.AssessmentAnswerList = (List<AssessmentAnswerInfo>)ORMapping.MapListObject(typeof(AssessmentAnswerInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}