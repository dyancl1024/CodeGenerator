using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_DesignSuggest ( RH_DesignSuggest ) BL类
    ///</summary>
    public class DesignSuggestBL
    {

        /// <summary>
        /// 添加RH_DesignSuggest
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignSuggest(DesignSuggestEntity info)
        {
            return DesignSuggestDB.AddDesignSuggest(info);
        }


        /// <summary>
        /// 修改RH_DesignSuggest
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignSuggest(DesignSuggestEntity info)
        {
            return DesignSuggestDB.ModifyDesignSuggest(info);
        }


        /// <summary>
        /// 删除RH_DesignSuggest
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignSuggest(int ID)
        {
            return DesignSuggestDB.RemoveDesignSuggest(ID);
        }

        /// <summary>
        /// 查看RH_DesignSuggest
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignSuggestEntity GetDesignSuggestDetail(int ID)
        {
            return DesignSuggestDB.GetDesignSuggestDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_DesignSuggest
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignSuggestEntityListResult GetDesignSuggestEntityList(DesignSuggestSearcher Searcher)
        {
            return DesignSuggestDB.GetDesignSuggestEntityList(Searcher);
        }
    }
}