using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingHomeWorkType ( RH_TrainingHomeWorkType ) DB类
    ///</summary>
    public class TrainingHomeWorkTypeDB
    {

        /// <summary>
        /// 添加RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingHomeWorkType(TrainingHomeWorkTypeEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingHomeWorkType_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingHomeWorkType(TrainingHomeWorkTypeEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingHomeWorkType_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingHomeWorkType(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingHomeWorkType_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingHomeWorkType
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingHomeWorkTypeEntity GetTrainingHomeWorkTypeDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_TrainingHomeWorkType_Detail", param, DBConnEnm.TRDBWrite);
            return (TrainingHomeWorkTypeEntity)ORMapping.MapSingleObject(typeof(TrainingHomeWorkTypeEntity),dt);
        }
    }
}