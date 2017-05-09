using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingClassUserRelation ( RH_TrainingClassUserRelation ) DB类
    ///</summary>
    public class TrainingClassUserRelationDB
    {

        /// <summary>
        /// 添加RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingClassUserRelation(TrainingClassUserRelationEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingClassUserRelation_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingClassUserRelation(TrainingClassUserRelationEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingClassUserRelation_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingClassUserRelation(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingClassUserRelation_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassUserRelationEntity GetTrainingClassUserRelationDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_TrainingClassUserRelation_Detail", param, DBConnEnm.TRDBWrite);
            return (TrainingClassUserRelationEntity)ORMapping.MapSingleObject(typeof(TrainingClassUserRelationEntity),dt);
        }
    }
}