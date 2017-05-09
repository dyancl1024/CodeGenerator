using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_CourseOption ( RH_CourseOption ) DB类
    ///</summary>
    public class CourseOptionDB
    {

        /// <summary>
        /// 添加RH_CourseOption
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseOption(CourseOptionEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_QuestionID",info.QuestionID);
            param.Add("@i_QOption",info.QOption);
            param.Add("@i_Sort",info.Sort);
            param.Add("@i_IsRight",info.IsRight);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseOption_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CourseOption
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseOption(CourseOptionEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_QuestionID",info.QuestionID);
            param.Add("@i_QOption",info.QOption);
            param.Add("@i_Sort",info.Sort);
            param.Add("@i_IsRight",info.IsRight);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseOption_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CourseOption
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseOption(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseOption_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CourseOption
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseOptionInfo GetCourseOptionDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_CourseOption_Detail", param, DBConnEnm.TRDBWrite);

            return (CourseOptionInfo)ORMapping.MapSingleObject(typeof(CourseOptionInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_CourseOption
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseOptionEntityListResult GetCourseOptionEntityList(CourseOptionSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_CourseOption_List", param, DBConnEnm.TRDBWrite);

            CourseOptionEntityListResult Result= new CourseOptionEntityListResult();
            Result.CourseOptionList = (List<CourseOptionInfo>)ORMapping.MapListObject(typeof(CourseOptionInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}