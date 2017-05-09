using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingBriefing ( RH_TrainingBriefing ) DB类
    ///</summary>
    public class TrainingBriefingDB
    {

        /// <summary>
        /// 添加RH_TrainingBriefing
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingBriefing(TrainingBriefingEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ObjectID",info.ObjectID);
            param.Add("@i_MType",info.MType);
            param.Add("@i_Periods",info.Periods);
            param.Add("@i_Title",info.Title);
            param.Add("@i_BContnet",info.BContnet);
            param.Add("@i_ClickNum",info.ClickNum);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.Add("@i_StaticUrl",info.StaticUrl);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingBriefing_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingBriefing
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingBriefing(TrainingBriefingEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_ObjectID",info.ObjectID);
            param.Add("@i_MType",info.MType);
            param.Add("@i_Periods",info.Periods);
            param.Add("@i_Title",info.Title);
            param.Add("@i_BContnet",info.BContnet);
            param.Add("@i_ClickNum",info.ClickNum);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.Add("@i_StaticUrl",info.StaticUrl);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingBriefing_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingBriefing
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingBriefing(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingBriefing_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingBriefing
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingBriefingInfo GetTrainingBriefingDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingBriefing_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingBriefingInfo)ORMapping.MapSingleObject(typeof(TrainingBriefingInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingBriefing
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingBriefingEntityListResult GetTrainingBriefingEntityList(TrainingBriefingSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingBriefing_List", param, DBConnEnm.TRDBWrite);

            TrainingBriefingEntityListResult Result= new TrainingBriefingEntityListResult();
            Result.TrainingBriefingList = (List<TrainingBriefingInfo>)ORMapping.MapListObject(typeof(TrainingBriefingInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}