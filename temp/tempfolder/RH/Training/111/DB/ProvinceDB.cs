using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Province ( RH_Province ) DB类
    ///</summary>
    public class ProvinceDB
    {

        /// <summary>
        /// 添加RH_Province
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddProvince(ProvinceEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Province_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Province
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyProvince(ProvinceEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_Province_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Province
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveProvince(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Province_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Province
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static ProvinceEntity GetProvinceDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_Province_Detail", param, DBConnEnm.TRDBWrite);
            return (ProvinceEntity)ORMapping.MapSingleObject(typeof(ProvinceEntity),dt);
        }
    }
}