using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_DesignBusiness ( RH_DesignBusiness ) DB类
    ///</summary>
    public class DesignBusinessDB
    {

        /// <summary>
        /// 添加RH_DesignBusiness
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignBusiness(DesignBusinessEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_DesignBusiness_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_DesignBusiness
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignBusiness(DesignBusinessEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_DesignBusiness_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_DesignBusiness
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignBusiness(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_DesignBusiness_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_DesignBusiness
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignBusinessEntity GetDesignBusinessDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_DesignBusiness_Detail", param, DBConnEnm.TRDBWrite);
            return (DesignBusinessEntity)ORMapping.MapSingleObject(typeof(DesignBusinessEntity),dt);
        }
    }
}