using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_CourseLevelRelation ( RH_CourseLevelRelation ) DB类
    ///</summary>
    public class CourseLevelRelationDB
    {

        /// <summary>
        /// 添加RH_CourseLevelRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddCourseLevelRelation(CourseLevelRelationEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_CourseID",info.CourseID);
            param.Add("@i_CourseLevel",info.CourseLevel);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseLevelRelation_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_CourseLevelRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyCourseLevelRelation(CourseLevelRelationEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_CourseID",info.CourseID);
            param.Add("@i_CourseLevel",info.CourseLevel);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseLevelRelation_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_CourseLevelRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveCourseLevelRelation(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_CourseLevelRelation_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_CourseLevelRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseLevelRelationInfo GetCourseLevelRelationDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_CourseLevelRelation_Detail", param, DBConnEnm.TRDBWrite);

            return (CourseLevelRelationInfo)ORMapping.MapSingleObject(typeof(CourseLevelRelationInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_CourseLevelRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static CourseLevelRelationEntityListResult GetCourseLevelRelationEntityList(CourseLevelRelationSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_CourseLevelRelation_List", param, DBConnEnm.TRDBWrite);

            CourseLevelRelationEntityListResult Result= new CourseLevelRelationEntityListResult();
            Result.CourseLevelRelationList = (List<CourseLevelRelationInfo>)ORMapping.MapListObject(typeof(CourseLevelRelationInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}