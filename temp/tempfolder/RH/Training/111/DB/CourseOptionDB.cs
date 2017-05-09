using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

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
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CourseOption_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CourseOption
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseOption(CourseOptionEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_CourseOption_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CourseOption
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseOption(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CourseOption_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CourseOption
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseOptionEntity GetCourseOptionDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_CourseOption_Detail", param, DBConnEnm.TRDBWrite);
            return (CourseOptionEntity)ORMapping.MapSingleObject(typeof(CourseOptionEntity),dt);
        }
    }
}