using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

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
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CourseTheme_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CourseTheme
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseTheme(CourseThemeEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_CourseTheme_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CourseTheme
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseTheme(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CourseTheme_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CourseTheme
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseThemeEntity GetCourseThemeDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_CourseTheme_Detail", param, DBConnEnm.TRDBWrite);
            return (CourseThemeEntity)ORMapping.MapSingleObject(typeof(CourseThemeEntity),dt);
        }
    }
}