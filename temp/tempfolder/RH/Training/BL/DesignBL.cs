using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_Design ( RH_Design ) BL类
    ///</summary>
    public class DesignBL
    {

        /// <summary>
        /// 添加RH_Design
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesign(DesignEntity info)
        {
            return DesignDB.AddDesign(info);
        }


        /// <summary>
        /// 修改RH_Design
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesign(DesignEntity info)
        {
            return DesignDB.ModifyDesign(info);
        }


        /// <summary>
        /// 删除RH_Design
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesign(int ID)
        {
            return DesignDB.RemoveDesign(ID);
        }

        /// <summary>
        /// 查看RH_Design
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignEntity GetDesignDetail(int ID)
        {
            return DesignDB.GetDesignDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_Design
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignEntityListResult GetDesignEntityList(DesignSearcher Searcher)
        {
            return DesignDB.GetDesignEntityList(Searcher);
        }
    }
}