using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingTeacherSummary ( RH_TrainingTeacherSummary ) DB类
    ///</summary>
    public class TrainingTeacherSummaryDB
    {

        /// <summary>
        /// 添加RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingTeacherSummary(TrainingTeacherSummaryEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_TID",info.TID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_Ttype",info.Ttype);
            param.Add("@i_TeacherSummaryTitle",info.TeacherSummaryTitle);
            param.Add("@i_TeacherSummaryContent",info.TeacherSummaryContent);
            param.Add("@i_StaticUrl",info.StaticUrl);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingTeacherSummary_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingTeacherSummary(TrainingTeacherSummaryEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_TID",info.TID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_Ttype",info.Ttype);
            param.Add("@i_TeacherSummaryTitle",info.TeacherSummaryTitle);
            param.Add("@i_TeacherSummaryContent",info.TeacherSummaryContent);
            param.Add("@i_StaticUrl",info.StaticUrl);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingTeacherSummary_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingTeacherSummary(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingTeacherSummary_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingTeacherSummaryInfo GetTrainingTeacherSummaryDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingTeacherSummary_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingTeacherSummaryInfo)ORMapping.MapSingleObject(typeof(TrainingTeacherSummaryInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingTeacherSummary
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingTeacherSummaryEntityListResult GetTrainingTeacherSummaryEntityList(TrainingTeacherSummarySearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingTeacherSummary_List", param, DBConnEnm.TRDBWrite);

            TrainingTeacherSummaryEntityListResult Result= new TrainingTeacherSummaryEntityListResult();
            Result.TrainingTeacherSummaryList = (List<TrainingTeacherSummaryInfo>)ORMapping.MapListObject(typeof(TrainingTeacherSummaryInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}