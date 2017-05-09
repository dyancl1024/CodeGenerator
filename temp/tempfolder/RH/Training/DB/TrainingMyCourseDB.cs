using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingMyCourse ( RH_TrainingMyCourse ) DB类
    ///</summary>
    public class TrainingMyCourseDB
    {

        /// <summary>
        /// 添加RH_TrainingMyCourse
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingMyCourse(TrainingMyCourseEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_PCID",info.PCID);
            param.Add("@i_CID",info.CID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_Status",info.Status);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingMyCourse_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingMyCourse
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingMyCourse(TrainingMyCourseEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_PCID",info.PCID);
            param.Add("@i_CID",info.CID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_Status",info.Status);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingMyCourse_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingMyCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingMyCourse(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingMyCourse_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingMyCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingMyCourseInfo GetTrainingMyCourseDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingMyCourse_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingMyCourseInfo)ORMapping.MapSingleObject(typeof(TrainingMyCourseInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingMyCourse
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingMyCourseEntityListResult GetTrainingMyCourseEntityList(TrainingMyCourseSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingMyCourse_List", param, DBConnEnm.TRDBWrite);

            TrainingMyCourseEntityListResult Result= new TrainingMyCourseEntityListResult();
            Result.TrainingMyCourseList = (List<TrainingMyCourseInfo>)ORMapping.MapListObject(typeof(TrainingMyCourseInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}