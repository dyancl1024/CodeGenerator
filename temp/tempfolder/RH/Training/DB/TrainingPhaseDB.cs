using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingPhase ( RH_TrainingPhase ) DB类
    ///</summary>
    public class TrainingPhaseDB
    {

        /// <summary>
        /// 添加RH_TrainingPhase
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingPhase(TrainingPhaseEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_PType",info.PType);
            param.Add("@i_HomeName",info.HomeName);
            param.Add("@i_HomeWorkDesc",info.HomeWorkDesc);
            param.Add("@i_HomeWorkCode",info.HomeWorkCode);
            param.Add("@i_Phase",info.Phase);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingPhase_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingPhase
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingPhase(TrainingPhaseEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_PType",info.PType);
            param.Add("@i_HomeName",info.HomeName);
            param.Add("@i_HomeWorkDesc",info.HomeWorkDesc);
            param.Add("@i_HomeWorkCode",info.HomeWorkCode);
            param.Add("@i_Phase",info.Phase);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingPhase_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingPhase
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingPhase(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingPhase_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingPhase
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingPhaseInfo GetTrainingPhaseDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingPhase_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingPhaseInfo)ORMapping.MapSingleObject(typeof(TrainingPhaseInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingPhase
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingPhaseEntityListResult GetTrainingPhaseEntityList(TrainingPhaseSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingPhase_List", param, DBConnEnm.TRDBWrite);

            TrainingPhaseEntityListResult Result= new TrainingPhaseEntityListResult();
            Result.TrainingPhaseList = (List<TrainingPhaseInfo>)ORMapping.MapListObject(typeof(TrainingPhaseInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}