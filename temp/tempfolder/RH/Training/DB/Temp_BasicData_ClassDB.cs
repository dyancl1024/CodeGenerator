using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Temp_BasicData_Class ( RH_Temp_BasicData_Class ) DB类
    ///</summary>
    public class Temp_BasicData_ClassDB
    {

        /// <summary>
        /// 添加RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTemp_BasicData_Class(Temp_BasicData_ClassEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_ClassID",info.ClassID);
            param.Add("@i_YX_HW",info.YX_HW);
            param.Add("@i_TJ_HW",info.TJ_HW);
            param.Add("@i_StudyNum",info.StudyNum);
            param.Add("@i_FinishedNum",info.FinishedNum);
            param.Add("@i_UserNum",info.UserNum);
            param.Add("@i_ClassRate",info.ClassRate);
            param.Add("@i_HG_HW",info.HG_HW);
            param.Add("@i_No_Num",info.No_Num);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Temp_BasicData_Class_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTemp_BasicData_Class(Temp_BasicData_ClassEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_ClassID",info.ClassID);
            param.Add("@i_YX_HW",info.YX_HW);
            param.Add("@i_TJ_HW",info.TJ_HW);
            param.Add("@i_StudyNum",info.StudyNum);
            param.Add("@i_FinishedNum",info.FinishedNum);
            param.Add("@i_UserNum",info.UserNum);
            param.Add("@i_ClassRate",info.ClassRate);
            param.Add("@i_HG_HW",info.HG_HW);
            param.Add("@i_No_Num",info.No_Num);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Temp_BasicData_Class_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTemp_BasicData_Class(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Temp_BasicData_Class_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Temp_BasicData_ClassInfo GetTemp_BasicData_ClassDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_Temp_BasicData_Class_Detail", param, DBConnEnm.TRDBWrite);

            return (Temp_BasicData_ClassInfo)ORMapping.MapSingleObject(typeof(Temp_BasicData_ClassInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_Temp_BasicData_Class
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Temp_BasicData_ClassEntityListResult GetTemp_BasicData_ClassEntityList(Temp_BasicData_ClassSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_Temp_BasicData_Class_List", param, DBConnEnm.TRDBWrite);

            Temp_BasicData_ClassEntityListResult Result= new Temp_BasicData_ClassEntityListResult();
            Result.Temp_BasicData_ClassList = (List<Temp_BasicData_ClassInfo>)ORMapping.MapListObject(typeof(Temp_BasicData_ClassInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}