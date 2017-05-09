using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_CourseQuestion ( RH_CourseQuestion ) DB类
    ///</summary>
    public class CourseQuestionDB
    {

        /// <summary>
        /// 添加RH_CourseQuestion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseQuestion(CourseQuestionEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_CourseID",info.CourseID);
            param.Add("@i_Question",info.Question);
            param.Add("@i_QType",info.QType);
            param.Add("@i_Sort",info.Sort);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseQuestion_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CourseQuestion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseQuestion(CourseQuestionEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_CourseID",info.CourseID);
            param.Add("@i_Question",info.Question);
            param.Add("@i_QType",info.QType);
            param.Add("@i_Sort",info.Sort);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseQuestion_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CourseQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseQuestion(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseQuestion_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CourseQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseQuestionInfo GetCourseQuestionDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_CourseQuestion_Detail", param, DBConnEnm.TRDBWrite);

            return (CourseQuestionInfo)ORMapping.MapSingleObject(typeof(CourseQuestionInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_CourseQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseQuestionEntityListResult GetCourseQuestionEntityList(CourseQuestionSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_CourseQuestion_List", param, DBConnEnm.TRDBWrite);

            CourseQuestionEntityListResult Result= new CourseQuestionEntityListResult();
            Result.CourseQuestionList = (List<CourseQuestionInfo>)ORMapping.MapListObject(typeof(CourseQuestionInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}