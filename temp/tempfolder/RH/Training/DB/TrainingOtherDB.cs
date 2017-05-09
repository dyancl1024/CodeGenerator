using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingOther ( RH_TrainingOther ) DB类
    ///</summary>
    public class TrainingOtherDB
    {

        /// <summary>
        /// 添加RH_TrainingOther
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingOther(TrainingOtherEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_TID",info.TID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_TTitle",info.TTitle);
            param.Add("@i_TType",info.TType);
            param.Add("@i_TContent",info.TContent);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingOther_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingOther
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingOther(TrainingOtherEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_TID",info.TID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_TTitle",info.TTitle);
            param.Add("@i_TType",info.TType);
            param.Add("@i_TContent",info.TContent);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingOther_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingOther
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingOther(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingOther_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingOther
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingOtherInfo GetTrainingOtherDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingOther_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingOtherInfo)ORMapping.MapSingleObject(typeof(TrainingOtherInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingOther
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingOtherEntityListResult GetTrainingOtherEntityList(TrainingOtherSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingOther_List", param, DBConnEnm.TRDBWrite);

            TrainingOtherEntityListResult Result= new TrainingOtherEntityListResult();
            Result.TrainingOtherList = (List<TrainingOtherInfo>)ORMapping.MapListObject(typeof(TrainingOtherInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}