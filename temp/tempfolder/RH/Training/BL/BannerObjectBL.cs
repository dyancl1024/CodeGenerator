using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_BannerObject ( RH_BannerObject ) BL类
    ///</summary>
    public class BannerObjectBL
    {

        /// <summary>
        /// 添加RH_BannerObject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddBannerObject(BannerObjectEntity info)
        {
            return BannerObjectDB.AddBannerObject(info);
        }


        /// <summary>
        /// 修改RH_BannerObject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyBannerObject(BannerObjectEntity info)
        {
            return BannerObjectDB.ModifyBannerObject(info);
        }


        /// <summary>
        /// 删除RH_BannerObject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveBannerObject(int ID)
        {
            return BannerObjectDB.RemoveBannerObject(ID);
        }

        /// <summary>
        /// 查看RH_BannerObject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BannerObjectEntity GetBannerObjectDetail(int ID)
        {
            return BannerObjectDB.GetBannerObjectDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_BannerObject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BannerObjectEntityListResult GetBannerObjectEntityList(BannerObjectSearcher Searcher)
        {
            return BannerObjectDB.GetBannerObjectEntityList(Searcher);
        }
    }
}