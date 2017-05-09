using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_UserInfo ( RH_UserInfo ) BL类
    ///</summary>
    public class UserInfoBL
    {

        /// <summary>
        /// 添加RH_UserInfo
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddUserInfo(UserInfoEntity info)
        {
            return UserInfoDB.AddUserInfo(info);
        }


        /// <summary>
        /// 修改RH_UserInfo
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyUserInfo(UserInfoEntity info)
        {
            return UserInfoDB.ModifyUserInfo(info);
        }


        /// <summary>
        /// 删除RH_UserInfo
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveUserInfo(int ID)
        {
            return UserInfoDB.RemoveUserInfo(ID);
        }

        /// <summary>
        /// 查看RH_UserInfo
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static UserInfoEntity GetUserInfoDetail(int ID)
        {
            return UserInfoDB.GetUserInfoDetail(ID);
        }
    }
}