using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_CourseAnswer ( RH_CourseAnswer ) DB类
    ///</summary>
    public class CourseAnswerDB
    {

        /// <summary>
        /// 添加RH_CourseAnswer
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseAnswer(CourseAnswerEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CourseAnswer_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CourseAnswer
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseAnswer(CourseAnswerEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_CourseAnswer_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CourseAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseAnswer(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CourseAnswer_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CourseAnswer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseAnswerEntity GetCourseAnswerDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_CourseAnswer_Detail", param, DBConnEnm.TRDBWrite);
            return (CourseAnswerEntity)ORMapping.MapSingleObject(typeof(CourseAnswerEntity),dt);
        }
    }
}