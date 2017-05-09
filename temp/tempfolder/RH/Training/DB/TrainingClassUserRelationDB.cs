using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingClassUserRelation ( RH_TrainingClassUserRelation ) DB类
    ///</summary>
    public class TrainingClassUserRelationDB
    {

        /// <summary>
        /// 添加RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingClassUserRelation(TrainingClassUserRelationEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_UserID",info.UserID);
            param.Add("@i_ClassID",info.ClassID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingClassUserRelation_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingClassUserRelation(TrainingClassUserRelationEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_ClassID",info.ClassID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingClassUserRelation_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingClassUserRelation(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingClassUserRelation_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassUserRelationInfo GetTrainingClassUserRelationDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingClassUserRelation_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingClassUserRelationInfo)ORMapping.MapSingleObject(typeof(TrainingClassUserRelationInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingClassUserRelation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingClassUserRelationEntityListResult GetTrainingClassUserRelationEntityList(TrainingClassUserRelationSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingClassUserRelation_List", param, DBConnEnm.TRDBWrite);

            TrainingClassUserRelationEntityListResult Result= new TrainingClassUserRelationEntityListResult();
            Result.TrainingClassUserRelationList = (List<TrainingClassUserRelationInfo>)ORMapping.MapListObject(typeof(TrainingClassUserRelationInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}