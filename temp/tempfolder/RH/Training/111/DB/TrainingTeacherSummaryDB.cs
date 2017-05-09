using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingTeacherSummary ( RH_TrainingTeacherSummary ) DB类
    ///</summary>
    public class TrainingTeacherSummaryDB
    {

        /// <summary>
        /// 添加RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingTeacherSummary(TrainingTeacherSummaryEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingTeacherSummary_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingTeacherSummary(TrainingTeacherSummaryEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingTeacherSummary_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingTeacherSummary(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingTeacherSummary_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingTeacherSummaryEntity GetTrainingTeacherSummaryDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_TrainingTeacherSummary_Detail", param, DBConnEnm.TRDBWrite);
            return (TrainingTeacherSummaryEntity)ORMapping.MapSingleObject(typeof(TrainingTeacherSummaryEntity),dt);
        }
    }
}