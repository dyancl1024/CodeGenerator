using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;
using RH.Utility.StringLib;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingStudyGroup ( RH_TrainingStudyGroup ) DB类
    ///</summary>
    public class TrainingStudyGroupDB
    {

        /// <summary>
        /// 添加RH_TrainingStudyGroup
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingStudyGroup(TrainingStudyGroupEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingStudyGroup_Add", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingStudyGroup
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingStudyGroup(TrainingStudyGroupEntity info)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@XML", SerializeLib.Class2XML(info));
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingStudyGroup_Modify", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingStudyGroup
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingStudyGroup(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            param.AddByOutput("@Result", SqlDbType.Int);
            DBLib.ExecuteSP("dbo.SJ_RH_TrainingStudyGroup_Remove", param, DBConnEnm.TRDBWrite);
            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingStudyGroup
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingStudyGroupEntity GetTrainingStudyGroupDetail(int ID)
        {
            ParamCollection param = new ParamCollection();
            param.Add("@ID", ID);
            DataTable dt = DBLib.GetDataTableBySP("dbo.SJ_RH_TrainingStudyGroup_Detail", param, DBConnEnm.TRDBWrite);
            return (TrainingStudyGroupEntity)ORMapping.MapSingleObject(typeof(TrainingStudyGroupEntity),dt);
        }
    }
}