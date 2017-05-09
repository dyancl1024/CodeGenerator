using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingMyCourseRecord ( RH_TrainingMyCourseRecord ) DB类
    ///</summary>
    public class TrainingMyCourseRecordDB
    {

        /// <summary>
        /// 添加RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingMyCourseRecord(TrainingMyCourseRecordEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_UserID",info.UserID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_PCID",info.PCID);
            param.Add("@i_CourseID",info.CourseID);
            param.Add("@i_WatchTime",info.WatchTime);
            param.Add("@i_TotalWatchTime",info.TotalWatchTime);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingMyCourseRecord_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingMyCourseRecord(TrainingMyCourseRecordEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_PCID",info.PCID);
            param.Add("@i_CourseID",info.CourseID);
            param.Add("@i_WatchTime",info.WatchTime);
            param.Add("@i_TotalWatchTime",info.TotalWatchTime);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingMyCourseRecord_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingMyCourseRecord(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingMyCourseRecord_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingMyCourseRecordInfo GetTrainingMyCourseRecordDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingMyCourseRecord_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingMyCourseRecordInfo)ORMapping.MapSingleObject(typeof(TrainingMyCourseRecordInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingMyCourseRecord
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingMyCourseRecordEntityListResult GetTrainingMyCourseRecordEntityList(TrainingMyCourseRecordSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingMyCourseRecord_List", param, DBConnEnm.TRDBWrite);

            TrainingMyCourseRecordEntityListResult Result= new TrainingMyCourseRecordEntityListResult();
            Result.TrainingMyCourseRecordList = (List<TrainingMyCourseRecordInfo>)ORMapping.MapListObject(typeof(TrainingMyCourseRecordInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}