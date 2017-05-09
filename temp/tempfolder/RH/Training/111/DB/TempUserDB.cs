using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TempUser ( RH_TempUser ) DB类
    ///</summary>
    public class TempUserDB
    {

        /// <summary>
        /// 添加RH_TempUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTempUser(TempUserEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TempUser_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TempUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTempUser(TempUserEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_TempUser_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TempUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTempUser(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TempUser_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TempUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TempUserEntity GetTempUserDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_TempUser_Detail", param, DBConnEnm.TRDBWrite);
            return (TempUserEntity)ORMapping.MapSingleObject(typeof(TempUserEntity),dt);
        }
    }
}