using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingDynamic ( RH_TrainingDynamic ) DB类
    ///</summary>
    public class TrainingDynamicDB
    {

        /// <summary>
        /// 添加RH_TrainingDynamic
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingDynamic(TrainingDynamicEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ObjectID",info.ObjectID);
            param.Add("@i_MType",info.MType);
            param.Add("@i_DyTitle",info.DyTitle);
            param.Add("@i_DyType",info.DyType);
            param.Add("@i_DyContent",info.DyContent);
            param.Add("@i_DyLink",info.DyLink);
            param.Add("@i_DyPicUrl",info.DyPicUrl);
            param.Add("@i_DState",info.DState);
            param.Add("@i_CilckNum",info.CilckNum);
            param.Add("@i_StaticUrl",info.StaticUrl);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingDynamic_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingDynamic
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingDynamic(TrainingDynamicEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_ObjectID",info.ObjectID);
            param.Add("@i_MType",info.MType);
            param.Add("@i_DyTitle",info.DyTitle);
            param.Add("@i_DyType",info.DyType);
            param.Add("@i_DyContent",info.DyContent);
            param.Add("@i_DyLink",info.DyLink);
            param.Add("@i_DyPicUrl",info.DyPicUrl);
            param.Add("@i_DState",info.DState);
            param.Add("@i_CilckNum",info.CilckNum);
            param.Add("@i_StaticUrl",info.StaticUrl);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingDynamic_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingDynamic
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingDynamic(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingDynamic_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingDynamic
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingDynamicInfo GetTrainingDynamicDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingDynamic_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingDynamicInfo)ORMapping.MapSingleObject(typeof(TrainingDynamicInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingDynamic
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingDynamicEntityListResult GetTrainingDynamicEntityList(TrainingDynamicSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingDynamic_List", param, DBConnEnm.TRDBWrite);

            TrainingDynamicEntityListResult Result= new TrainingDynamicEntityListResult();
            Result.TrainingDynamicList = (List<TrainingDynamicInfo>)ORMapping.MapListObject(typeof(TrainingDynamicInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}