using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingSub ( RH_TrainingSub ) DB类
    ///</summary>
    public class TrainingSubDB
    {

        /// <summary>
        /// 添加RH_TrainingSub
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingSub(TrainingSubEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_TID",info.TID);
            param.Add("@i_TName",info.TName);
            param.Add("@i_TrainingNum",info.TrainingNum);
            param.Add("@i_TrainingLevelCode",info.TrainingLevelCode);
            param.Add("@i_TrainingTypeCode",info.TrainingTypeCode);
            param.Add("@i_TMethod",info.TMethod);
            param.Add("@i_IsGP",info.IsGP);
            param.Add("@i_OrgCode",info.OrgCode);
            param.Add("@i_TrainingDateB",info.TrainingDateB);
            param.Add("@i_TrainingDateE",info.TrainingDateE);
            param.Add("@i_SignupRule",info.SignupRule);
            param.Add("@i_ClassRule",info.ClassRule);
            param.Add("@i_IsStage",info.IsStage);
            param.Add("@i_TrainingUrl",info.TrainingUrl);
            param.Add("@i_TrainingHeadImg",info.TrainingHeadImg);
            param.Add("@i_StaticUrl",info.StaticUrl);
            param.Add("@i_Status",info.Status);
            param.Add("@i_AskTel",info.AskTel);
            param.Add("@i_IsShowQQ",info.IsShowQQ);
            param.Add("@i_TestMethod",info.TestMethod);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.Add("@i_Publisher",info.Publisher);
            param.Add("@i_PublishDate",info.PublishDate);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingSub_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingSub
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingSub(TrainingSubEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_TID",info.TID);
            param.Add("@i_TName",info.TName);
            param.Add("@i_TrainingNum",info.TrainingNum);
            param.Add("@i_TrainingLevelCode",info.TrainingLevelCode);
            param.Add("@i_TrainingTypeCode",info.TrainingTypeCode);
            param.Add("@i_TMethod",info.TMethod);
            param.Add("@i_IsGP",info.IsGP);
            param.Add("@i_OrgCode",info.OrgCode);
            param.Add("@i_TrainingDateB",info.TrainingDateB);
            param.Add("@i_TrainingDateE",info.TrainingDateE);
            param.Add("@i_SignupRule",info.SignupRule);
            param.Add("@i_ClassRule",info.ClassRule);
            param.Add("@i_IsStage",info.IsStage);
            param.Add("@i_TrainingUrl",info.TrainingUrl);
            param.Add("@i_TrainingHeadImg",info.TrainingHeadImg);
            param.Add("@i_StaticUrl",info.StaticUrl);
            param.Add("@i_Status",info.Status);
            param.Add("@i_AskTel",info.AskTel);
            param.Add("@i_IsShowQQ",info.IsShowQQ);
            param.Add("@i_TestMethod",info.TestMethod);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.Add("@i_Publisher",info.Publisher);
            param.Add("@i_PublishDate",info.PublishDate);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingSub_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingSub(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingSub_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingSubInfo GetTrainingSubDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingSub_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingSubInfo)ORMapping.MapSingleObject(typeof(TrainingSubInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingSubEntityListResult GetTrainingSubEntityList(TrainingSubSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingSub_List", param, DBConnEnm.TRDBWrite);

            TrainingSubEntityListResult Result= new TrainingSubEntityListResult();
            Result.TrainingSubList = (List<TrainingSubInfo>)ORMapping.MapListObject(typeof(TrainingSubInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}