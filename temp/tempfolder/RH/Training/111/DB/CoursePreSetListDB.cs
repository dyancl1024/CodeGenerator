using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_CoursePreSetList ( RH_CoursePreSetList ) DB类
    ///</summary>
    public class CoursePreSetListDB
    {

        /// <summary>
        /// 添加RH_CoursePreSetList
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCoursePreSetList(CoursePreSetListEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CoursePreSetList_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CoursePreSetList
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCoursePreSetList(CoursePreSetListEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_CoursePreSetList_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CoursePreSetList
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCoursePreSetList(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CoursePreSetList_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CoursePreSetList
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CoursePreSetListEntity GetCoursePreSetListDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_CoursePreSetList_Detail", param, DBConnEnm.TRDBWrite);
            return (CoursePreSetListEntity)ORMapping.MapSingleObject(typeof(CoursePreSetListEntity),dt);
        }
    }
}