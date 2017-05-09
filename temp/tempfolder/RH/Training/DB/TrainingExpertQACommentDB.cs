using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingExpertQAComment ( RH_TrainingExpertQAComment ) DB类
    ///</summary>
    public class TrainingExpertQACommentDB
    {

        /// <summary>
        /// 添加RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingExpertQAComment(TrainingExpertQACommentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_QAID",info.QAID);
            param.Add("@i_Comment",info.Comment);
            param.Add("@i_IPAdress",info.IPAdress);
            param.Add("@i_ParentID",info.ParentID);
            param.Add("@i_IsExpert",info.IsExpert);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingExpertQAComment_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingExpertQAComment(TrainingExpertQACommentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_QAID",info.QAID);
            param.Add("@i_Comment",info.Comment);
            param.Add("@i_IPAdress",info.IPAdress);
            param.Add("@i_ParentID",info.ParentID);
            param.Add("@i_IsExpert",info.IsExpert);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingExpertQAComment_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingExpertQAComment(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingExpertQAComment_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingExpertQACommentInfo GetTrainingExpertQACommentDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingExpertQAComment_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingExpertQACommentInfo)ORMapping.MapSingleObject(typeof(TrainingExpertQACommentInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingExpertQAComment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingExpertQACommentEntityListResult GetTrainingExpertQACommentEntityList(TrainingExpertQACommentSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingExpertQAComment_List", param, DBConnEnm.TRDBWrite);

            TrainingExpertQACommentEntityListResult Result= new TrainingExpertQACommentEntityListResult();
            Result.TrainingExpertQACommentList = (List<TrainingExpertQACommentInfo>)ORMapping.MapListObject(typeof(TrainingExpertQACommentInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}