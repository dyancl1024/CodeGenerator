using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Grade ( RH_Grade ) DB类
    ///</summary>
    public class GradeDB
    {

        /// <summary>
        /// 添加RH_Grade
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddGrade(GradeEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_Name",info.Name);
            param.Add("@i_Code",info.Code);
            param.Add("@i_Sort",info.Sort);
            param.Add("@i_ParentID",info.ParentID);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Grade_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Grade
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyGrade(GradeEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_Name",info.Name);
            param.Add("@i_Code",info.Code);
            param.Add("@i_Sort",info.Sort);
            param.Add("@i_ParentID",info.ParentID);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Grade_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Grade
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveGrade(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Grade_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Grade
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static GradeInfo GetGradeDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_Grade_Detail", param, DBConnEnm.TRDBWrite);

            return (GradeInfo)ORMapping.MapSingleObject(typeof(GradeInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_Grade
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static GradeEntityListResult GetGradeEntityList(GradeSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_Grade_List", param, DBConnEnm.TRDBWrite);

            GradeEntityListResult Result= new GradeEntityListResult();
            Result.GradeList = (List<GradeInfo>)ORMapping.MapListObject(typeof(GradeInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}