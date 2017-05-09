using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_BannerObject ( RH_BannerObject ) DB类
    ///</summary>
    public class BannerObjectDB
    {

        /// <summary>
        /// 添加RH_BannerObject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddBannerObject(BannerObjectEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_BannerObject_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_BannerObject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyBannerObject(BannerObjectEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_BannerObject_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_BannerObject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveBannerObject(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_BannerObject_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_BannerObject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BannerObjectEntity GetBannerObjectDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_BannerObject_Detail", param, DBConnEnm.TRDBWrite);
            return (BannerObjectEntity)ORMapping.MapSingleObject(typeof(BannerObjectEntity),dt);
        }
    }
}