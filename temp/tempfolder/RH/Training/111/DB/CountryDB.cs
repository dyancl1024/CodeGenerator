using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Country ( RH_Country ) DB类
    ///</summary>
    public class CountryDB
    {

        /// <summary>
        /// 添加RH_Country
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCountry(CountryEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Country_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Country
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCountry(CountryEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_Country_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Country
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCountry(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Country_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Country
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CountryEntity GetCountryDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_Country_Detail", param, DBConnEnm.TRDBWrite);
            return (CountryEntity)ORMapping.MapSingleObject(typeof(CountryEntity),dt);
        }
    }
}