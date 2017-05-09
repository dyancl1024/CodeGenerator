using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_CourseThemeRelation ( RH_CourseThemeRelation ) DB类
    ///</summary>
    public class CourseThemeRelationDB
    {

        /// <summary>
        /// 添加RH_CourseThemeRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseThemeRelation(CourseThemeRelationEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_CourseID",info.CourseID);
            param.Add("@i_CourseThemeCode",info.CourseThemeCode);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseThemeRelation_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CourseThemeRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseThemeRelation(CourseThemeRelationEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_CourseID",info.CourseID);
            param.Add("@i_CourseThemeCode",info.CourseThemeCode);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseThemeRelation_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CourseThemeRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseThemeRelation(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseThemeRelation_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CourseThemeRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseThemeRelationInfo GetCourseThemeRelationDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_CourseThemeRelation_Detail", param, DBConnEnm.TRDBWrite);

            return (CourseThemeRelationInfo)ORMapping.MapSingleObject(typeof(CourseThemeRelationInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_CourseThemeRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseThemeRelationEntityListResult GetCourseThemeRelationEntityList(CourseThemeRelationSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_CourseThemeRelation_List", param, DBConnEnm.TRDBWrite);

            CourseThemeRelationEntityListResult Result= new CourseThemeRelationEntityListResult();
            Result.CourseThemeRelationList = (List<CourseThemeRelationInfo>)ORMapping.MapListObject(typeof(CourseThemeRelationInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}