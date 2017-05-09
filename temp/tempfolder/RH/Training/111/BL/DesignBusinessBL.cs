using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_DesignBusiness ( RH_DesignBusiness ) BL类
    ///</summary>
    public class DesignBusinessBL
    {

        /// <summary>
        /// 添加RH_DesignBusiness
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignBusiness(DesignBusinessEntity info)
        {
            return DesignBusinessDB.AddDesignBusiness(info);
        }


        /// <summary>
        /// 修改RH_DesignBusiness
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignBusiness(DesignBusinessEntity info)
        {
            return DesignBusinessDB.ModifyDesignBusiness(info);
        }


        /// <summary>
        /// 删除RH_DesignBusiness
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignBusiness(int ID)
        {
            return DesignBusinessDB.RemoveDesignBusiness(ID);
        }

        /// <summary>
        /// 查看RH_DesignBusiness
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignBusinessEntity GetDesignBusinessDetail(int ID)
        {
            return DesignBusinessDB.GetDesignBusinessDetail(ID);
        }
    }
}