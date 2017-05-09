using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_MngUser ( RH_MngUser ) DB类
    ///</summary>
    public class MngUserDB
    {

        /// <summary>
        /// 添加RH_MngUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddMngUser(MngUserEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_MngUser_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_MngUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyMngUser(MngUserEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_MngUser_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_MngUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveMngUser(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_MngUser_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_MngUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MngUserEntity GetMngUserDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_MngUser_Detail", param, DBConnEnm.TRDBWrite);
            return (MngUserEntity)ORMapping.MapSingleObject(typeof(MngUserEntity),dt);
        }
    }
}