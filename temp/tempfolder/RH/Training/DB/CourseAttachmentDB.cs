using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_CourseAttachment ( RH_CourseAttachment ) DB类
    ///</summary>
    public class CourseAttachmentDB
    {

        /// <summary>
        /// 添加RH_CourseAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseAttachment(CourseAttachmentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_CourseID",info.CourseID);
            param.Add("@i_AttachmentName",info.AttachmentName);
            param.Add("@i_AttachmentUrl",info.AttachmentUrl);
            param.Add("@i_AttachmentType",info.AttachmentType);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseAttachment_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CourseAttachment
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseAttachment(CourseAttachmentEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_CourseID",info.CourseID);
            param.Add("@i_AttachmentName",info.AttachmentName);
            param.Add("@i_AttachmentUrl",info.AttachmentUrl);
            param.Add("@i_AttachmentType",info.AttachmentType);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseAttachment_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CourseAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseAttachment(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseAttachment_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CourseAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseAttachmentInfo GetCourseAttachmentDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_CourseAttachment_Detail", param, DBConnEnm.TRDBWrite);

            return (CourseAttachmentInfo)ORMapping.MapSingleObject(typeof(CourseAttachmentInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_CourseAttachment
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseAttachmentEntityListResult GetCourseAttachmentEntityList(CourseAttachmentSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_CourseAttachment_List", param, DBConnEnm.TRDBWrite);

            CourseAttachmentEntityListResult Result= new CourseAttachmentEntityListResult();
            Result.CourseAttachmentList = (List<CourseAttachmentInfo>)ORMapping.MapListObject(typeof(CourseAttachmentInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}