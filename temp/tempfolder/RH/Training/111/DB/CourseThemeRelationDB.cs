using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_CourseThemeRelation ( RH_CourseThemeRelation ) DB类
    ///</summary>
    public class CourseThemeRelationDB
    {

        /// <summary>
        /// 添加RH_CourseThemeRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseThemeRelation(CourseThemeRelationEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CourseThemeRelation_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CourseThemeRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseThemeRelation(CourseThemeRelationEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_CourseThemeRelation_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CourseThemeRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseThemeRelation(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CourseThemeRelation_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CourseThemeRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseThemeRelationEntity GetCourseThemeRelationDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_CourseThemeRelation_Detail", param, DBConnEnm.TRDBWrite);
            return (CourseThemeRelationEntity)ORMapping.MapSingleObject(typeof(CourseThemeRelationEntity),dt);
        }
    }
}