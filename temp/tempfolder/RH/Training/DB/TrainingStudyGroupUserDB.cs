using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingStudyGroupUser ( RH_TrainingStudyGroupUser ) DB类
    ///</summary>
    public class TrainingStudyGroupUserDB
    {

        /// <summary>
        /// 添加RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingStudyGroupUser(TrainingStudyGroupUserEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_StudyGroupID",info.StudyGroupID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingStudyGroupUser_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingStudyGroupUser(TrainingStudyGroupUserEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_StudyGroupID",info.StudyGroupID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_Status",info.Status);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingStudyGroupUser_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingStudyGroupUser(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingStudyGroupUser_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingStudyGroupUserInfo GetTrainingStudyGroupUserDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingStudyGroupUser_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingStudyGroupUserInfo)ORMapping.MapSingleObject(typeof(TrainingStudyGroupUserInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingStudyGroupUser
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingStudyGroupUserEntityListResult GetTrainingStudyGroupUserEntityList(TrainingStudyGroupUserSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingStudyGroupUser_List", param, DBConnEnm.TRDBWrite);

            TrainingStudyGroupUserEntityListResult Result= new TrainingStudyGroupUserEntityListResult();
            Result.TrainingStudyGroupUserList = (List<TrainingStudyGroupUserInfo>)ORMapping.MapListObject(typeof(TrainingStudyGroupUserInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}