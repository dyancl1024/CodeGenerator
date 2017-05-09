using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

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
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CourseCategory_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CourseCategory
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseCategory(CourseCategoryEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_CourseCategory_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CourseCategory
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseCategory(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CourseCategory_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CourseCategory
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseCategoryEntity GetCourseCategoryDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_CourseCategory_Detail", param, DBConnEnm.TRDBWrite);
            return (CourseCategoryEntity)ORMapping.MapSingleObject(typeof(CourseCategoryEntity),dt);
        }
    }
}