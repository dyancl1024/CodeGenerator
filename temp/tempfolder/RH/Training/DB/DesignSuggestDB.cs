using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_DesignSuggest ( RH_DesignSuggest ) DB类
    ///</summary>
    public class DesignSuggestDB
    {

        /// <summary>
        /// 添加RH_DesignSuggest
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignSuggest(DesignSuggestEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_DesignID",info.DesignID);
            param.Add("@i_DSuggest",info.DSuggest);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignSuggest_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_DesignSuggest
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignSuggest(DesignSuggestEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_DesignID",info.DesignID);
            param.Add("@i_DSuggest",info.DSuggest);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignSuggest_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_DesignSuggest
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignSuggest(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignSuggest_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_DesignSuggest
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignSuggestInfo GetDesignSuggestDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_DesignSuggest_Detail", param, DBConnEnm.TRDBWrite);

            return (DesignSuggestInfo)ORMapping.MapSingleObject(typeof(DesignSuggestInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_DesignSuggest
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignSuggestEntityListResult GetDesignSuggestEntityList(DesignSuggestSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_DesignSuggest_List", param, DBConnEnm.TRDBWrite);

            DesignSuggestEntityListResult Result= new DesignSuggestEntityListResult();
            Result.DesignSuggestList = (List<DesignSuggestInfo>)ORMapping.MapListObject(typeof(DesignSuggestInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}