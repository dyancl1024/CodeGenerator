using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_AssessmentAnswerBak ( RH_AssessmentAnswerBak ) DB类
    ///</summary>
    public class AssessmentAnswerBakDB
    {

        /// <summary>
        /// 添加RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddAssessmentAnswerBak(AssessmentAnswerBakEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_QID",info.QID);
            param.Add("@i_QType",info.QType);
            param.Add("@i_OptionID",info.OptionID);
            param.Add("@i_Score",info.Score);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_AssessmentAnswerBak_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyAssessmentAnswerBak(AssessmentAnswerBakEntity info)
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
            MySqlDBLib.ExecuteSP("sp_SJ_RH_AssessmentAnswerBak_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveAssessmentAnswerBak(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_AssessmentAnswerBak_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentAnswerBakInfo GetAssessmentAnswerBakDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_AssessmentAnswerBak_Detail", param, DBConnEnm.TRDBWrite);

            return (AssessmentAnswerBakInfo)ORMapping.MapSingleObject(typeof(AssessmentAnswerBakInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_AssessmentAnswerBak
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentAnswerBakEntityListResult GetAssessmentAnswerBakEntityList(AssessmentAnswerBakSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_AssessmentAnswerBak_List", param, DBConnEnm.TRDBWrite);

            AssessmentAnswerBakEntityListResult Result= new AssessmentAnswerBakEntityListResult();
            Result.AssessmentAnswerBakList = (List<AssessmentAnswerBakInfo>)ORMapping.MapListObject(typeof(AssessmentAnswerBakInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}