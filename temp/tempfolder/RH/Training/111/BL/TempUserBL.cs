using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TempUser ( RH_TempUser ) BL类
    ///</summary>
    public class TempUserBL
    {

        /// <summary>
        /// 添加RH_TempUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTempUser(TempUserEntity info)
        {
            return TempUserDB.AddTempUser(info);
        }


        /// <summary>
        /// 修改RH_TempUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTempUser(TempUserEntity info)
        {
            return TempUserDB.ModifyTempUser(info);
        }


        /// <summary>
        /// 删除RH_TempUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTempUser(int ID)
        {
            return TempUserDB.RemoveTempUser(ID);
        }

        /// <summary>
        /// 查看RH_TempUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TempUserEntity GetTempUserDetail(int ID)
        {
            return TempUserDB.GetTempUserDetail(ID);
        }
    }
}