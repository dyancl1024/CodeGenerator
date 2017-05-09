using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingStudyGroupComment ( RH_TrainingStudyGroupComment ) DB类
    ///</summary>
    public class TrainingStudyGroupCommentDB
    {

        /// <summary>
        /// 添加RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingStudyGroupComment(TrainingStudyGroupCommentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_StudyGroupID",info.StudyGroupID);
            param.Add("@i_CommentTitile",info.CommentTitile);
            param.Add("@i_Comment",info.Comment);
            param.Add("@i_IPAdress",info.IPAdress);
            param.Add("@i_ParentID",info.ParentID);
            param.Add("@i_IsExpert",info.IsExpert);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingStudyGroupComment_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingStudyGroupComment(TrainingStudyGroupCommentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_StudyGroupID",info.StudyGroupID);
            param.Add("@i_CommentTitile",info.CommentTitile);
            param.Add("@i_Comment",info.Comment);
            param.Add("@i_IPAdress",info.IPAdress);
            param.Add("@i_ParentID",info.ParentID);
            param.Add("@i_IsExpert",info.IsExpert);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingStudyGroupComment_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingStudyGroupComment(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingStudyGroupComment_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingStudyGroupCommentInfo GetTrainingStudyGroupCommentDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingStudyGroupComment_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingStudyGroupCommentInfo)ORMapping.MapSingleObject(typeof(TrainingStudyGroupCommentInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingStudyGroupComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingStudyGroupCommentEntityListResult GetTrainingStudyGroupCommentEntityList(TrainingStudyGroupCommentSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingStudyGroupComment_List", param, DBConnEnm.TRDBWrite);

            TrainingStudyGroupCommentEntityListResult Result= new TrainingStudyGroupCommentEntityListResult();
            Result.TrainingStudyGroupCommentList = (List<TrainingStudyGroupCommentInfo>)ORMapping.MapListObject(typeof(TrainingStudyGroupCommentInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}