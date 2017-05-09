using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingExcellent ( RH_TrainingExcellent ) DB类
    ///</summary>
    public class TrainingExcellentDB
    {

        /// <summary>
        /// 添加RH_TrainingExcellent
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingExcellent(TrainingExcellentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_TID",info.TID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_Ttype",info.Ttype);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingExcellent_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingExcellent
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingExcellent(TrainingExcellentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_TID",info.TID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_Ttype",info.Ttype);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingExcellent_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingExcellent
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingExcellent(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingExcellent_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingExcellent
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingExcellentInfo GetTrainingExcellentDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingExcellent_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingExcellentInfo)ORMapping.MapSingleObject(typeof(TrainingExcellentInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingExcellent
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingExcellentEntityListResult GetTrainingExcellentEntityList(TrainingExcellentSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingExcellent_List", param, DBConnEnm.TRDBWrite);

            TrainingExcellentEntityListResult Result= new TrainingExcellentEntityListResult();
            Result.TrainingExcellentList = (List<TrainingExcellentInfo>)ORMapping.MapListObject(typeof(TrainingExcellentInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}