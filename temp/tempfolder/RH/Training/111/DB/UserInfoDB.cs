using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

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
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_UserInfo_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_UserInfo
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyUserInfo(UserInfoEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_UserInfo_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_UserInfo
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveUserInfo(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_UserInfo_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_UserInfo
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static UserInfoEntity GetUserInfoDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_UserInfo_Detail", param, DBConnEnm.TRDBWrite);
            return (UserInfoEntity)ORMapping.MapSingleObject(typeof(UserInfoEntity),dt);
        }
    }
}