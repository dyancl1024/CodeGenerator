using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_DesignContentAttachment ( RH_DesignContentAttachment ) DB类
    ///</summary>
    public class DesignContentAttachmentDB
    {

        /// <summary>
        /// 添加RH_DesignContentAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddDesignContentAttachment(DesignContentAttachmentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_DesignContentID",info.DesignContentID);
            param.Add("@i_AttachementName",info.AttachementName);
            param.Add("@i_AttachmentUrl",info.AttachmentUrl);
            param.Add("@i_Version",info.Version);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignContentAttachment_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_DesignContentAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyDesignContentAttachment(DesignContentAttachmentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_DesignContentID",info.DesignContentID);
            param.Add("@i_AttachementName",info.AttachementName);
            param.Add("@i_AttachmentUrl",info.AttachmentUrl);
            param.Add("@i_Version",info.Version);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignContentAttachment_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_DesignContentAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveDesignContentAttachment(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_DesignContentAttachment_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_DesignContentAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignContentAttachmentInfo GetDesignContentAttachmentDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_DesignContentAttachment_Detail", param, DBConnEnm.TRDBWrite);

            return (DesignContentAttachmentInfo)ORMapping.MapSingleObject(typeof(DesignContentAttachmentInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_DesignContentAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static DesignContentAttachmentEntityListResult GetDesignContentAttachmentEntityList(DesignContentAttachmentSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_DesignContentAttachment_List", param, DBConnEnm.TRDBWrite);

            DesignContentAttachmentEntityListResult Result= new DesignContentAttachmentEntityListResult();
            Result.DesignContentAttachmentList = (List<DesignContentAttachmentInfo>)ORMapping.MapListObject(typeof(DesignContentAttachmentInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}