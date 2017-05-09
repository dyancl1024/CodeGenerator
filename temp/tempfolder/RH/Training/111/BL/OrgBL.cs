using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_Org ( RH_Org ) BL类
    ///</summary>
    public class OrgBL
    {

        /// <summary>
        /// 添加RH_Org
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddOrg(OrgEntity info)
        {
            return OrgDB.AddOrg(info);
        }


        /// <summary>
        /// 修改RH_Org
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyOrg(OrgEntity info)
        {
            return OrgDB.ModifyOrg(info);
        }


        /// <summary>
        /// 删除RH_Org
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveOrg(int ID)
        {
            return OrgDB.RemoveOrg(ID);
        }

        /// <summary>
        /// 查看RH_Org
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static OrgEntity GetOrgDetail(int ID)
        {
            return OrgDB.GetOrgDetail(ID);
        }
    }
}