using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingMyCourse ( RH_TrainingMyCourse ) DB类
    ///</summary>
    public class TrainingMyCourseDB
    {

        /// <summary>
        /// 添加RH_TrainingMyCourse
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingMyCourse(TrainingMyCourseEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingMyCourse_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingMyCourse
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingMyCourse(TrainingMyCourseEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingMyCourse_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingMyCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingMyCourse(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingMyCourse_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingMyCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingMyCourseEntity GetTrainingMyCourseDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_TrainingMyCourse_Detail", param, DBConnEnm.TRDBWrite);
            return (TrainingMyCourseEntity)ORMapping.MapSingleObject(typeof(TrainingMyCourseEntity),dt);
        }
    }
}