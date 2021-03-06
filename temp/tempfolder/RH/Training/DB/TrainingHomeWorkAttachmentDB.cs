using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingHomeWorkAttachment ( RH_TrainingHomeWorkAttachment ) DB类
    ///</summary>
    public class TrainingHomeWorkAttachmentDB
    {

        /// <summary>
        /// 添加RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingHomeWorkAttachment(TrainingHomeWorkAttachmentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_HomeWorkID",info.HomeWorkID);
            param.Add("@i_AttachmentName",info.AttachmentName);
            param.Add("@i_AttachmentUrl",info.AttachmentUrl);
            param.Add("@i_AttachmentType",info.AttachmentType);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingHomeWorkAttachment_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingHomeWorkAttachment(TrainingHomeWorkAttachmentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_HomeWorkID",info.HomeWorkID);
            param.Add("@i_AttachmentName",info.AttachmentName);
            param.Add("@i_AttachmentUrl",info.AttachmentUrl);
            param.Add("@i_AttachmentType",info.AttachmentType);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingHomeWorkAttachment_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingHomeWorkAttachment(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingHomeWorkAttachment_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingHomeWorkAttachmentInfo GetTrainingHomeWorkAttachmentDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingHomeWorkAttachment_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingHomeWorkAttachmentInfo)ORMapping.MapSingleObject(typeof(TrainingHomeWorkAttachmentInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingHomeWorkAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingHomeWorkAttachmentEntityListResult GetTrainingHomeWorkAttachmentEntityList(TrainingHomeWorkAttachmentSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingHomeWorkAttachment_List", param, DBConnEnm.TRDBWrite);

            TrainingHomeWorkAttachmentEntityListResult Result= new TrainingHomeWorkAttachmentEntityListResult();
            Result.TrainingHomeWorkAttachmentList = (List<TrainingHomeWorkAttachmentInfo>)ORMapping.MapListObject(typeof(TrainingHomeWorkAttachmentInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}