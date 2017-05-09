using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

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
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Course_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Course
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourse(CourseEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_Course_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Course
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourse(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Course_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Course
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseEntity GetCourseDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_Course_Detail", param, DBConnEnm.TRDBWrite);
            return (CourseEntity)ORMapping.MapSingleObject(typeof(CourseEntity),dt);
        }
    }
}