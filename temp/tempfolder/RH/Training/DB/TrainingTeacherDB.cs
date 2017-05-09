using System.Collections.Generic;
using System.Data;
using System.Linq;
using RH.Sql;
using RH.Training.Entity;

namespace RH.Training.DB
{
    ///<summary>
    ///RH_TrainingTeacher ( RH_TrainingTeacher ) DB类
    ///</summary>
    public class TrainingTeacherDB
    {

        /// <summary>
        /// 添加RH_TrainingTeacher
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int AddTrainingTeacher(TrainingTeacherEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_UserID",info.UserID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingTeacher_Add", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 修改RH_TrainingTeacher
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static int ModifyTrainingTeacher(TrainingTeacherEntity info)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",info.ID);
            param.Add("@i_UserID",info.UserID);
            param.Add("@i_SubTID",info.SubTID);
            param.Add("@i_CreateBy",info.CreateBy);
            param.Add("@i_CreateTime",info.CreateTime);
            param.AddByOutput("@o_Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingTeacher_Modify", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());
        }


        /// <summary>
        /// 删除RH_TrainingTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static int RemoveTrainingTeacher(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            param.AddByOutput("@Result", MySqlDbType.Int32);
            MySqlDBLib.ExecuteSP("sp_SJ_RH_TrainingTeacher_Remove", param, DBConnEnm.TRDBWrite);

            return int.Parse(param.ParamOutput.ToString());

        }

        /// <summary>
        /// 查看RH_TrainingTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingTeacherInfo GetTrainingTeacherDetail(int ID)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_ID",ID);
            DataTable dt = MySqlDBLib.GetDataTableBySP("sp_SJ_RH_TrainingTeacher_Detail", param, DBConnEnm.TRDBWrite);

            return (TrainingTeacherInfo)ORMapping.MapSingleObject(typeof(TrainingTeacherInfo),dt);
        }

        /// <summary>
        /// 查看全部RH_TrainingTeacher
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TrainingTeacherEntityListResult GetTrainingTeacherEntityList(TrainingTeacherSearcher Searcher)
        {
            MySqlParamCollection param = new MySqlParamCollection();

            param.Add("@i_PageSize",Searcher.PageSize);
            param.Add("@i_PageIndex",Searcher.PageIndex);
            param.AddByOutput("@o_TotlaCount", MySqlDbType.Int32);
            DataTable dt = MySqlDBLib.GetDataSetBySP("sp_SJ_RH_TrainingTeacher_List", param, DBConnEnm.TRDBWrite);

            TrainingTeacherEntityListResult Result= new TrainingTeacherEntityListResult();
            Result.TrainingTeacherList = (List<TrainingTeacherInfo>)ORMapping.MapListObject(typeof(TrainingTeacherInfo),dt);
            Result.TotalCount = int.Parse(param.ParamOutput.ToString());

            return Result;
        }
    }
}