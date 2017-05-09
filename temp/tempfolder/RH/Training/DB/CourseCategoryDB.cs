using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_CourseCategory ( RH_CourseCategory ) DB类
    ///</summary>
    public class CourseCategoryDB
    {

        /// <summary>
        /// 添加RH_CourseCategory
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseCategory(CourseCategoryEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_Name",info.Name);
            param.Add("@i_Code",info.Code);
            param.Add("@i_Type",info.Type);
            param.Add("@i_Sort",info.Sort);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseCategory_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CourseCategory
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseCategory(CourseCategoryEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_Name",info.Name);
            param.Add("@i_Code",info.Code);
            param.Add("@i_Type",info.Type);
            param.Add("@i_Sort",info.Sort);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseCategory_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CourseCategory
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseCategory(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseCategory_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CourseCategory
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseCategoryInfo GetCourseCategoryDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_CourseCategory_Detail", param, DBConnEnm.TRDBWrite);

            return (CourseCategoryInfo)ORMapping.MapSingleObject(typeof(CourseCategoryInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_CourseCategory
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseCategoryEntityListResult GetCourseCategoryEntityList(CourseCategorySearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_CourseCategory_List", param, DBConnEnm.TRDBWrite);

            CourseCategoryEntityListResult Result= new CourseCategoryEntityListResult();
            Result.CourseCategoryList = (List<CourseCategoryInfo>)ORMapping.MapListObject(typeof(CourseCategoryInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}