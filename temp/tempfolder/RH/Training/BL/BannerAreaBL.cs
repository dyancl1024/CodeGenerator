using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_BannerArea ( RH_BannerArea ) BL类
    ///</summary>
    public class BannerAreaBL
    {

        /// <summary>
        /// 添加RH_BannerArea
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddBannerArea(BannerAreaEntity info)
        {
            return BannerAreaDB.AddBannerArea(info);
        }


        /// <summary>
        /// 修改RH_BannerArea
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyBannerArea(BannerAreaEntity info)
        {
            return BannerAreaDB.ModifyBannerArea(info);
        }


        /// <summary>
        /// 删除RH_BannerArea
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveBannerArea(int ID)
        {
            return BannerAreaDB.RemoveBannerArea(ID);
        }

        /// <summary>
        /// 查看RH_BannerArea
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BannerAreaEntity GetBannerAreaDetail(int ID)
        {
            return BannerAreaDB.GetBannerAreaDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_BannerArea
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BannerAreaEntityListResult GetBannerAreaEntityList(BannerAreaSearcher Searcher)
        {
            return BannerAreaDB.GetBannerAreaEntityList(Searcher);
        }
    }
}