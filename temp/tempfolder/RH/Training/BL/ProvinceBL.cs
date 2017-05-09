using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_Province ( RH_Province ) BL类
    ///</summary>
    public class ProvinceBL
    {

        /// <summary>
        /// 添加RH_Province
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddProvince(ProvinceEntity info)
        {
            return ProvinceDB.AddProvince(info);
        }


        /// <summary>
        /// 修改RH_Province
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyProvince(ProvinceEntity info)
        {
            return ProvinceDB.ModifyProvince(info);
        }


        /// <summary>
        /// 删除RH_Province
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveProvince(int ID)
        {
            return ProvinceDB.RemoveProvince(ID);
        }

        /// <summary>
        /// 查看RH_Province
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static ProvinceEntity GetProvinceDetail(int ID)
        {
            return ProvinceDB.GetProvinceDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_Province
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static ProvinceEntityListResult GetProvinceEntityList(ProvinceSearcher Searcher)
        {
            return ProvinceDB.GetProvinceEntityList(Searcher);
        }
    }
}