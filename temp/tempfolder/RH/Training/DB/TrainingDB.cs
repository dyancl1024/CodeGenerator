using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Training ( RH_Training ) DB类
    ///</summary>
    public class TrainingDB
    {

        /// <summary>
        /// 添加RH_Training
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTraining(TrainingEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_DesignID",info.DesignID);
            param.Add("@i_TName",info.TName);
            param.Add("@i_TrainingPhase",info.TrainingPhase);
            param.Add("@i_TrainingNum",info.TrainingNum);
            param.Add("@i_TrainingLevelCode",info.TrainingLevelCode);
            param.Add("@i_TrainingTypeCode",info.TrainingTypeCode);
            param.Add("@i_ProvinceID",info.ProvinceID);
            param.Add("@i_CityID",info.CityID);
            param.Add("@i_DistrictID",info.DistrictID);
            param.Add("@i_TrainingDateB",info.TrainingDateB);
            param.Add("@i_TrainingDateE",info.TrainingDateE);
            param.Add("@i_IsStage",info.IsStage);
            param.Add("@i_TrainingUrl",info.TrainingUrl);
            param.Add("@i_TrainingCode",info.TrainingCode);
            param.Add("@i_TrainingHeadImg",info.TrainingHeadImg);
            param.Add("@i_StaticUrl",info.StaticUrl);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.Add("@i_Publisher",info.Publisher);
            param.Add("@i_PublishDate",info.PublishDate);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Training_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Training
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTraining(TrainingEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_DesignID",info.DesignID);
            param.Add("@i_TName",info.TName);
            param.Add("@i_TrainingPhase",info.TrainingPhase);
            param.Add("@i_TrainingNum",info.TrainingNum);
            param.Add("@i_TrainingLevelCode",info.TrainingLevelCode);
            param.Add("@i_TrainingTypeCode",info.TrainingTypeCode);
            param.Add("@i_ProvinceID",info.ProvinceID);
            param.Add("@i_CityID",info.CityID);
            param.Add("@i_DistrictID",info.DistrictID);
            param.Add("@i_TrainingDateB",info.TrainingDateB);
            param.Add("@i_TrainingDateE",info.TrainingDateE);
            param.Add("@i_IsStage",info.IsStage);
            param.Add("@i_TrainingUrl",info.TrainingUrl);
            param.Add("@i_TrainingCode",info.TrainingCode);
            param.Add("@i_TrainingHeadImg",info.TrainingHeadImg);
            param.Add("@i_StaticUrl",info.StaticUrl);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.Add("@i_Publisher",info.Publisher);
            param.Add("@i_PublishDate",info.PublishDate);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Training_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Training
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTraining(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Training_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Training
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingInfo GetTrainingDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_Training_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingInfo)ORMapping.MapSingleObject(typeof(TrainingInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_Training
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingEntityListResult GetTrainingEntityList(TrainingSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_Training_List", param, DBConnEnm.TRDBWrite);

            TrainingEntityListResult Result= new TrainingEntityListResult();
            Result.TrainingList = (List<TrainingInfo>)ORMapping.MapListObject(typeof(TrainingInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}