using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_CoursePreSetList ( RH_CoursePreSetList ) DB类
    ///</summary>
    public class CoursePreSetListDB
    {

        /// <summary>
        /// 添加RH_CoursePreSetList
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCoursePreSetList(CoursePreSetListEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PreSetID",info.PreSetID);
            param.Add("@i_CourseID",info.CourseID);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CoursePreSetList_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CoursePreSetList
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCoursePreSetList(CoursePreSetListEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_PreSetID",info.PreSetID);
            param.Add("@i_CourseID",info.CourseID);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CoursePreSetList_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CoursePreSetList
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCoursePreSetList(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CoursePreSetList_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CoursePreSetList
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CoursePreSetListInfo GetCoursePreSetListDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_CoursePreSetList_Detail", param, DBConnEnm.TRDBWrite);

            return (CoursePreSetListInfo)ORMapping.MapSingleObject(typeof(CoursePreSetListInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_CoursePreSetList
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CoursePreSetListEntityListResult GetCoursePreSetListEntityList(CoursePreSetListSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_CoursePreSetList_List", param, DBConnEnm.TRDBWrite);

            CoursePreSetListEntityListResult Result= new CoursePreSetListEntityListResult();
            Result.CoursePreSetListList = (List<CoursePreSetListInfo>)ORMapping.MapListObject(typeof(CoursePreSetListInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}