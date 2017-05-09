using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_BannerArea ( RH_BannerArea ) DB类
    ///</summary>
    public class BannerAreaDB
    {

        /// <summary>
        /// 添加RH_BannerArea
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddBannerArea(BannerAreaEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_BannerArea_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_BannerArea
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyBannerArea(BannerAreaEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_BannerArea_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_BannerArea
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveBannerArea(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_BannerArea_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_BannerArea
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BannerAreaEntity GetBannerAreaDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_BannerArea_Detail", param, DBConnEnm.TRDBWrite);
            return (BannerAreaEntity)ORMapping.MapSingleObject(typeof(BannerAreaEntity),dt);
        }
    }
}