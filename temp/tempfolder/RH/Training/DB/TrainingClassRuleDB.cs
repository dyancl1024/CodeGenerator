using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingClassRule ( RH_TrainingClassRule ) DB类
    ///</summary>
    public class TrainingClassRuleDB
    {

        /// <summary>
        /// 添加RH_TrainingClassRule
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingClassRule(TrainingClassRuleEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_GradeCode",info.GradeCode);
            param.Add("@i_SubjectCode",info.SubjectCode);
            param.Add("@i_ClassNum",info.ClassNum);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingClassRule_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingClassRule
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingClassRule(TrainingClassRuleEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_GradeCode",info.GradeCode);
            param.Add("@i_SubjectCode",info.SubjectCode);
            param.Add("@i_ClassNum",info.ClassNum);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingClassRule_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingClassRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingClassRule(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingClassRule_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingClassRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassRuleInfo GetTrainingClassRuleDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingClassRule_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingClassRuleInfo)ORMapping.MapSingleObject(typeof(TrainingClassRuleInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingClassRule
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassRuleEntityListResult GetTrainingClassRuleEntityList(TrainingClassRuleSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingClassRule_List", param, DBConnEnm.TRDBWrite);

            TrainingClassRuleEntityListResult Result= new TrainingClassRuleEntityListResult();
            Result.TrainingClassRuleList = (List<TrainingClassRuleInfo>)ORMapping.MapListObject(typeof(TrainingClassRuleInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}