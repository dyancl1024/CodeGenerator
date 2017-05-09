using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Banner ( RH_Banner ) DB类
    ///</summary>
    public class BannerDB
    {

        /// <summary>
        /// 添加RH_Banner
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddBanner(BannerEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Banner_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Banner
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyBanner(BannerEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_Banner_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Banner
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveBanner(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Banner_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Banner
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BannerEntity GetBannerDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_Banner_Detail", param, DBConnEnm.TRDBWrite);
            return (BannerEntity)ORMapping.MapSingleObject(typeof(BannerEntity),dt);
        }
    }
}