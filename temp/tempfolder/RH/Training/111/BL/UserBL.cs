using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_User ( RH_User ) BL类
    ///</summary>
    public class UserBL
    {

        /// <summary>
        /// 添加RH_User
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddUser(UserEntity info)
        {
            return UserDB.AddUser(info);
        }


        /// <summary>
        /// 修改RH_User
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyUser(UserEntity info)
        {
            return UserDB.ModifyUser(info);
        }


        /// <summary>
        /// 删除RH_User
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveUser(int ID)
        {
            return UserDB.RemoveUser(ID);
        }

        /// <summary>
        /// 查看RH_User
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static UserEntity GetUserDetail(int ID)
        {
            return UserDB.GetUserDetail(ID);
        }
    }
}