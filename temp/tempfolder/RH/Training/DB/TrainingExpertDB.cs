using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingExpert ( RH_TrainingExpert ) DB类
    ///</summary>
    public class TrainingExpertDB
    {

        /// <summary>
        /// 添加RH_TrainingExpert
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingExpert(TrainingExpertEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_TID",info.TID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingExpert_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingExpert
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingExpert(TrainingExpertEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_TID",info.TID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingExpert_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingExpert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingExpert(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingExpert_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingExpert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingExpertInfo GetTrainingExpertDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingExpert_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingExpertInfo)ORMapping.MapSingleObject(typeof(TrainingExpertInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingExpert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingExpertEntityListResult GetTrainingExpertEntityList(TrainingExpertSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingExpert_List", param, DBConnEnm.TRDBWrite);

            TrainingExpertEntityListResult Result= new TrainingExpertEntityListResult();
            Result.TrainingExpertList = (List<TrainingExpertInfo>)ORMapping.MapListObject(typeof(TrainingExpertInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}