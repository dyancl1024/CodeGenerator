using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_Temp_BasicData_TrainingSub ( RH_Temp_BasicData_TrainingSub ) DB类
    ///</summary>
    public class Temp_BasicData_TrainingSubDB
    {

        /// <summary>
        /// 添加RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTemp_BasicData_TrainingSub(Temp_BasicData_TrainingSubEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Temp_BasicData_TrainingSub_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTemp_BasicData_TrainingSub(Temp_BasicData_TrainingSubEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_Temp_BasicData_TrainingSub_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTemp_BasicData_TrainingSub(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_Temp_BasicData_TrainingSub_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_Temp_BasicData_TrainingSub
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Temp_BasicData_TrainingSubEntity GetTemp_BasicData_TrainingSubDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_Temp_BasicData_TrainingSub_Detail", param, DBConnEnm.TRDBWrite);
            return (Temp_BasicData_TrainingSubEntity)ORMapping.MapSingleObject(typeof(Temp_BasicData_TrainingSubEntity),dt);
        }
    }
}