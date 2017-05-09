using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_UserInfo ( RH_UserInfo ) DB类
    ///</summary>
    public class UserInfoDB
    {

        /// <summary>
        /// 添加RH_UserInfo
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddUserInfo(UserInfoEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_UserID",info.UserID);
            param.Add("@i_SchoolID",info.SchoolID);
            param.Add("@i_CUserName",info.CUserName);
            param.Add("@i_CPassword",info.CPassword);
            param.Add("@i_CSource",info.CSource);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_UserInfo_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_UserInfo
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyUserInfo(UserInfoEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_SchoolID",info.SchoolID);
            param.Add("@i_CUserName",info.CUserName);
            param.Add("@i_CPassword",info.CPassword);
            param.Add("@i_CSource",info.CSource);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_UserInfo_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_UserInfo
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveUserInfo(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_UserInfo_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_UserInfo
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static UserInfoInfo GetUserInfoDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_UserInfo_Detail", param, DBConnEnm.TRDBWrite);

            return (UserInfoInfo)ORMapping.MapSingleObject(typeof(UserInfoInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_UserInfo
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static UserInfoEntityListResult GetUserInfoEntityList(UserInfoSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_UserInfo_List", param, DBConnEnm.TRDBWrite);

            UserInfoEntityListResult Result= new UserInfoEntityListResult();
            Result.UserInfoList = (List<UserInfoInfo>)ORMapping.MapListObject(typeof(UserInfoInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}