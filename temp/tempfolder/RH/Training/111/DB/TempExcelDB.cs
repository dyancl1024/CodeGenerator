using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TempExcel ( RH_TempExcel ) DB类
    ///</summary>
    public class TempExcelDB
    {

        /// <summary>
        /// 添加RH_TempExcel
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTempExcel(TempExcelEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TempExcel_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TempExcel
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTempExcel(TempExcelEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_TempExcel_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TempExcel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTempExcel(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TempExcel_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TempExcel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TempExcelEntity GetTempExcelDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_TempExcel_Detail", param, DBConnEnm.TRDBWrite);
            return (TempExcelEntity)ORMapping.MapSingleObject(typeof(TempExcelEntity),dt);
        }
    }
}