using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_MngMenu ( RH_MngMenu ) DB类
    ///</summary>
    public class MngMenuDB
    {

        /// <summary>
        /// 添加RH_MngMenu
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddMngMenu(MngMenuEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_MngMenu_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_MngMenu
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyMngMenu(MngMenuEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_MngMenu_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_MngMenu
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveMngMenu(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_MngMenu_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_MngMenu
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static MngMenuEntity GetMngMenuDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_MngMenu_Detail", param, DBConnEnm.TRDBWrite);
            return (MngMenuEntity)ORMapping.MapSingleObject(typeof(MngMenuEntity),dt);
        }
    }
}