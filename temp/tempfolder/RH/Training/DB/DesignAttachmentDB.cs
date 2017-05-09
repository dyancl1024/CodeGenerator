using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_DesignAttachment ( RH_DesignAttachment ) DB类
    ///</summary>
    public class DesignAttachmentDB
    {

        /// <summary>
        /// 添加RH_DesignAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignAttachment(DesignAttachmentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_DesignID",info.DesignID);
            param.Add("@i_AttachmentName",info.AttachmentName);
            param.Add("@i_AttachmentUrl",info.AttachmentUrl);
            param.Add("@i_AttachmentType",info.AttachmentType);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignAttachment_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_DesignAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignAttachment(DesignAttachmentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_DesignID",info.DesignID);
            param.Add("@i_AttachmentName",info.AttachmentName);
            param.Add("@i_AttachmentUrl",info.AttachmentUrl);
            param.Add("@i_AttachmentType",info.AttachmentType);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignAttachment_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_DesignAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignAttachment(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignAttachment_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_DesignAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignAttachmentInfo GetDesignAttachmentDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_DesignAttachment_Detail", param, DBConnEnm.TRDBWrite);

            return (DesignAttachmentInfo)ORMapping.MapSingleObject(typeof(DesignAttachmentInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_DesignAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignAttachmentEntityListResult GetDesignAttachmentEntityList(DesignAttachmentSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_DesignAttachment_List", param, DBConnEnm.TRDBWrite);

            DesignAttachmentEntityListResult Result= new DesignAttachmentEntityListResult();
            Result.DesignAttachmentList = (List<DesignAttachmentInfo>)ORMapping.MapListObject(typeof(DesignAttachmentInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}