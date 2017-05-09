using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_Temp_BasicData_User ( RH_Temp_BasicData_User ) BL类
    ///</summary>
    public class Temp_BasicData_UserBL
    {

        /// <summary>
        /// 添加RH_Temp_BasicData_User
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTemp_BasicData_User(Temp_BasicData_UserEntity info)
        {
            return Temp_BasicData_UserDB.AddTemp_BasicData_User(info);
        }


        /// <summary>
        /// 修改RH_Temp_BasicData_User
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTemp_BasicData_User(Temp_BasicData_UserEntity info)
        {
            return Temp_BasicData_UserDB.ModifyTemp_BasicData_User(info);
        }


        /// <summary>
        /// 删除RH_Temp_BasicData_User
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTemp_BasicData_User(int ID)
        {
            return Temp_BasicData_UserDB.RemoveTemp_BasicData_User(ID);
        }

        /// <summary>
        /// 查看RH_Temp_BasicData_User
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Temp_BasicData_UserEntity GetTemp_BasicData_UserDetail(int ID)
        {
            return Temp_BasicData_UserDB.GetTemp_BasicData_UserDetail(ID);
        }

        /// <summary>
        /// 查看全部RH_Temp_BasicData_User
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Temp_BasicData_UserEntityListResult GetTemp_BasicData_UserEntityList(Temp_BasicData_UserSearcher Searcher)
        {
            return Temp_BasicData_UserDB.GetTemp_BasicData_UserEntityList(Searcher);
        }
    }
}