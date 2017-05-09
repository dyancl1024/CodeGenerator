using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_CoursePreset ( RH_CoursePreset ) DB类
    ///</summary>
    public class CoursePresetDB
    {

        /// <summary>
        /// 添加RH_CoursePreset
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCoursePreset(CoursePresetEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_Name",info.Name);
            param.Add("@i_CPDesc",info.CPDesc);
            param.Add("@i_IfPromote",info.IfPromote);
            param.Add("@i_IsRequired",info.IsRequired);
            param.Add("@i_CourseLevel",info.CourseLevel);
            param.Add("@i_Dimension",info.Dimension);
            param.Add("@i_Version",info.Version);
            param.Add("@i_parentID",info.parentID);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CoursePreset_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CoursePreset
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCoursePreset(CoursePresetEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_Name",info.Name);
            param.Add("@i_CPDesc",info.CPDesc);
            param.Add("@i_IfPromote",info.IfPromote);
            param.Add("@i_IsRequired",info.IsRequired);
            param.Add("@i_CourseLevel",info.CourseLevel);
            param.Add("@i_Dimension",info.Dimension);
            param.Add("@i_Version",info.Version);
            param.Add("@i_parentID",info.parentID);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CoursePreset_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CoursePreset
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCoursePreset(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CoursePreset_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CoursePreset
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CoursePresetInfo GetCoursePresetDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_CoursePreset_Detail", param, DBConnEnm.TRDBWrite);

            return (CoursePresetInfo)ORMapping.MapSingleObject(typeof(CoursePresetInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_CoursePreset
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CoursePresetEntityListResult GetCoursePresetEntityList(CoursePresetSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_CoursePreset_List", param, DBConnEnm.TRDBWrite);

            CoursePresetEntityListResult Result= new CoursePresetEntityListResult();
            Result.CoursePresetList = (List<CoursePresetInfo>)ORMapping.MapListObject(typeof(CoursePresetInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}