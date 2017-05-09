using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingStudyStatus ( RH_TrainingStudyStatus ) DB类
    ///</summary>
    public class TrainingStudyStatusDB
    {

        /// <summary>
        /// 添加RH_TrainingStudyStatus
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingStudyStatus(TrainingStudyStatusEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PCID",info.PCID);
            param.Add("@i_CID",info.CID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_Status",info.Status);
            param.Add("@i_UserID",info.UserID);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingStudyStatus_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingStudyStatus
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingStudyStatus(TrainingStudyStatusEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_PCID",info.PCID);
            param.Add("@i_CID",info.CID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_Status",info.Status);
            param.Add("@i_UserID",info.UserID);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingStudyStatus_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingStudyStatus
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingStudyStatus(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingStudyStatus_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingStudyStatus
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingStudyStatusInfo GetTrainingStudyStatusDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingStudyStatus_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingStudyStatusInfo)ORMapping.MapSingleObject(typeof(TrainingStudyStatusInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingStudyStatus
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingStudyStatusEntityListResult GetTrainingStudyStatusEntityList(TrainingStudyStatusSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingStudyStatus_List", param, DBConnEnm.TRDBWrite);

            TrainingStudyStatusEntityListResult Result= new TrainingStudyStatusEntityListResult();
            Result.TrainingStudyStatusList = (List<TrainingStudyStatusInfo>)ORMapping.MapListObject(typeof(TrainingStudyStatusInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}