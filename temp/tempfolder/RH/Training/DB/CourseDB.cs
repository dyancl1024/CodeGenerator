using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Course ( RH_Course ) DB类
    ///</summary>
    public class CourseDB
    {

        /// <summary>
        /// 添加RH_Course
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourse(CourseEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_CourseName",info.CourseName);
            param.Add("@i_CoursePharse",info.CoursePharse);
            param.Add("@i_CourseCategoryCode",info.CourseCategoryCode);
            param.Add("@i_CourseDesc",info.CourseDesc);
            param.Add("@i_CourseUrl",info.CourseUrl);
            param.Add("@i_TeacherDesc",info.TeacherDesc);
            param.Add("@i_TeacherName",info.TeacherName);
            param.Add("@i_TeacherTitle",info.TeacherTitle);
            param.Add("@i_CourseLabel",info.CourseLabel);
            param.Add("@i_CourseCode",info.CourseCode);
            param.Add("@i_IsPractice",info.IsPractice);
            param.Add("@i_CourseCompany",info.CourseCompany);
            param.Add("@i_CourseStyle",info.CourseStyle);
            param.Add("@i_IsSpecialTeacher",info.IsSpecialTeacher);
            param.Add("@i_VideoDuration",info.VideoDuration);
            param.Add("@i_IsApp",info.IsApp);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Course_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Course
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourse(CourseEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_CourseName",info.CourseName);
            param.Add("@i_CoursePharse",info.CoursePharse);
            param.Add("@i_CourseCategoryCode",info.CourseCategoryCode);
            param.Add("@i_CourseDesc",info.CourseDesc);
            param.Add("@i_CourseUrl",info.CourseUrl);
            param.Add("@i_TeacherDesc",info.TeacherDesc);
            param.Add("@i_TeacherName",info.TeacherName);
            param.Add("@i_TeacherTitle",info.TeacherTitle);
            param.Add("@i_CourseLabel",info.CourseLabel);
            param.Add("@i_CourseCode",info.CourseCode);
            param.Add("@i_IsPractice",info.IsPractice);
            param.Add("@i_CourseCompany",info.CourseCompany);
            param.Add("@i_CourseStyle",info.CourseStyle);
            param.Add("@i_IsSpecialTeacher",info.IsSpecialTeacher);
            param.Add("@i_VideoDuration",info.VideoDuration);
            param.Add("@i_IsApp",info.IsApp);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Course_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Course
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourse(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_Course_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Course
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseInfo GetCourseDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_Course_Detail", param, DBConnEnm.TRDBWrite);

            return (CourseInfo)ORMapping.MapSingleObject(typeof(CourseInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_Course
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseEntityListResult GetCourseEntityList(CourseSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_Course_List", param, DBConnEnm.TRDBWrite);

            CourseEntityListResult Result= new CourseEntityListResult();
            Result.CourseList = (List<CourseInfo>)ORMapping.MapListObject(typeof(CourseInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}