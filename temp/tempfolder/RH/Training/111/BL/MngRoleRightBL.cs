using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_MngRoleRight ( RH_MngRoleRight ) BL类
    ///</summary>
    public class MngRoleRightBL
    {

        /// <summary>
        /// 添加RH_MngRoleRight
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddMngRoleRight(MngRoleRightEntity info)
        {
            return MngRoleRightDB.AddMngRoleRight(info);
        }


        /// <summary>
        /// 修改RH_MngRoleRight
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyMngRoleRight(MngRoleRightEntity info)
        {
            return MngRoleRightDB.ModifyMngRoleRight(info);
        }


        /// <summary>
        /// 删除RH_MngRoleRight
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveMngRoleRight(int ID)
        {
            return MngRoleRightDB.RemoveMngRoleRight(ID);
        }

        /// <summary>
        /// 查看RH_MngRoleRight
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MngRoleRightEntity GetMngRoleRightDetail(int ID)
        {
            return MngRoleRightDB.GetMngRoleRightDetail(ID);
        }
    }
}