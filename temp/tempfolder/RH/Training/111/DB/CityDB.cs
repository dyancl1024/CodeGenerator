using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_City ( RH_City ) DB类
    ///</summary>
    public class CityDB
    {

        /// <summary>
        /// 添加RH_City
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCity(CityEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_City_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_City
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCity(CityEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_City_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_City
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCity(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_City_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_City
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CityEntity GetCityDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_City_Detail", param, DBConnEnm.TRDBWrite);
            return (CityEntity)ORMapping.MapSingleObject(typeof(CityEntity),dt);
        }
    }
}