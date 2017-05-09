using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_Country ( RH_Country ) BL类
    ///</summary>
    public class CountryBL
    {

        /// <summary>
        /// 添加RH_Country
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCountry(CountryEntity info)
        {
            return CountryDB.AddCountry(info);
        }


        /// <summary>
        /// 修改RH_Country
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCountry(CountryEntity info)
        {
            return CountryDB.ModifyCountry(info);
        }


        /// <summary>
        /// 删除RH_Country
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCountry(int ID)
        {
            return CountryDB.RemoveCountry(ID);
        }

        /// <summary>
        /// 查看RH_Country
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CountryEntity GetCountryDetail(int ID)
        {
            return CountryDB.GetCountryDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_Country
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CountryEntityListResult GetCountryEntityList(CountrySearcher Searcher)
        {
            return CountryDB.GetCountryEntityList(Searcher);
        }
    }
}