using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_School ( RH_School ) DB类
    ///</summary>
    public class SchoolDB
    {

        /// <summary>
        /// 添加RH_School
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddSchool(SchoolEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_DistrictID",info.DistrictID);
            param.Add("@i_SchoolName",info.SchoolName);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_School_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_School
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifySchool(SchoolEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_DistrictID",info.DistrictID);
            param.Add("@i_SchoolName",info.SchoolName);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_School_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_School
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveSchool(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_School_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_School
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static SchoolInfo GetSchoolDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_School_Detail", param, DBConnEnm.TRDBWrite);

            return (SchoolInfo)ORMapping.MapSingleObject(typeof(SchoolInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_School
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static SchoolEntityListResult GetSchoolEntityList(SchoolSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_School_List", param, DBConnEnm.TRDBWrite);

            SchoolEntityListResult Result= new SchoolEntityListResult();
            Result.SchoolList = (List<SchoolInfo>)ORMapping.MapListObject(typeof(SchoolInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}