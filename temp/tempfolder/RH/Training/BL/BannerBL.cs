using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_Banner ( RH_Banner ) BL类
    ///</summary>
    public class BannerBL
    {

        /// <summary>
        /// 添加RH_Banner
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddBanner(BannerEntity info)
        {
            return BannerDB.AddBanner(info);
        }


        /// <summary>
        /// 修改RH_Banner
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyBanner(BannerEntity info)
        {
            return BannerDB.ModifyBanner(info);
        }


        /// <summary>
        /// 删除RH_Banner
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveBanner(int ID)
        {
            return BannerDB.RemoveBanner(ID);
        }

        /// <summary>
        /// 查看RH_Banner
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BannerEntity GetBannerDetail(int ID)
        {
            return BannerDB.GetBannerDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_Banner
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BannerEntityListResult GetBannerEntityList(BannerSearcher Searcher)
        {
            return BannerDB.GetBannerEntityList(Searcher);
        }
    }
}