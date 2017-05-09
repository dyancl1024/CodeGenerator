using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_MngUser ( RH_MngUser ) BL类
    ///</summary>
    public class MngUserBL
    {

        /// <summary>
        /// 添加RH_MngUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddMngUser(MngUserEntity info)
        {
            return MngUserDB.AddMngUser(info);
        }


        /// <summary>
        /// 修改RH_MngUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyMngUser(MngUserEntity info)
        {
            return MngUserDB.ModifyMngUser(info);
        }


        /// <summary>
        /// 删除RH_MngUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveMngUser(int ID)
        {
            return MngUserDB.RemoveMngUser(ID);
        }

        /// <summary>
        /// 查看RH_MngUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MngUserEntity GetMngUserDetail(int ID)
        {
            return MngUserDB.GetMngUserDetail(ID);
        }
    }
}