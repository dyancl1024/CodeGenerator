using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_MngRoleRight ( RH_MngRoleRight ) DB类
    ///</summary>
    public class MngRoleRightDB
    {

        /// <summary>
        /// 添加RH_MngRoleRight
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddMngRoleRight(MngRoleRightEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_MngRoleRight_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_MngRoleRight
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyMngRoleRight(MngRoleRightEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_MngRoleRight_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_MngRoleRight
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveMngRoleRight(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_MngRoleRight_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_MngRoleRight
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MngRoleRightEntity GetMngRoleRightDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_MngRoleRight_Detail", param, DBConnEnm.TRDBWrite);
            return (MngRoleRightEntity)ORMapping.MapSingleObject(typeof(MngRoleRightEntity),dt);
        }
    }
}