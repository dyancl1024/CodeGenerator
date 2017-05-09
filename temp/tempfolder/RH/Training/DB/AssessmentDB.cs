using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Assessment ( RH_Assessment ) DB类
    ///</summary>
    public class AssessmentDB
    {

        /// <summary>
        /// 添加RH_Assessment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddAssessment(AssessmentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_AName",info.AName);
            param.Add("@i_ADesc",info.ADesc);
            param.Add("@i_Status",info.Status);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Assessment_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Assessment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyAssessment(AssessmentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_AName",info.AName);
            param.Add("@i_ADesc",info.ADesc);
            param.Add("@i_Status",info.Status);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Assessment_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Assessment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveAssessment(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Assessment_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Assessment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentInfo GetAssessmentDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_Assessment_Detail", param, DBConnEnm.TRDBWrite);

            return (AssessmentInfo)ORMapping.MapSingleObject(typeof(AssessmentInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_Assessment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentEntityListResult GetAssessmentEntityList(AssessmentSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_Assessment_List", param, DBConnEnm.TRDBWrite);

            AssessmentEntityListResult Result= new AssessmentEntityListResult();
            Result.AssessmentList = (List<AssessmentInfo>)ORMapping.MapListObject(typeof(AssessmentInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}