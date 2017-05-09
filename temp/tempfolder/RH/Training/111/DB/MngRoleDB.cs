using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_MngRole ( RH_MngRole ) DB类
    ///</summary>
    public class MngRoleDB
    {

        /// <summary>
        /// 添加RH_MngRole
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddMngRole(MngRoleEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_MngRole_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_MngRole
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyMngRole(MngRoleEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_MngRole_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_MngRole
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveMngRole(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_MngRole_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_MngRole
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MngRoleEntity GetMngRoleDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_MngRole_Detail", param, DBConnEnm.TRDBWrite);
            return (MngRoleEntity)ORMapping.MapSingleObject(typeof(MngRoleEntity),dt);
        }
    }
}