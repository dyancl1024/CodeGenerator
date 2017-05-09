using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_User ( RH_User ) DB类
    ///</summary>
    public class UserDB
    {

        /// <summary>
        /// 添加RH_User
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddUser(UserEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_User_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_User
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyUser(UserEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_User_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_User
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveUser(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_User_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_User
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static UserEntity GetUserDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_User_Detail", param, DBConnEnm.TRDBWrite);
            return (UserEntity)ORMapping.MapSingleObject(typeof(UserEntity),dt);
        }
    }
}