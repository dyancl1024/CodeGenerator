using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingHomeWorkAudit ( RH_TrainingHomeWorkAudit ) DB类
    ///</summary>
    public class TrainingHomeWorkAuditDB
    {

        /// <summary>
        /// 添加RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingHomeWorkAudit(TrainingHomeWorkAuditEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_HomeWorkID",info.HomeWorkID);
            param.Add("@i_Auditor",info.Auditor);
            param.Add("@i_AuditTime",info.AuditTime);
            param.Add("@i_AuditDesc",info.AuditDesc);
            param.Add("@i_Status",info.Status);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingHomeWorkAudit_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingHomeWorkAudit(TrainingHomeWorkAuditEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_HomeWorkID",info.HomeWorkID);
            param.Add("@i_Auditor",info.Auditor);
            param.Add("@i_AuditTime",info.AuditTime);
            param.Add("@i_AuditDesc",info.AuditDesc);
            param.Add("@i_Status",info.Status);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingHomeWorkAudit_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingHomeWorkAudit(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingHomeWorkAudit_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingHomeWorkAuditInfo GetTrainingHomeWorkAuditDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingHomeWorkAudit_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingHomeWorkAuditInfo)ORMapping.MapSingleObject(typeof(TrainingHomeWorkAuditInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingHomeWorkAudit
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingHomeWorkAuditEntityListResult GetTrainingHomeWorkAuditEntityList(TrainingHomeWorkAuditSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingHomeWorkAudit_List", param, DBConnEnm.TRDBWrite);

            TrainingHomeWorkAuditEntityListResult Result= new TrainingHomeWorkAuditEntityListResult();
            Result.TrainingHomeWorkAuditList = (List<TrainingHomeWorkAuditInfo>)ORMapping.MapListObject(typeof(TrainingHomeWorkAuditInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}