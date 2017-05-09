using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

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
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CourseSubject_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CourseSubject
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseSubject(CourseSubjectEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_CourseSubject_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CourseSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseSubject(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CourseSubject_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CourseSubject
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseSubjectEntity GetCourseSubjectDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_CourseSubject_Detail", param, DBConnEnm.TRDBWrite);
            return (CourseSubjectEntity)ORMapping.MapSingleObject(typeof(CourseSubjectEntity),dt);
        }
    }
}