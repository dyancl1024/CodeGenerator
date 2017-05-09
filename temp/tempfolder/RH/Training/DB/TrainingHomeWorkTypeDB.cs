using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingHomeWorkType ( RH_TrainingHomeWorkType ) DB类
    ///</summary>
    public class TrainingHomeWorkTypeDB
    {

        /// <summary>
        /// 添加RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingHomeWorkType(TrainingHomeWorkTypeEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_Name",info.Name);
            param.Add("@i_Code",info.Code);
            param.Add("@i_Sort",info.Sort);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingHomeWorkType_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingHomeWorkType(TrainingHomeWorkTypeEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_Name",info.Name);
            param.Add("@i_Code",info.Code);
            param.Add("@i_Sort",info.Sort);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingHomeWorkType_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingHomeWorkType(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingHomeWorkType_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingHomeWorkTypeInfo GetTrainingHomeWorkTypeDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingHomeWorkType_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingHomeWorkTypeInfo)ORMapping.MapSingleObject(typeof(TrainingHomeWorkTypeInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingHomeWorkTypeEntityListResult GetTrainingHomeWorkTypeEntityList(TrainingHomeWorkTypeSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingHomeWorkType_List", param, DBConnEnm.TRDBWrite);

            TrainingHomeWorkTypeEntityListResult Result= new TrainingHomeWorkTypeEntityListResult();
            Result.TrainingHomeWorkTypeList = (List<TrainingHomeWorkTypeInfo>)ORMapping.MapListObject(typeof(TrainingHomeWorkTypeInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}