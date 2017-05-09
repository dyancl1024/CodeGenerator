using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingOtherAttachment ( RH_TrainingOtherAttachment ) DB类
    ///</summary>
    public class TrainingOtherAttachmentDB
    {

        /// <summary>
        /// 添加RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingOtherAttachment(TrainingOtherAttachmentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_TOID",info.TOID);
            param.Add("@i_AttachmentName",info.AttachmentName);
            param.Add("@i_AttachmentURL",info.AttachmentURL);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingOtherAttachment_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingOtherAttachment(TrainingOtherAttachmentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_TOID",info.TOID);
            param.Add("@i_AttachmentName",info.AttachmentName);
            param.Add("@i_AttachmentURL",info.AttachmentURL);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingOtherAttachment_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingOtherAttachment(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingOtherAttachment_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingOtherAttachmentInfo GetTrainingOtherAttachmentDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingOtherAttachment_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingOtherAttachmentInfo)ORMapping.MapSingleObject(typeof(TrainingOtherAttachmentInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingOtherAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingOtherAttachmentEntityListResult GetTrainingOtherAttachmentEntityList(TrainingOtherAttachmentSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingOtherAttachment_List", param, DBConnEnm.TRDBWrite);

            TrainingOtherAttachmentEntityListResult Result= new TrainingOtherAttachmentEntityListResult();
            Result.TrainingOtherAttachmentList = (List<TrainingOtherAttachmentInfo>)ORMapping.MapListObject(typeof(TrainingOtherAttachmentInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}