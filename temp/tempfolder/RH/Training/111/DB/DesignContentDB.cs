using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_DesignContent ( RH_DesignContent ) DB类
    ///</summary>
    public class DesignContentDB
    {

        /// <summary>
        /// 添加RH_DesignContent
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignContent(DesignContentEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_DesignContent_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_DesignContent
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignContent(DesignContentEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_DesignContent_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_DesignContent
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignContent(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_DesignContent_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_DesignContent
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignContentEntity GetDesignContentDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_DesignContent_Detail", param, DBConnEnm.TRDBWrite);
            return (DesignContentEntity)ORMapping.MapSingleObject(typeof(DesignContentEntity),dt);
        }
    }
}