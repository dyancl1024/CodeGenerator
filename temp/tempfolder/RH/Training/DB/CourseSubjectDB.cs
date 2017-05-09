using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_CourseSubject ( RH_CourseSubject ) DB类
    ///</summary>
    public class CourseSubjectDB
    {

        /// <summary>
        /// 添加RH_CourseSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseSubject(CourseSubjectEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_CourseID",info.CourseID);
            param.Add("@i_GradeCode",info.GradeCode);
            param.Add("@i_SubjectCode",info.SubjectCode);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseSubject_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CourseSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseSubject(CourseSubjectEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_CourseID",info.CourseID);
            param.Add("@i_GradeCode",info.GradeCode);
            param.Add("@i_SubjectCode",info.SubjectCode);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseSubject_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CourseSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseSubject(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseSubject_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CourseSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseSubjectInfo GetCourseSubjectDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_CourseSubject_Detail", param, DBConnEnm.TRDBWrite);

            return (CourseSubjectInfo)ORMapping.MapSingleObject(typeof(CourseSubjectInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_CourseSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseSubjectEntityListResult GetCourseSubjectEntityList(CourseSubjectSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_CourseSubject_List", param, DBConnEnm.TRDBWrite);

            CourseSubjectEntityListResult Result= new CourseSubjectEntityListResult();
            Result.CourseSubjectList = (List<CourseSubjectInfo>)ORMapping.MapListObject(typeof(CourseSubjectInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}