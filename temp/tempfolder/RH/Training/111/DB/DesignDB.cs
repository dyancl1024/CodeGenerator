using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Design ( RH_Design ) DB类
    ///</summary>
    public class DesignDB
    {

        /// <summary>
        /// 添加RH_Design
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesign(DesignEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Design_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Design
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesign(DesignEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_Design_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Design
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesign(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Design_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Design
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignEntity GetDesignDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_Design_Detail", param, DBConnEnm.TRDBWrite);
            return (DesignEntity)ORMapping.MapSingleObject(typeof(DesignEntity),dt);
        }
    }
}