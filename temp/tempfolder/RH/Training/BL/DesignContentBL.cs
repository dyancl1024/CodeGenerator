using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_DesignContent ( RH_DesignContent ) BL类
    ///</summary>
    public class DesignContentBL
    {

        /// <summary>
        /// 添加RH_DesignContent
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignContent(DesignContentEntity info)
        {
            return DesignContentDB.AddDesignContent(info);
        }


        /// <summary>
        /// 修改RH_DesignContent
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignContent(DesignContentEntity info)
        {
            return DesignContentDB.ModifyDesignContent(info);
        }


        /// <summary>
        /// 删除RH_DesignContent
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignContent(int ID)
        {
            return DesignContentDB.RemoveDesignContent(ID);
        }

        /// <summary>
        /// 查看RH_DesignContent
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignContentEntity GetDesignContentDetail(int ID)
        {
            return DesignContentDB.GetDesignContentDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_DesignContent
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignContentEntityListResult GetDesignContentEntityList(DesignContentSearcher Searcher)
        {
            return DesignContentDB.GetDesignContentEntityList(Searcher);
        }
    }
}