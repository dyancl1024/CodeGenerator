using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingBriefingComment ( RH_TrainingBriefingComment ) DB类
    ///</summary>
    public class TrainingBriefingCommentDB
    {

        /// <summary>
        /// 添加RH_TrainingBriefingComment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingBriefingComment(TrainingBriefingCommentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_TBID",info.TBID);
            param.Add("@i_Comment",info.Comment);
            param.Add("@i_IPAdress",info.IPAdress);
            param.Add("@i_ParentID",info.ParentID);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingBriefingComment_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingBriefingComment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingBriefingComment(TrainingBriefingCommentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_TBID",info.TBID);
            param.Add("@i_Comment",info.Comment);
            param.Add("@i_IPAdress",info.IPAdress);
            param.Add("@i_ParentID",info.ParentID);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingBriefingComment_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingBriefingComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingBriefingComment(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingBriefingComment_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingBriefingComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingBriefingCommentInfo GetTrainingBriefingCommentDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingBriefingComment_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingBriefingCommentInfo)ORMapping.MapSingleObject(typeof(TrainingBriefingCommentInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingBriefingComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingBriefingCommentEntityListResult GetTrainingBriefingCommentEntityList(TrainingBriefingCommentSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingBriefingComment_List", param, DBConnEnm.TRDBWrite);

            TrainingBriefingCommentEntityListResult Result= new TrainingBriefingCommentEntityListResult();
            Result.TrainingBriefingCommentList = (List<TrainingBriefingCommentInfo>)ORMapping.MapListObject(typeof(TrainingBriefingCommentInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}