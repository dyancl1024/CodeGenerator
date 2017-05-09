using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingClass ( RH_TrainingClass ) DB类
    ///</summary>
    public class TrainingClassDB
    {

        /// <summary>
        /// 添加RH_TrainingClass
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingClass(TrainingClassEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingClass_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingClass
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingClass(TrainingClassEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingClass_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingClass
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingClass(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingClass_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingClass
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassEntity GetTrainingClassDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_TrainingClass_Detail", param, DBConnEnm.TRDBWrite);
            return (TrainingClassEntity)ORMapping.MapSingleObject(typeof(TrainingClassEntity),dt);
        }
    }
}