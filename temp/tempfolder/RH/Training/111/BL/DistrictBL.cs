using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_District ( RH_District ) BL类
    ///</summary>
    public class DistrictBL
    {

        /// <summary>
        /// 添加RH_District
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDistrict(DistrictEntity info)
        {
            return DistrictDB.AddDistrict(info);
        }


        /// <summary>
        /// 修改RH_District
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDistrict(DistrictEntity info)
        {
            return DistrictDB.ModifyDistrict(info);
        }


        /// <summary>
        /// 删除RH_District
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDistrict(int ID)
        {
            return DistrictDB.RemoveDistrict(ID);
        }

        /// <summary>
        /// 查看RH_District
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DistrictEntity GetDistrictDetail(int ID)
        {
            return DistrictDB.GetDistrictDetail(ID);
        }
    }
}