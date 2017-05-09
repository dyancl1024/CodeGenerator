using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Org ( RH_Org ) DB类
    ///</summary>
    public class OrgDB
    {

        /// <summary>
        /// 添加RH_Org
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddOrg(OrgEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Org_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Org
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyOrg(OrgEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_Org_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Org
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveOrg(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Org_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Org
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static OrgEntity GetOrgDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_Org_Detail", param, DBConnEnm.TRDBWrite);
            return (OrgEntity)ORMapping.MapSingleObject(typeof(OrgEntity),dt);
        }
    }
}