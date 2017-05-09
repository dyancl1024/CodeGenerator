using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingBriefing ( RH_TrainingBriefing ) DB类
    ///</summary>
    public class TrainingBriefingDB
    {

        /// <summary>
        /// 添加RH_TrainingBriefing
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingBriefing(TrainingBriefingEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingBriefing_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingBriefing
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingBriefing(TrainingBriefingEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingBriefing_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingBriefing
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingBriefing(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingBriefing_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingBriefing
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingBriefingEntity GetTrainingBriefingDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_TrainingBriefing_Detail", param, DBConnEnm.TRDBWrite);
            return (TrainingBriefingEntity)ORMapping.MapSingleObject(typeof(TrainingBriefingEntity),dt);
        }
    }
}