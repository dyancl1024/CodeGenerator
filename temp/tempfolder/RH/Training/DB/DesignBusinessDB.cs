using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_DesignBusiness ( RH_DesignBusiness ) DB类
    ///</summary>
    public class DesignBusinessDB
    {

        /// <summary>
        /// 添加RH_DesignBusiness
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignBusiness(DesignBusinessEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_DesignID",info.DesignID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignBusiness_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_DesignBusiness
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignBusiness(DesignBusinessEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_DesignID",info.DesignID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignBusiness_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_DesignBusiness
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignBusiness(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignBusiness_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_DesignBusiness
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignBusinessInfo GetDesignBusinessDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_DesignBusiness_Detail", param, DBConnEnm.TRDBWrite);

            return (DesignBusinessInfo)ORMapping.MapSingleObject(typeof(DesignBusinessInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_DesignBusiness
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignBusinessEntityListResult GetDesignBusinessEntityList(DesignBusinessSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_DesignBusiness_List", param, DBConnEnm.TRDBWrite);

            DesignBusinessEntityListResult Result= new DesignBusinessEntityListResult();
            Result.DesignBusinessList = (List<DesignBusinessInfo>)ORMapping.MapListObject(typeof(DesignBusinessInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}