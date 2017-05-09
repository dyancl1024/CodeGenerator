using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Expert ( RH_Expert ) DB类
    ///</summary>
    public class ExpertDB
    {

        /// <summary>
        /// 添加RH_Expert
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddExpert(ExpertEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_UserID",info.UserID);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Expert_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Expert
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyExpert(ExpertEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Expert_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Expert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveExpert(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Expert_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Expert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static ExpertInfo GetExpertDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_Expert_Detail", param, DBConnEnm.TRDBWrite);

            return (ExpertInfo)ORMapping.MapSingleObject(typeof(ExpertInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_Expert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static ExpertEntityListResult GetExpertEntityList(ExpertSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_Expert_List", param, DBConnEnm.TRDBWrite);

            ExpertEntityListResult Result= new ExpertEntityListResult();
            Result.ExpertList = (List<ExpertInfo>)ORMapping.MapListObject(typeof(ExpertInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}