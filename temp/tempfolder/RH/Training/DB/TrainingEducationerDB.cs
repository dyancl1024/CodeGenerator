using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingEducationer ( RH_TrainingEducationer ) DB类
    ///</summary>
    public class TrainingEducationerDB
    {

        /// <summary>
        /// 添加RH_TrainingEducationer
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingEducationer(TrainingEducationerEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_DesignID",info.DesignID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingEducationer_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingEducationer
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingEducationer(TrainingEducationerEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_DesignID",info.DesignID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingEducationer_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingEducationer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingEducationer(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingEducationer_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingEducationer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingEducationerInfo GetTrainingEducationerDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingEducationer_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingEducationerInfo)ORMapping.MapSingleObject(typeof(TrainingEducationerInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingEducationer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingEducationerEntityListResult GetTrainingEducationerEntityList(TrainingEducationerSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingEducationer_List", param, DBConnEnm.TRDBWrite);

            TrainingEducationerEntityListResult Result= new TrainingEducationerEntityListResult();
            Result.TrainingEducationerList = (List<TrainingEducationerInfo>)ORMapping.MapListObject(typeof(TrainingEducationerInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}