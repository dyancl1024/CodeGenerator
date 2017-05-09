using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_CourseTheme ( RH_CourseTheme ) DB类
    ///</summary>
    public class CourseThemeDB
    {

        /// <summary>
        /// 添加RH_CourseTheme
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseTheme(CourseThemeEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_Name",info.Name);
            param.Add("@i_Code",info.Code);
            param.Add("@i_Sort",info.Sort);
            param.Add("@i_Type",info.Type);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseTheme_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CourseTheme
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseTheme(CourseThemeEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_Name",info.Name);
            param.Add("@i_Code",info.Code);
            param.Add("@i_Sort",info.Sort);
            param.Add("@i_Type",info.Type);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseTheme_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CourseTheme
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseTheme(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseTheme_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CourseTheme
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseThemeInfo GetCourseThemeDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_CourseTheme_Detail", param, DBConnEnm.TRDBWrite);

            return (CourseThemeInfo)ORMapping.MapSingleObject(typeof(CourseThemeInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_CourseTheme
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseThemeEntityListResult GetCourseThemeEntityList(CourseThemeSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_CourseTheme_List", param, DBConnEnm.TRDBWrite);

            CourseThemeEntityListResult Result= new CourseThemeEntityListResult();
            Result.CourseThemeList = (List<CourseThemeInfo>)ORMapping.MapListObject(typeof(CourseThemeInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}