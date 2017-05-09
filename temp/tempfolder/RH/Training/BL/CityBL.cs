using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_City ( RH_City ) BL类
    ///</summary>
    public class CityBL
    {

        /// <summary>
        /// 添加RH_City
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCity(CityEntity info)
        {
            return CityDB.AddCity(info);
        }


        /// <summary>
        /// 修改RH_City
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCity(CityEntity info)
        {
            return CityDB.ModifyCity(info);
        }


        /// <summary>
        /// 删除RH_City
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCity(int ID)
        {
            return CityDB.RemoveCity(ID);
        }

        /// <summary>
        /// 查看RH_City
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CityEntity GetCityDetail(int ID)
        {
            return CityDB.GetCityDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_City
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CityEntityListResult GetCityEntityList(CitySearcher Searcher)
        {
            return CityDB.GetCityEntityList(Searcher);
        }
    }
}