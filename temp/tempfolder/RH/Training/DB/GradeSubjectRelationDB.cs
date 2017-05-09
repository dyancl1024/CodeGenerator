using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_GradeSubjectRelation ( RH_GradeSubjectRelation ) DB类
    ///</summary>
    public class GradeSubjectRelationDB
    {

        /// <summary>
        /// 添加RH_GradeSubjectRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddGradeSubjectRelation(GradeSubjectRelationEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_GradeCode",info.GradeCode);
            param.Add("@i_SubjectCode",info.SubjectCode);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_GradeSubjectRelation_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_GradeSubjectRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyGradeSubjectRelation(GradeSubjectRelationEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_GradeCode",info.GradeCode);
            param.Add("@i_SubjectCode",info.SubjectCode);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_GradeSubjectRelation_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_GradeSubjectRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveGradeSubjectRelation(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_GradeSubjectRelation_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_GradeSubjectRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static GradeSubjectRelationInfo GetGradeSubjectRelationDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_GradeSubjectRelation_Detail", param, DBConnEnm.TRDBWrite);

            return (GradeSubjectRelationInfo)ORMapping.MapSingleObject(typeof(GradeSubjectRelationInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_GradeSubjectRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static GradeSubjectRelationEntityListResult GetGradeSubjectRelationEntityList(GradeSubjectRelationSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_GradeSubjectRelation_List", param, DBConnEnm.TRDBWrite);

            GradeSubjectRelationEntityListResult Result= new GradeSubjectRelationEntityListResult();
            Result.GradeSubjectRelationList = (List<GradeSubjectRelationInfo>)ORMapping.MapListObject(typeof(GradeSubjectRelationInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}