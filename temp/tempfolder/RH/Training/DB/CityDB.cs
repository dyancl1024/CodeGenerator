using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_City ( RH_City ) DB类
    ///</summary>
    public class CityDB
    {

        /// <summary>
        /// 添加RH_City
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCity(CityEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_CityName",info.CityName);
            param.Add("@i_CityPY",info.CityPY);
            param.Add("@i_ProvinceID",info.ProvinceID);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_City_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_City
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCity(CityEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_id",info.id);
            param.Add("@i_CityName",info.CityName);
            param.Add("@i_CityPY",info.CityPY);
            param.Add("@i_ProvinceID",info.ProvinceID);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_City_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_City
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCity(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_id",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_City_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_City
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CityInfo GetCityDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_id",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_City_Detail", param, DBConnEnm.TRDBWrite);

            return (CityInfo)ORMapping.MapSingleObject(typeof(CityInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_City
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CityEntityListResult GetCityEntityList(CitySearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_City_List", param, DBConnEnm.TRDBWrite);

            CityEntityListResult Result= new CityEntityListResult();
            Result.CityList = (List<CityInfo>)ORMapping.MapListObject(typeof(CityInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}