using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_District ( RH_District ) DB类
    ///</summary>
    public class DistrictDB
    {

        /// <summary>
        /// 添加RH_District
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDistrict(DistrictEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_District_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_District
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDistrict(DistrictEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_District_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_District
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDistrict(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_District_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_District
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DistrictEntity GetDistrictDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_District_Detail", param, DBConnEnm.TRDBWrite);
            return (DistrictEntity)ORMapping.MapSingleObject(typeof(DistrictEntity),dt);
        }
    }
}