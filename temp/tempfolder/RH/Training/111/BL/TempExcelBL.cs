using System.Collections.Generic;
using RH.Training.DB;
using RH.Training.Entity;

namespace RH.Training.BL
{
    ///<summary>
    ///RH_TempExcel ( RH_TempExcel ) BL类
    ///</summary>
    public class TempExcelBL
    {

        /// <summary>
        /// 添加RH_TempExcel
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTempExcel(TempExcelEntity info)
        {
            return TempExcelDB.AddTempExcel(info);
        }


        /// <summary>
        /// 修改RH_TempExcel
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTempExcel(TempExcelEntity info)
        {
            return TempExcelDB.ModifyTempExcel(info);
        }


        /// <summary>
        /// 删除RH_TempExcel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTempExcel(int ID)
        {
            return TempExcelDB.RemoveTempExcel(ID);
        }

        /// <summary>
        /// 查看RH_TempExcel
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TempExcelEntity GetTempExcelDetail(int ID)
        {
            return TempExcelDB.GetTempExcelDetail(ID);
        }
    }
}