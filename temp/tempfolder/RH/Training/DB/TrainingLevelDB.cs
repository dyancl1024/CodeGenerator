using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingLevel ( RH_TrainingLevel ) DB类
    ///</summary>
    public class TrainingLevelDB
    {

        /// <summary>
        /// 添加RH_TrainingLevel
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingLevel(TrainingLevelEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_Name",info.Name);
            param.Add("@i_Code",info.Code);
            param.Add("@i_Sort",info.Sort);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingLevel_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingLevel
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingLevel(TrainingLevelEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_Name",info.Name);
            param.Add("@i_Code",info.Code);
            param.Add("@i_Sort",info.Sort);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingLevel_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingLevel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingLevel(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingLevel_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingLevel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingLevelInfo GetTrainingLevelDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingLevel_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingLevelInfo)ORMapping.MapSingleObject(typeof(TrainingLevelInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingLevel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingLevelEntityListResult GetTrainingLevelEntityList(TrainingLevelSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingLevel_List", param, DBConnEnm.TRDBWrite);

            TrainingLevelEntityListResult Result= new TrainingLevelEntityListResult();
            Result.TrainingLevelList = (List<TrainingLevelInfo>)ORMapping.MapListObject(typeof(TrainingLevelInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}