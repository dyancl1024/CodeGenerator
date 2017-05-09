using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

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
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_FileExcel",info.FileExcel);
            param.Add("@i_TableName",info.TableName);
            param.Add("@i_TempRemark",info.TempRemark);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TempExcel_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TempExcel
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTempExcel(TempExcelEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_FileExcel",info.FileExcel);
            param.Add("@i_TableName",info.TableName);
            param.Add("@i_TempRemark",info.TempRemark);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TempExcel_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TempExcel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTempExcel(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TempExcel_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TempExcel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TempExcelInfo GetTempExcelDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TempExcel_Detail", param, DBConnEnm.TRDBWrite);

            return (TempExcelInfo)ORMapping.MapSingleObject(typeof(TempExcelInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TempExcel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TempExcelEntityListResult GetTempExcelEntityList(TempExcelSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TempExcel_List", param, DBConnEnm.TRDBWrite);

            TempExcelEntityListResult Result= new TempExcelEntityListResult();
            Result.TempExcelList = (List<TempExcelInfo>)ORMapping.MapListObject(typeof(TempExcelInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}