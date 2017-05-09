using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_District ( RH_District ) DB类
    ///</summary>
    public class DistrictDB
    {

        /// <summary>
        /// 添加RH_District
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDistrict(DistrictEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_DistrictName",info.DistrictName);
            param.Add("@i_DistrictPY",info.DistrictPY);
            param.Add("@i_CityID",info.CityID);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_District_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_District
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDistrict(DistrictEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_DistrictName",info.DistrictName);
            param.Add("@i_DistrictPY",info.DistrictPY);
            param.Add("@i_CityID",info.CityID);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_District_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_District
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDistrict(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_District_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_District
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DistrictInfo GetDistrictDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_District_Detail", param, DBConnEnm.TRDBWrite);

            return (DistrictInfo)ORMapping.MapSingleObject(typeof(DistrictInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_District
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DistrictEntityListResult GetDistrictEntityList(DistrictSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_District_List", param, DBConnEnm.TRDBWrite);

            DistrictEntityListResult Result= new DistrictEntityListResult();
            Result.DistrictList = (List<DistrictInfo>)ORMapping.MapListObject(typeof(DistrictInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}