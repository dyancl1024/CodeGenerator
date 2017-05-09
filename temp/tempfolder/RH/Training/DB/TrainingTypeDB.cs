using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingType ( RH_TrainingType ) DB类
    ///</summary>
    public class TrainingTypeDB
    {

        /// <summary>
        /// 添加RH_TrainingType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingType(TrainingTypeEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_Name",info.Name);
            param.Add("@i_Code",info.Code);
            param.Add("@i_Sort",info.Sort);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingType_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingType(TrainingTypeEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_Name",info.Name);
            param.Add("@i_Code",info.Code);
            param.Add("@i_Sort",info.Sort);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingType_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingType(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingType_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingTypeInfo GetTrainingTypeDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingType_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingTypeInfo)ORMapping.MapSingleObject(typeof(TrainingTypeInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingTypeEntityListResult GetTrainingTypeEntityList(TrainingTypeSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingType_List", param, DBConnEnm.TRDBWrite);

            TrainingTypeEntityListResult Result= new TrainingTypeEntityListResult();
            Result.TrainingTypeList = (List<TrainingTypeInfo>)ORMapping.MapListObject(typeof(TrainingTypeInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}