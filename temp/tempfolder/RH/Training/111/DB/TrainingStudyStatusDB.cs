using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingStudyStatus ( RH_TrainingStudyStatus ) DB类
    ///</summary>
    public class TrainingStudyStatusDB
    {

        /// <summary>
        /// 添加RH_TrainingStudyStatus
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingStudyStatus(TrainingStudyStatusEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingStudyStatus_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingStudyStatus
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingStudyStatus(TrainingStudyStatusEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingStudyStatus_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingStudyStatus
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingStudyStatus(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingStudyStatus_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingStudyStatus
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingStudyStatusEntity GetTrainingStudyStatusDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_TrainingStudyStatus_Detail", param, DBConnEnm.TRDBWrite);
            return (TrainingStudyStatusEntity)ORMapping.MapSingleObject(typeof(TrainingStudyStatusEntity),dt);
        }
    }
}