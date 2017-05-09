using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_AssessmentQuestionType ( RH_AssessmentQuestionType ) DB类
    ///</summary>
    public class AssessmentQuestionTypeDB
    {

        /// <summary>
        /// 添加RH_AssessmentQuestionType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddAssessmentQuestionType(AssessmentQuestionTypeEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_TypeName",info.TypeName);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_AssessmentQuestionType_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_AssessmentQuestionType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyAssessmentQuestionType(AssessmentQuestionTypeEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_TypeName",info.TypeName);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_AssessmentQuestionType_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_AssessmentQuestionType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveAssessmentQuestionType(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_AssessmentQuestionType_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_AssessmentQuestionType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentQuestionTypeInfo GetAssessmentQuestionTypeDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_AssessmentQuestionType_Detail", param, DBConnEnm.TRDBWrite);

            return (AssessmentQuestionTypeInfo)ORMapping.MapSingleObject(typeof(AssessmentQuestionTypeInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_AssessmentQuestionType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static AssessmentQuestionTypeEntityListResult GetAssessmentQuestionTypeEntityList(AssessmentQuestionTypeSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_AssessmentQuestionType_List", param, DBConnEnm.TRDBWrite);

            AssessmentQuestionTypeEntityListResult Result= new AssessmentQuestionTypeEntityListResult();
            Result.AssessmentQuestionTypeList = (List<AssessmentQuestionTypeInfo>)ORMapping.MapListObject(typeof(AssessmentQuestionTypeInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}