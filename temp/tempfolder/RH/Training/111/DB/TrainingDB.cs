using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Training ( RH_Training ) DB类
    ///</summary>
    public class TrainingDB
    {

        /// <summary>
        /// 添加RH_Training
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTraining(TrainingEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Training_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Training
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTraining(TrainingEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_Training_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Training
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTraining(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Training_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Training
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingEntity GetTrainingDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_Training_Detail", param, DBConnEnm.TRDBWrite);
            return (TrainingEntity)ORMapping.MapSingleObject(typeof(TrainingEntity),dt);
        }
    }
}