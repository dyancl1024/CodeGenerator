using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_MngRole ( RH_MngRole ) BL类
    ///</summary>
    public class MngRoleBL
    {

        /// <summary>
        /// 添加RH_MngRole
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddMngRole(MngRoleEntity info)
        {
            return MngRoleDB.AddMngRole(info);
        }


        /// <summary>
        /// 修改RH_MngRole
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyMngRole(MngRoleEntity info)
        {
            return MngRoleDB.ModifyMngRole(info);
        }


        /// <summary>
        /// 删除RH_MngRole
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveMngRole(int ID)
        {
            return MngRoleDB.RemoveMngRole(ID);
        }

        /// <summary>
        /// 查看RH_MngRole
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MngRoleEntity GetMngRoleDetail(int ID)
        {
            return MngRoleDB.GetMngRoleDetail(ID);
        }
    }
}