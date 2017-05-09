using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_AssessmentOptions ( RH_AssessmentOptions ) DB类
    ///</summary>
    public class AssessmentOptionsDB
    {

        /// <summary>
        /// 添加RH_AssessmentOptions
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddAssessmentOptions(AssessmentOptionsEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_QID",info.QID);
            param.Add("@i_Options",info.Options);
            param.Add("@i_SortNO",info.SortNO);
            param.Add("@i_Score",info.Score);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_AssessmentOptions_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_AssessmentOptions
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyAssessmentOptions(AssessmentOptionsEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_QID",info.QID);
            param.Add("@i_Options",info.Options);
            param.Add("@i_SortNO",info.SortNO);
            param.Add("@i_Score",info.Score);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_AssessmentOptions_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_AssessmentOptions
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveAssessmentOptions(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_AssessmentOptions_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_AssessmentOptions
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentOptionsInfo GetAssessmentOptionsDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_AssessmentOptions_Detail", param, DBConnEnm.TRDBWrite);

            return (AssessmentOptionsInfo)ORMapping.MapSingleObject(typeof(AssessmentOptionsInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_AssessmentOptions
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentOptionsEntityListResult GetAssessmentOptionsEntityList(AssessmentOptionsSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_AssessmentOptions_List", param, DBConnEnm.TRDBWrite);

            AssessmentOptionsEntityListResult Result= new AssessmentOptionsEntityListResult();
            Result.AssessmentOptionsList = (List<AssessmentOptionsInfo>)ORMapping.MapListObject(typeof(AssessmentOptionsInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}