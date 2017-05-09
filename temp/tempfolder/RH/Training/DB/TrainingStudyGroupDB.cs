using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingStudyGroup ( RH_TrainingStudyGroup ) DB类
    ///</summary>
    public class TrainingStudyGroupDB
    {

        /// <summary>
        /// 添加RH_TrainingStudyGroup
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingStudyGroup(TrainingStudyGroupEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_StudyGroupName",info.StudyGroupName);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_CID",info.CID);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingStudyGroup_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingStudyGroup
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingStudyGroup(TrainingStudyGroupEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_StudyGroupName",info.StudyGroupName);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_CID",info.CID);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.Add("@i_UpdateBy",info.UpdateBy);
            param.Add("@i_UpdateTime",info.UpdateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingStudyGroup_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingStudyGroup
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingStudyGroup(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingStudyGroup_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingStudyGroup
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingStudyGroupInfo GetTrainingStudyGroupDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingStudyGroup_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingStudyGroupInfo)ORMapping.MapSingleObject(typeof(TrainingStudyGroupInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingStudyGroup
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingStudyGroupEntityListResult GetTrainingStudyGroupEntityList(TrainingStudyGroupSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingStudyGroup_List", param, DBConnEnm.TRDBWrite);

            TrainingStudyGroupEntityListResult Result= new TrainingStudyGroupEntityListResult();
            Result.TrainingStudyGroupList = (List<TrainingStudyGroupInfo>)ORMapping.MapListObject(typeof(TrainingStudyGroupInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}