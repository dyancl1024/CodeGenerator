using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_CourseQuestion ( RH_CourseQuestion ) DB类
    ///</summary>
    public class CourseQuestionDB
    {

        /// <summary>
        /// 添加RH_CourseQuestion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseQuestion(CourseQuestionEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CourseQuestion_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CourseQuestion
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseQuestion(CourseQuestionEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_CourseQuestion_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CourseQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseQuestion(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_CourseQuestion_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CourseQuestion
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseQuestionEntity GetCourseQuestionDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_CourseQuestion_Detail", param, DBConnEnm.TRDBWrite);
            return (CourseQuestionEntity)ORMapping.MapSingleObject(typeof(CourseQuestionEntity),dt);
        }
    }
}