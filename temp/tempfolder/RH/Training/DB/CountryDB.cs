using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Country ( RH_Country ) DB类
    ///</summary>
    public class CountryDB
    {

        /// <summary>
        /// 添加RH_Country
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCountry(CountryEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_CountryName",info.CountryName);
            param.Add("@i_CountryPY",info.CountryPY);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Country_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Country
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCountry(CountryEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_CountryName",info.CountryName);
            param.Add("@i_CountryPY",info.CountryPY);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Country_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Country
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCountry(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Country_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Country
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CountryInfo GetCountryDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_Country_Detail", param, DBConnEnm.TRDBWrite);

            return (CountryInfo)ORMapping.MapSingleObject(typeof(CountryInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_Country
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CountryEntityListResult GetCountryEntityList(CountrySearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_Country_List", param, DBConnEnm.TRDBWrite);

            CountryEntityListResult Result= new CountryEntityListResult();
            Result.CountryList = (List<CountryInfo>)ORMapping.MapListObject(typeof(CountryInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}