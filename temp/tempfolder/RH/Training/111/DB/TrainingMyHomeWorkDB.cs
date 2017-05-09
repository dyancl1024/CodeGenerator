using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingMyHomeWork ( RH_TrainingMyHomeWork ) DB类
    ///</summary>
    public class TrainingMyHomeWorkDB
    {

        /// <summary>
        /// 添加RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingMyHomeWork(TrainingMyHomeWorkEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingMyHomeWork_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingMyHomeWork(TrainingMyHomeWorkEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingMyHomeWork_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingMyHomeWork(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingMyHomeWork_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingMyHomeWork
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingMyHomeWorkEntity GetTrainingMyHomeWorkDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_TrainingMyHomeWork_Detail", param, DBConnEnm.TRDBWrite);
            return (TrainingMyHomeWorkEntity)ORMapping.MapSingleObject(typeof(TrainingMyHomeWorkEntity),dt);
        }
    }
}